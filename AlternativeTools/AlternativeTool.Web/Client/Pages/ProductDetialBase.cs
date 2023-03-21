using AlternativeTool.Web.Shared.Dtos;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;

namespace AlternativeTool.Web.Client.Pages
{
    public class ProductDetialBase:ComponentBase
    {
        [Parameter]
        public string ProductName { get; set; }
        public string ProductDetaial { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        public ProductDto Product { get; set; } = new ProductDto();
        protected override void OnInitialized()
        {
            Products = new List<ProductDto>() {
            new ProductDto{  Name="FR-1", Category="IC", Describe ="No1", CometitiveProductNames=new List<string>(){ "ML-1,ML-2"} },
             new ProductDto{  Name="FR-2", Category="IC", Describe ="No2",CometitiveProductNames=new List<string>(){ "Tecan-1,Tecan-2"}}
            };
            Product = Products.SingleOrDefault(x => x.Name == ProductName);
            base.OnInitialized();
        }
    }
}
