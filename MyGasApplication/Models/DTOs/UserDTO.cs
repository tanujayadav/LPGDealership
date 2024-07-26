﻿using System.ComponentModel.DataAnnotations;

namespace MyGasApplication.Models.DTOs
{
    public class UserDTO
    {
        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [Required(ErrorMessage = "Email cannot be empty")]
        public string Email { get; set; } = "";

        /// <summary>
        /// Gets or sets the role of the user and it could be nullable.
        /// </summary>
        public string? Role { get; set; }

        /// <summary>
        /// Gets or sets the authentication token for the user.
        /// </summary>
        public string? Token { get; set; }
        /// <summary>
        /// Gets name as required field
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [Required(ErrorMessage = "Password cannot be empty")]
        public string Password { get; set; } = "";
    }
}