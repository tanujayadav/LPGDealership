using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;


namespace MyGasApplication.Models.DTOs
{
    public class DealerDTO
    {
        /// <summary>
        /// Gets or sets the name of the hotel.
        /// </summary>
        [Required(ErrorMessage = "Dealer name cannot be empty")]
        public string DealerName { get; set; } = "";
        [Required(ErrorMessage = "DealerId cannot be empty")]

        /// <summary>
        /// Gets or sets the unique identifier for the user associated with the hotel.
        /// </summary>
        public string DealerId { get; set; } = "";
        [Required(ErrorMessage = "City cannot be empty")]

        /// <summary>
        /// Gets or sets the city where the hotel is located.
        /// </summary>
        public string City { get; set; } = "";
        [Required(ErrorMessage = "Address cannot be empty")]

        /// <summary>
        /// Gets or sets the address of the hotel.
        /// </summary>
        public string Address { get; set; } = "";
        [Required(ErrorMessage = "Phone cannot be empty")]

        /// <summary>
        /// Gets or sets the phone number of the hotel.
        /// </summary>
        public string Phone { get; set; } = "";
        [Required(ErrorMessage = "Description cannot be empty")]

        /// <summary>
        /// Gets or sets the description of the hotel.
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// Gets and Sets Image for hotel
        /// </summary>
        [Required(ErrorMessage = "Image is Mandatory")]
        public IFormFile? Image { get; set; }
    }
}