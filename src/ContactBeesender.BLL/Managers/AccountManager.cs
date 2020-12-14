using ContactBeesender.BLL.Interfaces;
using ContactBeesender.Common.Resources;
using ContactBeesender.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactBeesender.BLL.Managers
{
    /// <inheritdoc cref="IAccountManager"/>
    public class AccountManager : IAccountManager
    {
        private readonly UserManager<User> _userManager;

        public AccountManager(UserManager<User> userManager)
        {
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        public async Task<string> GetUserIdByNameAsync(string name)
        {
            var user = await _userManager.Users.FirstAsync(user => user.UserName == name);
            if (user is null)
            {
                throw new KeyNotFoundException(ErrorResource.UserNotFound);
            }

            return user.Id;
        }
    }
}
