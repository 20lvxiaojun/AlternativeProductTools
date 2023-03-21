using AlternativeTool.Web.Client.Services.Contacts;
using AlternativeTool.Web.Shared.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AlternativeTool.Web.Client.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<ProductDto>> GetAllProducts()
        {
          
                var response = await httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>($"AlternativeTool/get/CompetitiveProductAll");
            return response;    
            //if (response.IsSuccessStatusCode)
                //{
                //    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                //    {
                //        return Enumerable.Empty<ProductDto>();
                //    }
                //    return await response.Content.ReadFromJsonAsync<IEnumerable<ProductDto>>();
                //}
                //else
                //{
                //    var message = await response.Content.ReadAsStringAsync();
                //    throw new Exception($"Http status code: {response.StatusCode} message: {message}");
                //}
            
        }

        public Task<IEnumerable<ProductDto>> GetProductByCompetitiveName(string CName)
        {
            throw new System.NotImplementedException();
        }
    }
}
