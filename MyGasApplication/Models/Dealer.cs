﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyGasApplication.Models
{
    public class Dealer
    {
        [Key]
        public int DealerId { get; set; } = 0;

        /// <summary>
        /// Gets or sets the user identifier associated with the hotel
        /// </summary>
        public string UserId { get; set; } = "";
        [ForeignKey("UserId")]
        public User user { get; set; }

        /// <summary>
        /// Gets or sets the hotel name
        /// </summary>

        public string DealerName { get; set; } = "";

        public string GasName { get; set; } = "";
        [ForeignKey("GasName")]
        public Gas gas { get; set; }


        /// <summary>
        /// Gets or sets city where hotel is located
        /// </summary>
        public string City { get; set; } = "";

        /// <summary>
        /// Gets or sets the address of the hotel
        /// </summary>
        

        /// <summary>
        /// Gets or sets the phone number of the hotel
        /// </summary>
        public string Phone { get; set; } = "";

        /// <summary>
        /// Gets or sets the description of the hotel
        /// </summary>
        public string Description { get; set; } = "";

        /// <summary>
        /// Gets or sets the starting price of the hotel
        /// </summary>
        
        /// <summary>
        /// Gets and sets the image of the hotel
        /// </summary>

        public string Image { get; set; } = "";
    }
}
