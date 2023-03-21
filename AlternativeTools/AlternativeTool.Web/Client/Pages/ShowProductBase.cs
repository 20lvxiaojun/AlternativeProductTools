using AlternativeTool.Web.Client.Services.Contacts;
using AlternativeTool.Web.Shared.Dtos;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace AlternativeTool.Web.Client.Pages
{
    public class ShowProductBase:ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        HttpClient httpClient  { get;set; }
        //待展示的产品
        public IEnumerable<ProductDto> Products { get; set; }
        //错误信息
        public string ErrorMessage { get; set; }
        protected override async Task OnInitializedAsync()
        {
            Products = new List<ProductDto>() { 
            new ProductDto{  Name="FR-1", Category="IC", Describe ="No1", CometitiveProductNames=new List<string>(){ "ML-1,ML-2"} },
            new ProductDto{  Name="FR-2", Category="IC", Describe ="No2",CometitiveProductNames=new List<string>(){ "Tecan-1,Tecan-2"}}
            };
            Products = await ProductService.GetAllProducts();
            //try
            //{
            //    Products = await ProductService.GetAllProducts();
            //}
            //catch (Exception ex)
            //{
            //    ErrorMessage = ex.Message;

            //}
        }
    }
}
