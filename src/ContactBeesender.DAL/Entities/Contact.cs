using ContactBeesender.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBeesender.DAL.Entities
{
    public class Contact : IHasDbIdentity, IHasUserIdentity
    {
        /// <inheritdoc/>
        public int Id { get; set; }

        /// <inheritdoc/>
        public string UserId { get; set; }

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

        /// <inheritdoc/>
        public User User { get; set; }
    }
}
