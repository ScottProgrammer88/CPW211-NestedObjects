using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// Represents a college avisor
    /// </summary>
    internal class Advisor
    {
        /// <summary>
        /// The legal first and last name
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// The assigned school email address for the advisor
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Building and room number where the advisor's office is located
        /// </summary>
        public string OfficeLocation { get; set; }


    }
}
