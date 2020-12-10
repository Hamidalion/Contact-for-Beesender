using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBeesender.DAL.Entities
{
    public class Contacts
    {
        /// <summary>
        /// Name contact.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Mobile phone of contact.
        /// </summary>
        public string MobilePhone { get; set; }

        /// <summary>
        /// Designation of contact.
        /// </summary>
        public string Dear { get; set; }

        /// <summary>
        /// Tittle of Job.
        /// </summary>
        public string JobTittle { get; set; }

        /// <summary> 
        /// Birthdate of contact.
        /// </summary>
        public DateTime Birthdate { get; set; }
    }
}
