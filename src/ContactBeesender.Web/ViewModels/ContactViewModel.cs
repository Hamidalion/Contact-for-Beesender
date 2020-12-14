using System;

namespace ContactBeesender.Web.ViewModels
{
    /// <summary>
    /// List view model.
    /// </summary>
    public class ContactViewModel
    {
        /// <summary>
        /// Identifier.
        /// </summary>
        public int Id { get; set; }

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
