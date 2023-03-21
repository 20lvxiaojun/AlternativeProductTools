using System.Collections.Generic;

namespace AlternativeTool.Web.Server.Entities
{
    public class Product
    {
        public Product()
        {
            //避免空引用
            CompetitiveProducts = new List<CompetitiveProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Describe { get; set; }
        public string ImageURL { get; set; }
        public List<CompetitiveProduct> CompetitiveProducts { get; set; }
    }
}
