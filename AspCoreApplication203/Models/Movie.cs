namespace AspCoreApplication203.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public Movie(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; } = "";


    }
}
