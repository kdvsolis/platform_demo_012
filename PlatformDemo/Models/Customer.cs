namespace PlatformDemo.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        // Define the TotalOrderAmount property
        public decimal TotalOrderAmount { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}
