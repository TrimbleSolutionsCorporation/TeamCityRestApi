﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TcBuild.cs" company="">
//   
// </copyright>
// <summary>
//   The tc build.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace TeamcityRestTypes
{
    public class MuteDetails
    {
        /// <summary>
        /// mute information
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// login
        /// </summary>
        public string UserName { get; set; }        
        /// <summary>
        /// href for additional processing
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// gets set mute
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Timestamp
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// tests
        /// </summary>
        public List<TcTest> Tests { get; } = new List<TcTest>();
    }
}