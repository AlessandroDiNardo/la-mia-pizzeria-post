namespace la_mia_pizzeria_static.Controllers
{
    public class Pizza
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }

        public Pizza(int id, string name, string description, string image, decimal price)
        {
            Id = id;
            Name = name;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
