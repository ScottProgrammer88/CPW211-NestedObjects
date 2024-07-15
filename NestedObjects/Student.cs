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

        /// <summary>
        /// The student's date of birth
        /// </summary>
        public DateOnly DateOfBirth { get; set; }

        /// <summary>
        /// Students preferred contact phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The advisor who is assigned to the student
        /// </summary>
        public Advisor AssignedAdvisor { get; set; }
    }
}

