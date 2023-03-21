using AlternativeTool.Web.Server.Entities;
using AlternativeTool.Web.Server.Extensions;
using AlternativeTool.Web.Server.Repositories;
using AlternativeTool.Web.Server.Repositories.Contracts;
using AlternativeTool.Web.Shared.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlternativeTool.Web.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlternativeToolsController : ControllerBase
    {
        private readonly IProductRepositroy repositroy;

        public AlternativeToolsController(IProductRepositroy repositroy)
        {
            this.repositroy = repositroy;
        }

        [HttpPost,Route("add/Product")]
        public async Task<ActionResult<bool>> AddProductAsync([FromBody] ProductDto productDto)
        {
            return await repositroy.AddProduct(productDto);
        }
        [HttpPost, Route("add/CompetitiveProduct")]
        public async Task<ActionResult<bool>> AddCompetitiveProductAsync([FromBody] CompetitiveProductDto competitiveProductDto)
        {
            return await repositroy.AddCompetitiveProduct(competitiveProductDto);
        }




        [HttpGet,Route("get/ProductAll")]
        public async Task<IEnumerable<ProductDto>> GetAllProductAsync()
        {
            return await repositroy.GetAllProduct();
        }
        [HttpGet, Route("get/CompetitiveProductAll")]
        public async Task<IEnumerable<CompetitiveProductDto>> GetAllCompetitiveProductsAsync()
        {
            return await repositroy.GetAllCompetitiveProduct();
        }
        [HttpGet, Route("get/GetProductByCId")]
        public async Task<IEnumerable<ProductDto>> GetAllCompetitiveProductsAsync(int comId)
        {
            return ( await repositroy.GetProductByCompetitiveProduct(comId)).ConvertToDto();
        }
        [HttpGet, Route("get/GetProductByCName")]
        public async Task<IEnumerable<ProductDto>> GetAllCompetitiveProductsAsync(string comName)
        {
            return (await repositroy.GetProductByCompetitiveProduct(comName)).ConvertToDto();
        }


        [HttpDelete, Route("delete/CompetitiveProduct")]
        public async Task<ActionResult<bool>> DeleteCompetitiveProductAysnc(int comId)
        {
            return  await repositroy.DeleteCompetitiveProduct(comId);
        }

        [HttpDelete, Route("delete/Product")]
        public async Task<ActionResult<bool>> DeleteProductAysnc(int pId)
        {
            return await repositroy.DeleteProduct(pId);
        }



        [HttpPatch,Route("patch/Product")]
        public async Task<ActionResult<bool>> PatchProductAysnc(ProductDto productDto)
        {
            return await repositroy.UpdateProduct(productDto);
        }

        [HttpPatch, Route("patch/CompetitiveProduct")]
        public async Task<ActionResult<bool>> PatchCompetitiveProductAysnc(CompetitiveProductDto competitiveProductDto)
        {
            return await repositroy.UpdateCompetitiveProduct(competitiveProductDto);
        }
    }


    
}
