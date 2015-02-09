﻿using System.Collections.Generic;
using iRacingAdmin.Classes;
using iRacingSdkWrapper;
using PostSharp.Patterns.Model;

namespace iRacingAdmin.Models.Drivers
{
    /// <summary>
    /// Represents a dictionary of session results for a driver. Contains results for all sessions.
    /// </summary>
    public class DriverResults
    {
        private int _currentSessionNumber;

        public DriverResults(Driver driver)
        {
            _driver = driver;
            _sessions = new Dictionary<int, DriverSessionResults>();
        }
        
        private readonly Dictionary<int, DriverSessionResults> _sessions;
        /// <summary>
        /// Gets the dictionary of session results for this driver.
        /// </summary>
        public Dictionary<int, DriverSessionResults> Sessions { get { return _sessions; } } 
        
        private readonly Driver _driver;
        /// <summary>
        /// Gets the driver object.
        /// </summary>
        public Driver Driver { get { return _driver; } }

        /// <summary>
        /// Checks if this driver is present in the results for the specified session.
        /// </summary>
        public bool HasResult(int sessionNumber)
        {
            return _sessions.ContainsKey(sessionNumber);
        }

        internal void SetResults(int sessionNumber, YamlQuery query, int position)
        {
            if (!this.HasResult(sessionNumber))
            {
                _sessions.Add(sessionNumber, new DriverSessionResults(_driver, sessionNumber));
            }
            _currentSessionNumber = sessionNumber;
            var results = this[sessionNumber];

            results.ParseYaml(query, position);
        }

        /// <summary>
        /// Gets the session results for this driver for the specified session number, or empty results if he does not appear in the results.
        /// </summary>
        public DriverSessionResults FromSession(int sessionNumber)
        {
            if (this.HasResult(sessionNumber)) return _sessions[sessionNumber];
            return new DriverSessionResults(_driver, sessionNumber);
        }

        /// <summary>
        /// Gets the session results for this driver for the specified session number, or empty results if he does not appear in the results.
        /// </summary>
        public DriverSessionResults this[int sessionNumber]
        {
            get { return this.FromSession(sessionNumber); }
        }

        public DriverSessionResults Current
        {
            get { return this.FromSession(_currentSessionNumber); }
        }
    }

    /// <summary>
    /// Represents the session results for a single driver in a single session.
    /// </summary>
    [NotifyPropertyChanged]
    public class DriverSessionResults
    {
        public DriverSessionResults(Driver driver, int sessionNumber)
        {
            _driver = driver;
            _sessionNumber = sessionNumber;

            this.IsEmpty = true;
        }

        private readonly Driver _driver;
        public Driver Driver { get { return _driver; } }

        private readonly int _sessionNumber;
        public int SessionNumber { get { return _sessionNumber; } }

        public bool IsEmpty { get; set; }

        public int Position { get; set; }
        public int ClassPosition { get; set; }

        public int Lap { get; set; }
        public Laptime Time { get; set; }
        public int FastestLap { get; set; }
        public Laptime FastestTime { get; set; }
        public Laptime LastTime { get; set; }
        public int LapsLed { get; set; }
        public int LapsComplete { get; set; }

        public string OutReason { get; set; }
        public int OutReasonId { get; set; }
        public bool IsOut { get { return this.OutReasonId != 0; } }

        internal void ParseYaml(YamlQuery query, int position)
        {
            this.IsEmpty = false;

            this.Position = position;
            this.ClassPosition = Parser.ParseInt(query["ClassPosition"].GetValue()) + 1;

            this.Lap = Parser.ParseInt(query["Lap"].GetValue());
            this.Time = new Laptime(Parser.ParseFloat(query["Time"].GetValue()));
            this.FastestLap = Parser.ParseInt(query["FastestLap"].GetValue());
            this.FastestTime = new Laptime(Parser.ParseFloat(query["FastestTime"].GetValue()));
            this.LastTime = new Laptime(Parser.ParseFloat(query["LastTime"].GetValue()));
            this.LapsLed = Parser.ParseInt(query["LapsLed"].GetValue());
            this.LapsComplete = Parser.ParseInt(query["LapsComplete"].GetValue());

            this.OutReasonId = Parser.ParseInt(query["ReasonOutId"].GetValue());
            this.OutReason = query["ReasonOutStr"].GetValue();
        }
    }
}
