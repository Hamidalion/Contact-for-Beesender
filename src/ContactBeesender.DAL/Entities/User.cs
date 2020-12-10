using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBeesender.DAL.Entities
{
    /// <summary>
    /// User by IdentityUser
    /// </summary>
    public class User : IdentityUser
    {
        /// <summary>
        /// Navigation to Contacts.
        /// </summary>
        public ICollection<Contacts> Contacts { get; set; }

    }
}
