using System.ComponentModel.DataAnnotations.Schema;

namespace MyGasApplication.Models.DTOs
{
    public class GasDisplayDTO
    {
        /// <summary>
        /// Gets and sets roomId
        /// </summary>
        public int GasId { get; set; } = 0;
        /// <summary>
        /// Gets and sets RoomType
        /// </summary>
        public string GasName { get; set; } = "";
        /// <summary>
        /// Gets and sets HotelID
        /// </summary>

        public int DealerId { get; set; } = 0;
        /// <summary>
        /// Gets and sets the room picture
        /// </summary>

        public string Address{ get; set; } = "";
        public string City { get; set; } = "";
        /// <summary>
        /// Gets and sets room's price
        /// </summary>
        public float Price { get; set; } = 0;
        /// <summary>
        /// Gets and sets room's capacity
        /// </summary>
        public String Availibility { get; set; } = "";
        /// <summary>
        /// Gets and sets the total rooms
        /// </summary>
        public int Quantity { get; set; } = 0;
        /// <summary>
        /// Gets and sets rooms description
        /// </summary>
        public string Description { get; set; } = "";
        /// <summary>
        /// Gets and sets room amenities list
        /// </summary>
        

    }
}