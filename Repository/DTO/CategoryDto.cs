using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.DTO
{
    [Table("Categories")]
    public class CategoryDto
    {
        [Key]
        public int CategoryId { get; set;}
        public string CategoryName { get; set;}
        public string Description { get; set; }

        public byte[] Picture { get; set; }
    }
}
