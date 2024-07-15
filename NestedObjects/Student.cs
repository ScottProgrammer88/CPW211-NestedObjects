using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjects
{
    /// <summary>
    /// represents a individual college student
    /// </summary>
    public class Student // class declaration
    {
        /// <summary>
        /// The student's legal first name
        /// </summary>
        public string FirstName { get; set; } // auto-implemented property

        /// <summary>   
        /// The student's legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>   
        /// The assigned school email address for the student
        /// </summary>
        public string SchoolEmail { get; set; }

        public string PhoneNumber { get; set; }

        public Advisor AssignedAdvisor { get; set; }
    }
}

