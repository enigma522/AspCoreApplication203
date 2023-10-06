using AspCoreApplication203.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspCoreApplication203.Controllers
{
    public class MovieCustomerController :Controller
    {
        public MovieCustomerViewModel  ViewModel { get; set; }

        public MovieCustomerController()
        {
            var movie = new Movie(1, "Test Movie");

            var customers = new List<Customer>
        {
            new Customer(1, "Customer 1"),
            new Customer(2, "Customer 2"),
        };

            ViewModel = new MovieCustomerViewModel(movie, customers);
        }
        public IActionResult Index()
        {
            return View(ViewModel);
        }

        
        public IActionResult Details(int id) { 
            foreach (Customer customer in ViewModel.Customers)
            {
                if (customer.Id == id)
                {
                    return Content(customer.Name);
                }
            }
            return NotFound();
        }
        
    }
}
