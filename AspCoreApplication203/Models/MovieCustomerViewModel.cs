namespace AspCoreApplication203.Models
{
    public class MovieCustomerViewModel
    {
        public Movie movie { get; set; }
        public List<Customer> Customers { get; set; }

        public MovieCustomerViewModel(Movie movie, List<Customer> customers)
        {
            this.movie = movie;
            Customers = customers;
        }

        
    }

}
