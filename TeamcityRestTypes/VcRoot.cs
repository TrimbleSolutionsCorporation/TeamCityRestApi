// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TcUser.cs" company="">
//   
// </copyright>
// <summary>
//   The TeamCity User type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System.Collections.Generic;

namespace TeamcityRestTypes
{
    /// <summary>
    /// TcUser
    /// </summary>
    public class VcRoot
    {
        public VcRoot()
        {
            Properties = new Dictionary<string, string>();
        }

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
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets modification interval
        /// </summary>
        public long ModificationCheckInterval { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, string> Properties { get; }
    }
}
