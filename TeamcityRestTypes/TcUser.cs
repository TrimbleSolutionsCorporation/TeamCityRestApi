// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TcUser.cs" company="">
//   
// </copyright>
// <summary>
//   The TeamCity User type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


namespace TeamcityTypes
{
    /// <summary>
    /// TcUser
    /// </summary>
    public class TcUser
    {
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
        /// Gets or sets the UserName.
        /// </summary>
        /// <value>
        /// The User Name.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the Href.
        /// </summary>
        /// <value>
        /// The Href.
        /// </value>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the Email.
        /// </summary>
        /// <value>
        /// The Email.
        /// </value>
        public string Email { get; set; }
    }
}
