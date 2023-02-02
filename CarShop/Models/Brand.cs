using System.ComponentModel.DataAnnotations;

namespace CarShop.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The field is required")]
        public string Name { get; set; } = default!;
        public ICollection<Car>? Cars { get; set; }
    }
}
