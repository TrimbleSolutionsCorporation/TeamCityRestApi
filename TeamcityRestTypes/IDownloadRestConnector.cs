// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDownloadRestConnector.cs" company="">
//   
// </copyright>
// <summary>
//   The DownloadRestConnector interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamcityTypes
{
    /// <summary>
    /// The DownloadRestConnector interface.
    /// </summary>
    public interface IDownloadRestConnector
    {
        #region Public Methods and Operators

        /// <summary>
        /// The download artifact.
        /// </summary>
        /// <param name="config">
        /// The config.
        /// </param>
        /// <param name="url">
        /// The url.
        /// </param>
        /// <param name="fileOut">
        /// The file out.
        /// </param>
        void DownloadArtifact(ITeamcityConfiguration config, string url, string fileOut, bool useLocalDisk);

        #endregion
    }
}