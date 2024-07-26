﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyGasApplication.Models.DTOs
{
    public class ReviewDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user submitting the review.
        /// </summary>
        [Required(ErrorMessage = "User Id cannot be empty")]
        public string UserId { get; set; } = "";

        /// <summary>
        /// Gets or sets the unique identifier for the hotel being reviewed.
        /// </summary>
        [Required(ErrorMessage = "Hotel Id cannot be empty")]
        public int GasId { get; set; } = 0;

        /// <summary>
        /// Gets or sets the review text provided by the user.
        /// </summary>
        [Required(ErrorMessage = "Review cannot be empty")]
        public string Reviews { get; set; } = "";

        /// <summary>
        /// Gets or sets the rating given by the user for the hotel.
        /// </summary>
        [Required(ErrorMessage = "Rating cannot be empty")]
        public float Rating { get; set; } = 0;
    }
}