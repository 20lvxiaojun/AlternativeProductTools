using AlternativeTool.Web.Shared.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AlternativeTool.Web.Client.Services.Contacts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllProducts();
        Task<IEnumerable<ProductDto>> GetProductByCompetitiveName(string CName);
    }
}
