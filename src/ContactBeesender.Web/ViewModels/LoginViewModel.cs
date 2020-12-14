using ContactBeesender.Common.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactBeesender.Web.ViewModels
{
    /// <summary>
    /// Login view model.
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// Username.
        /// </summary>
        [Required]
        [Display(Name = nameof(Username))]
        public string Username { get; set; }

        /// <summary>
        /// Password.
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = nameof(Password))]
        public string Password { get; set; }

        /// <summary>
        /// Remember me.
        /// </summary>
        [Display(Name = DataAnnotationConstant.DispayRememberMe)]
        public bool RememberMe { get; set; }

        /// <summary>
        /// Return url.
        /// </summary>
        public string ReturnUrl { get; set; }
    }
}
