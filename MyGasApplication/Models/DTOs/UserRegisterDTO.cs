﻿using System.ComponentModel.DataAnnotations;

namespace MyGasApplication.Models.DTOs
{
    public class UserRegisterDTO : UserDTO
    {
        /// <summary>
        /// Gets retype password for verification as required field
        /// </summary>
        [Required(ErrorMessage = "Re type password cannot be empty")]
        [Compare("Password", ErrorMessage = "Password and retype password do not match")]
        public string ReTypePassword { get; set; } = "";

        /// <summary>
        /// Gets Phone as required field
        /// </summary>
        [Required(ErrorMessage = "Phone cannot be empty")]
        public string Phone { get; set; } = "";
        /// <summary>
        /// Gets address as required field
        /// </summary>
        [Required(ErrorMessage = "Address cannot be empty")]
        public string Address { get; set; } = "";

    }
}