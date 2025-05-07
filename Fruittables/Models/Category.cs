using System.ComponentModel.DataAnnotations;

namespace Fruittables.Models
{
    public class Category:BaseEntity
    {
        [MinLength(4,ErrorMessage ="4-den qisa ola bilmez")]
        [MaxLength(50,ErrorMessage ="50-den uzun ola bilmez")]
        public string Name { get; set; }
        public List<Product> Products { get; set; }

    }
}
