//using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Range(0, int.MaxValue)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        public string Category { get; set; }

        public string Shelf { get; set; }

        [Range(0, int.MaxValue)]
        public int Count { get; set; }

        public string Description { get; set; }

    }
}
