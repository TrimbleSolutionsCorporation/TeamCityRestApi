// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TCBuildConfigurationType.cs" company="">
//   
// </copyright>
// <summary>
//   The build configuration type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamcityTypes
{
    using System;

    /// <summary>
    ///     The build configuration type.
    /// </summary>
    [Serializable]
    public class TCBuildConfigurationType
    {
        public TCBuildConfigurationType()
        {
            this.OfficialBuild = "no";
            this.BranchLocator = string.Empty;
        }

        #region Public Properties

        /// <summary>
        ///     Gets or sets the build id ref.
        /// </summary>
        public string BuildIdRef { get; set; }

        /// <summary>
        ///     Gets or sets the href.
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the parent project id.
        /// </summary>
        public string ParentProjectId { get; set; }

        /// <summary>
        ///     Gets or sets the project name.
        /// </summary>
        public string ProjectName { get; set; }

        /// <summary>
        ///     Gets or sets the web url.
        /// </summary>
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public string Configuration { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        /// <value>
        /// The platform.
        /// </value>
        public string Platform { get; set; }

        /// <summary>
        /// Gets or sets the official build.
        /// </summary>
        /// <value>
        /// The official build.
        /// </value>
        public string OfficialBuild { get; set; }

        /// <summary>
        /// Gets or sets the branch.
        /// </summary>
        /// <value>
        /// The branch.
        /// </value>
        public string BranchLocator { get; set; }

        /// <summary>
        /// Gets or sets the artifact.
        /// </summary>
        /// <value>
        /// The artifact.
        /// </value>
        public string Artifact { get; set; }


        #endregion
    }
}