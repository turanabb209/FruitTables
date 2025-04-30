namespace Fruittables.Models
{
    public class ProductImage:BaseEntity
    {

        public string Image { get; set; }
        public bool? IsPrimqary { get; set; }
        public int ProductId { get; set; }

        public Product Product { get; set; }








    }
}
