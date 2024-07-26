using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyGasApplication.Models
{
    public class Gas
    {
        [Key]
        public int GasId { get; set; } = 0;

        /// <summary>
        /// gets or sets the type of room
        /// </summary>
        public string GasName { get; set; } = "";

        /// <summary>
        /// Gets or sets the hotel identifier associated with the room
        /// </summary>
        public int DealerId { get; set; } = 0;
        [ForeignKey("HotelId")]
        public Dealer dealer { get; set; }

        /// <summary>
        /// Gets or sets the path of image representing the room
        /// </summary>
       
        /// <summary>
        /// Gets or sets price of room based on the room type
        /// </summary>
        public float Price { get; set; } = 0;
        public string City { get; set; } = "";
        public string Address { get; set; } = "";
        public string Availibility { get; set; } = "";


        /// <summary>
        /// Gets or sets the occupants of the room
        /// </summary>

        public int Quantity { get; set; } = 0;

        /// <summary>
        /// Gets or sets the total room of available room
        /// </summary>




        /// <summary>
        /// Gets or sets the description
        /// </summary>

        public string Description { get; set; } = "";
    }
}
