// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TcBuild.cs" company="">
//   
// </copyright>
// <summary>
//   The tc build.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;

namespace TeamcityRestTypes
{
    /// <summary>
    /// TcTest
    /// </summary>
    public class TcTest
    {
        public TcTest()
        {
            MuteInformation = new List<MuteDetails>();
            MetaInformation = new List<TcMetaData>();
        }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public string Status { get; set; }
        /// <summary>
        /// Gets or sets the duration.
        /// </summary>
        /// <value>
        /// The duration.
        /// </value>
        public int Duration { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="TcTest"/> is muted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if muted; otherwise, <c>false</c>.
        /// </value>
        public bool Muted { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [currently muted].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [currently muted]; otherwise, <c>false</c>.
        /// </value>
        public bool CurrentlyMuted { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether [currently investigated].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [currently investigated]; otherwise, <c>false</c>.
        /// </value>
        public bool CurrentlyInvestigated { get; set; }
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        public string Href { get; set; }
        /// <summary>
        /// failure details if test is failing
        /// </summary>
        public string FailureDetails { get; set; }
        /// <summary>
        /// mute information
        /// </summary>
        public List<MuteDetails> MuteInformation { get; set; }

        /// <summary>
        /// Test Metadata
        /// </summary>
        public List<TcMetaData> MetaInformation { get; private set; }

        /// <summary>
        /// first build that failure occured
        /// </summary>
        public TcTest FirstFailure { get; set; }

        public int PassedCnt { get; set; }
        public int MutedCnt { get; set; }
        public int FailingCnt { get; set; }
    }
}