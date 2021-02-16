// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TCProject.cs" company="">
//   
// </copyright>
// <summary>
//   The tc project.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace TeamcityRestTypes
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     The tc project.
    /// </summary>
    [Serializable]
    public class TcProject
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="TcProject"/> class.
        /// </summary>
        public TcProject()
        {
            this.Projects = new List<TcProject>();
            this.BuildConfigurationTypes = new List<TCBuildConfigurationType>();
        }

        #endregion

        #region Public Properties

        /// <summary>
        /// Gets or sets the build configuration types.
        /// </summary>
        public List<TCBuildConfigurationType> BuildConfigurationTypes { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the parent project id.
        /// </summary>
        public string ParentProjectId { get; set; }

        /// <summary>
        /// Gets or sets the projects.
        /// </summary>
        public List<TcProject> Projects { get; set; }

        /// <summary>
        /// Gets or sets the web url.
        /// </summary>
        public string WebUrl { get; set; }

        public string Version { get; set; }

        public object FirstOrDefault()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}