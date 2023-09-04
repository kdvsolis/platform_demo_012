using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PlatformDemo.Data.Models;
using PlatformDemo.Data;

namespace PlatformDemo.Pages
{
    /// <summary>
    /// Represents the logic for rendering the index page of the application.
    /// </summary>
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexModel"/> class.
        /// </summary>
        /// <param name="context">The application database context.</param>
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets or sets the list of customers retrieved from the database.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Handles HTTP GET requests to the index page.
        /// Retrieves a list of customers from the database, including their associated orders.
        /// Calculates the total order amount for each customer and stores it in the <see cref="Customer.TotalOrderAmount"/> property.
        /// </summary>
        public async Task OnGetAsync()
        {
            Customers = await _context.Customers
                .Include(c => c.Orders)
                .ToListAsync();

            // Calculate the total order amount for each customer and store it in the Customer model
            foreach (var customer in Customers)
            {
                customer.TotalOrderAmount = customer.Orders.Sum(o => o.Amount);
            }
        }
    }
}
