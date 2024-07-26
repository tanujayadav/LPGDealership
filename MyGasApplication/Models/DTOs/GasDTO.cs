using System.ComponentModel.DataAnnotations;



namespace MyGasApplication.Models.DTOs
{
    public class GasDTO
    {

        /// <summary>
        /// Gets or sets the type of the room.
        /// </summary>
        [Required(ErrorMessage = "Room type cannot be empty")]
        public string GasName { get; set; } = "";

        /// <summary>
        /// Gets or sets the unique identifier for the hotel to which the room belongs.
        /// </summary>
        [Required(ErrorMessage = "Hotel ID cannot be empty")]
        public int GasId { get; set; } = 0;

        [Required(ErrorMessage = "City cannot be empty")]
        public string City { get; set; } = "";


        [Required(ErrorMessage = "Address cannot be empty")]
        public string Address { get; set; } = "";

        /// <summary>
        /// Gets or sets the price of the room.
        /// </summary>
        [Required(ErrorMessage = "Price cannot be empty")]
        public float Price { get; set; } = 0;

        /// <summary>
        /// Gets or sets the number of occupants for the room.
        /// </summary>
        [Required(ErrorMessage = "gas cannot be empty")]
        public string Availibility { get; set; } = "";
        [Required(ErrorMessage = "Available gas cannot be empty")]

        /// <summary>
        /// Gets or sets the total number of available rooms.
        /// </summary>
        public int Quantity { get; set; } = 0;

        /// <summary>
        /// Gets or sets the description of the room.
        /// </summary>
        [Required(ErrorMessage = "Description cannot be empty")]
        public string Description { get; set; } = "";

        /// <summary>
        /// Gets or sets the path to the image representing the room.
        /// </summary>
        [Required(ErrorMessage = "Images cannot be empty")]
        public IFormFile? Picture { get; set; }

        /// <summary>
        /// Gets or sets the list of amenities available in the room.
        /// </summary>
        

    }
}