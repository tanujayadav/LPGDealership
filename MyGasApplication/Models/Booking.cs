using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MyGasApplication.Models
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; } = 0;

        /// <summary>
        /// Gets or sets the unique identifier for the user making the booking.
        /// </summary>
        public string UserId { get; set; } = "";

        /// <summary>
        /// Gets or sets the associated User object for the booking user.
        /// </summary>
        [ForeignKey("UserId")]
        public User user { get; set; }

        /// <summary>
        /// Gets or sets the booking date.
        /// </summary>
        public string BookingDate { get; set; } = "";

        /// <summary>
        /// Gets or sets the check in date
        /// </summary>
        public string? Bookingopen { get; set; } = "";

        /// <summary>
        /// Gets or sets the check out
        /// </summary>
       

        /// <summary>
        /// Gets or sets the unique identifier for the booked room.
        /// </summary>
        public int GasId { get; set; } = 0;
        [ForeignKey("GasId")]
        public Gas gas { get; set; }

        public int DealerId { get; set; } = 0;
        [ForeignKey("DealerId")]
        public Dealer dealer { get; set; }

        /// <summary>
        /// Gets or sets the status of the booking
        /// </summary>
        public string Status { get; set; } = "";

        /// <summary>
        /// Gets or sets the total number of booked
        /// </summary>
       public int Quantity { get; set; } = 0;
        [ForeignKey("Quantity")]
       

        /// <summary>
        /// Gets or sets the total price for the booking
        /// </summary>
        public float Price { get; set; } = 0;

        /// <summary>
        /// Gets and sets the payment method
        /// </summary>
        public string Payment { get; set; } = "";

    }
}
