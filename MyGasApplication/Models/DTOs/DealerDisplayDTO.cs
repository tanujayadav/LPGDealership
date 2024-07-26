namespace MyGasApplication.Models.DTOs
{
    public class DealerDisplayDTO
    {
        public int DealerId { get; set; } = 0;
        /// <summary>
        /// Gets and sets RoomType
        /// </summary>
        public string DealerName { get; set; } = "";
        /// <summary>
        /// Gets and sets HotelID
        /// </summary>


        /// <summary>
        /// Gets and sets the room picture
        /// </summary>

        public string Phone { get; set; } = "";
        public string City { get; set; } = "";
        /// <summary>
        /// Gets and sets room's price
        /// </summary>

        /// <summary>
        /// Gets and sets room's capacity
        /// </summary>

        /// <summary>
        /// Gets and sets the total rooms
        /// </summary>
        public string UserId { get; set; } = "";
        /// <summary>
        /// Gets and sets rooms description
        /// </summary>
        public string Description { get; set; } = "";


        public float AvgRating { get; set; } = 0;
        /// <summary>
        /// Gets and sets room amenities list
        /// </summary>
    }
}
