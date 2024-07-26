using System.ComponentModel.DataAnnotations.Schema;

namespace MyGasApplication.Models.DTOs
{
    public class DisplayGasBookingDTO
    {



        /// <summary>
        /// Gets and sets Booking ID
        /// </summary>
        public int BookingId { get; set; } = 0;
        /// <summary>
        /// Gets and sets userID
        /// </summary>
        public string UserId { get; set; } = "";
        /// <summary>
        /// Gets and sets booking date
        /// </summary>
        public string BookingDate { get; set; } = "";
        /// <summary>
        /// Gets and sets chechIn date
        /// </summary>
        public string? BookingOpen { get; set; } = "";
        /// <summary>
        /// Gets and sets checkOut date
        /// </summary>
       
        /// <summary>
        /// Gets and sets roomId
        /// </summary>
        public int DealerId { get; set; } = 0;
        public int GasId { get; set; } = 0;
        /// <summary>
        /// Gets and sets booking status
        /// </summary>
        public string Status { get; set; } = "";
        /// <summary>
        /// Gets and sets total rooms booked
        /// </summary>
        public int Quantity { get; set; } = 0;
        /// <summary>
        /// Gets and sets the total price
        /// </summary>
        public float Price { get; set; } = 0;
        /// <summary>
        /// Gets and sets payment method
        /// </summary>
        public string Payment { get; set; } = "";
        /// <summary>
        /// Gets and sets the hotel name
        /// </summary>
        public string? DealerName { get; set; } = "";
        /// <summary>
        /// Gets and sets the room type
        /// </summary>

        public string GasName { get; set; } = "";
    }
}