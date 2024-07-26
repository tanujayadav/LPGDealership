﻿using System.ComponentModel.DataAnnotations;

namespace MyGasApplication.Models
{
    public class User
    {
        
        
            /// <summary>
            /// Gets or sets the unique identifier for the user
            /// </summary>
            [Key]
            public string Email { get; set; } = "";

            /// <summary>
            /// Gets or sets the password for the user
            /// </summary>
            public byte[] Password { get; set; } = new byte[32];

            /// <summary>
            /// Gets or sets the name of the user
            /// </summary>
            public string Name { get; set; } = "";

            /// <summary>
            /// Gets or sets the phone number of the user
            /// </summary>
            public string Phone { get; set; } = "";

            /// <summary>
            /// Gets or sets the address of the user
            /// </summary>
            public string Address { get; set; } = "";

            /// <summary>
            /// Gets or sets the role of the user
            /// </summary>        

            public string Role { get; set; } = "";
            /// <summary>
            /// Gets and sets the key value
            /// </summary>

            public byte[] Key { get; set; } = new byte[32];
        }
    }

