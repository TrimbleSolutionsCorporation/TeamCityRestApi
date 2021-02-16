// --------------------------------------------------------------------------------------------------------------------
// <copyright file="QueueBuild.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the QueueBuild type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Diagnostics;

namespace TeamcityRestTypes
{
    /// <summary>
    /// The queue build.
    /// </summary>
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public class QueueBuild
    {
        #region Public Properties

        public string BuildTypeName { get; set; }

        public string BuildTypeHref { get; set; }

        public string BuildTypeWebUrl { get; set; }

        public string ProjectName { get; set; }

        public string ProjectId { get; set; }

        /// <summary>
        /// build id
        /// </summary>
        public string Id { get; set; }

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

        /// <summary>
        /// Wait Reason
        /// </summary>
        public string WaitReason { get; set; }

        /// <summary>
        /// status
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        public int CompletePercentage { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        public bool ProbablyHanging { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        public bool Outdated { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        public string CurrentStageText { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        public int ElapsedSeconds { get; set; }

        /// <summary>
        /// Gets or sets the platform.
        /// </summary>
        public int EstimatedTotalSeconds { get; set; }

        /// <summary>
        /// build start esimate
        /// </summary>
        public DateTime StartEstimate { get; set; }

        /// <summary>
        /// queued date
        /// </summary>
        public DateTime QueuedDate { get; set; }

        /// <summary>
        /// start date
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// if build is assigned with a agent
        /// </summary>
        public TcAgent RunAgent { get; set; }
        /// <summary>
        /// number
        /// </summary>
        public string Number { get; set; }

        public TcComment Comment { get; set; }

        /// <summary>
        /// debugger display helper
        /// </summary>
        private string DebuggerDisplay
        {
            get
            {
                if (RunAgent != null && Comment != null)
                {
                    return $"{BuildTypeName} : ({Number}) ({State}) => {BuildTypeId} : {StartEstimate} => {RunAgent.Name} => {Comment.Text} => {WaitReason}";
                }
                else
                {
                    return $"{BuildTypeName} : ({Number}) ({State}) => {BuildTypeId} : {StartEstimate} => {WaitReason}";
                }
            }
        }

        #endregion
    }
}