using ContactBeesender.BLL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ContactBeesender.BLL.Interfaces
{
    /// <summary>
    /// Manager of Contacts.
    /// </summary>
    public interface IContactManager
    {
        /// <summary>
        /// Create contact by user identifier.
        /// </summary>
        /// <param name="contactDto">Contact data transfer object.</param>
        Task CreateAsync(ContactDto contactDto);

        /// <summary>
        /// Get contact by identifier.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="userId">User identifier.</param>
        /// <returns>Contact data transfer objects.</returns>
        Task<ContactDto> GetContactAsync(int id, string userId);

        /// <summary>
        /// Get contact by user identifier.
        /// </summary>
        /// <param name="userId">User identifier.</param>
        /// <returns>List of Contact data transfer objects.</returns>
        Task<IEnumerable<ContactDto>> GetContactAsync(string userId);

        /// <summary>
        /// Delete contact by identifier.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="userId">User identifier.</param>
        Task DeleteAsync(int id, string userId);

        /// <summary>
        /// Change contact status.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="userId">User identifier.</param>
        Task ChangeContactStatusAsync(int id, string userId);

        /// <summary>
        /// Update contact by identifier.
        /// </summary>
        /// <param name="contactDto">Contact data transfer object.</param>
        Task UpdateAsync(ContactDto contactDto);
    }
}
