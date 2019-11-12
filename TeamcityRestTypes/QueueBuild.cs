// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueBuild.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the QueueBuild type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
namespace TeamcityTypes
{
    /// <summary>
    /// The queue build.
    /// </summary>
    public class QueueBuild
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the branch name.
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        ///     Gets or sets the build type id.
        /// </summary>
        public string BuildTypeId { get; set; }

        /// <summary>
        /// Gets or sets the default branch.
        /// </summary>
        public bool DefaultBranch { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the state.
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Gets or sets the task id.
        /// </summary>
        public int TaskId { get; set; }

        /// <summary>
        /// Gets or sets the web url.
        /// </summary>
        public string WebUrl { get; set; }

        #endregion
    }
}