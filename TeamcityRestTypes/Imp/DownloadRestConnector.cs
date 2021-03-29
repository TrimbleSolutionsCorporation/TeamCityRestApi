// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadRestConnector.cs" company="">
//   
// </copyright>
// <summary>
//   The download rest connector.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamcityTypes.Imp
{
    using RestSharp;
    using RestSharp.Authenticators;

    using System;
    using System.IO;

    using TeamcityRestTypes;

    /// <summary>
    /// The download rest connector.
    /// </summary>
    public class DownloadRestConnector : IDownloadRestConnector
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
        public void DownloadArtifact(ITeamcityConfiguration config, string url, string fileOut, bool useLocalDisk)
        {
            string endFilePath = fileOut;
            if (useLocalDisk)
            {
                endFilePath = Path.GetTempFileName();
            }

            var client = new RestClient(config.Hostname)
            {
                Authenticator = new HttpBasicAuthenticator(config.Username, config.Password)
            };

            using (FileStream writer = File.OpenWrite(endFilePath))
            {
                var request = new RestRequest(url)
                {
                    ResponseWriter = responseStream => responseStream.CopyTo(writer)
                };
                client.DownloadData(request);
            }


            if (useLocalDisk)
            {
                try
                {
                    File.Copy(endFilePath, fileOut, true);
                    File.Delete(endFilePath);
                }
                catch (Exception ex)
                {
                    File.Delete(endFilePath);
                    throw ex;
                }
            }
        }

        #endregion
    }
}