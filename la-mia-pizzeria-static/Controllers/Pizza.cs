using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Controllers
{
    public class Pizza
    {
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public int Id { get; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(25, ErrorMessage = "Il nome non può avere più di 25 caratteri")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public decimal Price { get; set; }

        public Pizza() { }

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
