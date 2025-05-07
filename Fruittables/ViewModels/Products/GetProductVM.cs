using Fruittables.Models;

namespace Fruittables.ViewModels.Products
{
    public class GetProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Volume { get; set; }


        //relational
      

        public string  CategoryName { get; set; }
        public string MainImages { get; set; }
    }
}
