// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TcBuild.cs" company="">
//   
// </copyright>
// <summary>
//   The tc build.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamcityTypes
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The tc build.
    /// </summary>
    [Serializable]
    public class TcBuild
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TcBuild"/> class.
        /// </summary>
        public TcBuild()
        {
            this.OfficialBuild = "no";
            this.ChangesData = new List<Change>();
            this.Tests = new List<TcTest>();
            this.Problems = new List<TcProblem>();
            this.Artifacts = new List<Artifact>();
            this.Properties = new List<BuildProperty>();
            this.ResultingProperties = new List<BuildProperty>();
        }

        /// <summary>
        /// Gets or sets the build type id.
        /// </summary>
        /// <value>
        /// The build type identifier.
        /// </value>
        public string BuildTypeId { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string BuildConfigurationName { get; set; }

        /// <summary>
        /// Gets or sets the build configuration identifier.
        /// </summary>
        /// <value>
        /// The build configuration identifier.
        /// </value>
        public string BuildConfigurationId { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>
        /// The number.
        /// </value>
        public string Number { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        /// <value>
        /// The state.
        /// </value>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the changes.
        /// </summary>
        /// <value>
        /// The changes.
        /// </value>
        public string Changes { get; set; }

        /// <summary>
        /// Gets or sets the changes data.
        /// </summary>
        /// <value>
        /// The changes data.
        /// </value>
        public List<Change> ChangesData { get; set; }

        /// <summary>
        /// Gets the tests.
        /// </summary>
        /// <value>
        /// The tests.
        /// </value>
        public List<TcTest> Tests { get; private set; }

        /// <summary>
        ///     Gets or sets the status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        ///     Gets or sets the statusText.
        /// </summary>
        public string StatusText { get; set; }

        /// <summary>
        ///     Gets or sets the Problems count.
        /// </summary>
        public int ProblemOccurrencesCount { get; set; }

        /// <summary>
        ///     Gets or sets the Problems list.
        /// </summary>
        public List<TcProblem> Problems { get; set; }

        /// <summary>
        ///     Gets or sets the Problems Href.
        /// </summary>
        public string ProblemOccurrencesHref { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the AgentName.
        /// </summary>
        /// <value>
        /// The Agent Name.
        /// </value>
        public string AgentName { get; set; }

        /// <summary>
        /// Gets or sets the AgentId.
        /// </summary>
        /// <value>
        /// The Agent Id.
        /// </value>
        public string AgentId { get; set; }

        /// <summary>
        /// Gets or sets the TriggerBuildId.
        /// </summary>
        /// <value>
        /// The Trigger Build Id.
        /// </value>
        public string TriggerBuildId { get; set; }

        /// <summary>
        /// Gets or sets the TriggerBuildTypeId.
        /// </summary>
        /// <value>
        /// The Trigger Build Type Id.
        /// </value>
        public string TriggerBuildTypeId { get; set; }

        /// <summary>
        /// Gets or sets the TriggerUser.
        /// </summary>
        /// <value>
        /// The Trigger User.
        /// </value>
        public string TriggerUser { get; set; }

        /// <summary>
        /// Gets or sets the TriggerType.
        /// </summary>
        /// <value>
        /// The Trigger Type.
        /// </value>
        public string TriggerType { get; set; }

        /// <summary>
        /// Gets or sets the web url.
        /// </summary>
        /// <value>
        /// The web URL.
        /// </value>
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets the artifact href.
        /// </summary>
        /// <value>
        /// The artifact href.
        /// </value>
        public string ArtifactHref { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        /// <value>
        /// The platform.
        /// </value>
        public string Platform { get; set; }

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public string Configuration { get; set; }

        /// <summary>
        /// Gets or sets the branch.
        /// </summary>
        /// <value>
        /// The branch.
        /// </value>
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the official build.
        /// </summary>
        /// <value>
        /// The official build.
        /// </value>
        public string OfficialBuild { get; set; }

        /// <summary>
        /// Gets or sets the artifact.
        /// </summary>
        /// <value>
        /// The artifact.
        /// </value>
        public string Artifact { get; set; }

        /// <summary>
        /// Gets or sets the start time.
        /// </summary>
        /// <value>
        /// The start time.
        /// </value>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time.
        /// </summary>
        /// <value>
        /// The end time.
        /// </value>
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the queued time.
        /// </summary>
        /// <value>
        /// The queued time.
        /// </value>
        public DateTime QueuedTime { get; set; }

        /// <summary>
        /// Gets or sets the artifacts.
        /// </summary>
        /// <value>
        /// The artifacts.
        /// </value>
        public List<Artifact> Artifacts { get; set; }

        /// <summary>
        /// Gets or sets the Properties.
        /// </summary>
        /// <value>
        /// The Build Properties.
        /// </value>
        public List<BuildProperty> Properties { get; set; }

        /// <summary>
        /// Gets or sets the ResultingProperties.
        /// </summary>
        /// <value>
        /// The Resulting Properties.
        /// </value>
        public List<BuildProperty> ResultingProperties { get; set; }
    }
}