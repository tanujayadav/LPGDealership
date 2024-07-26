namespace MyGasApplication.Models.DTOs
{
    public class UpdateGasDTO
    {
        public string GasName { get; set; } = "";
        /// <summary>
        /// Gets and sets hotel's city
        /// </summary>
        public string City { get; set; } = "";
        public string Address { get; set; } = "";

        public int Quantity { get; set; } = 0;
        public float Price { get; set; } = 0;

        public string Availibility { get; set; } = "";


        /// <summary>
        /// Gets and sets the hotel's address
        /// </summary>

        /// <summary>
        /// Gets and sets hotel's phone
        /// </summary>

        /// <summary>
        /// Gets and sets description
        /// </summary>
        public string Description { get; set; } = "";
    }
}
