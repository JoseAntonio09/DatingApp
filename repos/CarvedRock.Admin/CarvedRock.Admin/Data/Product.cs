using System.ComponentModel.DataAnnotations.Schema;
namespace CarvedRock.Admin.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
    }
}
