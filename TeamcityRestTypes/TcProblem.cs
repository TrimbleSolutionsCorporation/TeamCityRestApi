using System;
using System.Collections.Generic;
using System.Text;

namespace TeamcityTypes
{
    public class TcProblem
    {
        /// <summary>
        /// Gets or sets the additional data.
        /// </summary>
        /// <value>
        /// The Additional Data.
        /// </value>
        public string AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the ProblemIdentity. not to be confused with id
        /// </summary>
        /// <value>
        /// The ProblemIdentity.
        /// </value>
        public string Identity { get; set; }

        /// <summary>
        /// Gets or sets the problem Details.
        /// </summary>
        /// <value>
        /// The Details.
        /// </value>
        public string Details { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        /// <value>
        /// The href.
        /// </value>
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the ProblemType.
        /// </summary>
        /// <value>
        /// The ProblemType.
        /// </value>
        public string Type { get; set; }
    }
}
