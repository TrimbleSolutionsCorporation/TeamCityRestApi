// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ITeamcityConfiguration.cs" company="">
//   
// </copyright>
// <summary>
//   The TeamcityConfiguration interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace TeamcityRestTypes
{
    /// <summary>
    /// The TeamcityConfiguration interface.
    /// </summary>
    public interface ITeamcityConfiguration
    {
        #region Public Properties

        /// <summary>
        ///     Gets the hostname.
        /// </summary>
        string Hostname { get; }

        /// <summary>
        ///     Gets the password.
        /// </summary>
        string Password { get; }

        /// <summary>
        /// Token
        /// </summary>
        string Token { get; }

        /// <summary>
        ///     Gets the username.
        /// </summary>
        string Username { get; }

        #endregion
    }
}