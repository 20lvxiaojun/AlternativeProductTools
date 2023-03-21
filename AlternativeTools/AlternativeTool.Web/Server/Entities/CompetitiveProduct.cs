using System.Collections.Generic;

namespace AlternativeTool.Web.Server.Entities
{
    public class CompetitiveProduct
    {
        public CompetitiveProduct()
        {
            //避免空引用
            Products = new List<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public List<Product> Products { get; set; }
    }
}
