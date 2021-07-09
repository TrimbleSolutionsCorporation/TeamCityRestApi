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
    /// Teamcity Change
    /// </summary>
    public class Change
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the version.
        /// </summary>
        /// <value>
        /// The version.
        /// </value>
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the name of the user.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the date.
        /// </summary>
        /// <value>
        /// The date.
        /// </value>
        public string Date { get; set; }

        /// <summary>
        /// Gets or sets the web URL.
        /// </summary>
        /// <value>
        /// The web URL.
        /// </value>
        public string WebUrl { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the comment.
        /// </summary>
        /// <value>
        /// The comment.
        /// </value>
        public string Comment { get; set; }

        /// <summary>
        /// Gets or sets the changed files.
        /// </summary>
        /// <value>
        /// The changed files.
        /// </value>
        public List<string> ListofChangedFiles { get; set; }

        public Change()
        {
            this.ListofChangedFiles = new List<string>();
        }
    }
}