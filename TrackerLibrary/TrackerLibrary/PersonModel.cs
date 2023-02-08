using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// Holds all relevant information about a person.
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// Represents the person's first name.
        /// </summary>
        public string FirstName { get; set;  }
        /// <summary>
        /// Represents the person's last name.
        /// </summary>
        public string LastName { get; set;  }
        /// <summary>
        /// Represents the person's email address,
        /// </summary>
        public string Email { get; set;  }
        /// <summary>
        /// Represents the person's phone number. 
        /// </summary>
        public string CellphoneNumber { get; set;  }
    }
}
