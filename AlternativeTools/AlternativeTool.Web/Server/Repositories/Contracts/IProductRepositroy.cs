using AlternativeTool.Web.Server.Entities;
using AlternativeTool.Web.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlternativeTool.Web.Server.Repositories.Contracts
{
    public interface IProductRepositroy
    {
        public Task<bool> AddProduct(ProductDto product);
        public Task<bool> AddCompetitiveProduct(CompetitiveProductDto competitiveProduct);
        public Task<bool> UpdateProduct(ProductDto product);
        public Task<bool> UpdateCompetitiveProduct(CompetitiveProductDto competitiveProduct);
        public Task<bool> DeleteProduct(int ProductId);
        public Task<bool> DeleteCompetitiveProduct(int CompetitiveProductId);
        public Task<IEnumerable<Product>> GetProductByCompetitiveProduct(int CompetitiveProductId);
        public Task<IEnumerable<Product>> GetProductByCompetitiveProduct(string CompetitiveProductName);


        public Task<IEnumerable<ProductDto>> GetAllProduct();
        public Task<IEnumerable<CompetitiveProductDto>> GetAllCompetitiveProduct();
    }
}
