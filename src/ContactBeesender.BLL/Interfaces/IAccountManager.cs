using System.Threading.Tasks;

namespace ContactBeesender.BLL.Interfaces
{

    /// <summary>
    /// Account Manager interface.
    /// </summary>
    public interface IAccountManager
    {
        /// <summary>
        /// Get user identifier by name.
        /// </summary>
        /// <param name="name">User name.</param>
        /// <returns>Identifier (GUID).</returns>
        Task<string> GetUserIdByNameAsync(string name);
    }

}
