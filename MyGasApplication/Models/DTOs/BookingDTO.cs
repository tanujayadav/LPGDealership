using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelBookingApplication.Models.DTOs
{
    public class BookingDTO
    {
        /// <summary>
        /// Gets or sets the unique identifier for the user.
        /// </summary>

        [Required(ErrorMessage = "User ID cannot be empty")]

        public String UserId { get; set; } = "";
        /// <summary>
        /// Gets or sets the check-in date  for a reservation.
        /// </summary>
        

        /// <summary>
        /// Gets or sets the check-out date for a reservation.
        /// </summary>
        [Required(ErrorMessage = "Booking Date cannot be empty")]
        public string BookingDate { get; set; } = "";

        /// <summary>
        /// Gets or sets the unique identifier for the room.
        /// </summary>


        [Required(ErrorMessage = "Room ID cannot be empty")]
        public int GasId { get; set; } = 0;

        /// <summary>
        /// Gets or sets the total number of rooms for a reservation.
        /// </summary>
        [Required(ErrorMessage = "Total rooms cannot be empty")]
        public int Quantity { get; set; } = 0;
        /// <summary>
        /// Gets and sets the payment method 
        /// </summary>

        public string Payment { get; set; } = "";

    }
}