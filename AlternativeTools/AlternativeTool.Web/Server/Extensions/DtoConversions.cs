using AlternativeTool.Web.Server.Entities;
using AlternativeTool.Web.Shared.Dtos;
using System.Collections.Generic;
using System.Linq;

namespace AlternativeTool.Web.Server.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<ProductDto> ConvertToDto(this IEnumerable<Product> products)
        {
            var productDtotList = new List<ProductDto>();
            foreach (var product in products)
            {
                productDtotList.Add(new ProductDto
                {
                    Id=product.Id,
                    Name = product.Name,
                    Category = product.Category,
                    Describe = product.Describe,
                    CometitiveProductNames= product.CompetitiveProducts.Select(c=>c.Name).ToList()
                });
            }
            return productDtotList;
        }
        public static ProductDto ConvertToDto(this Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category,
                Describe = product.Describe,
                CometitiveProductNames = product.CompetitiveProducts.Select(c => c.Name).ToList()
            };
        }
        public static IEnumerable<CompetitiveProductDto> ConvertToDto(this IEnumerable<CompetitiveProduct> competitives)
        {
            var CompetiyiveProductDtotList = new List<CompetitiveProductDto>();
            foreach (var competitive in competitives)
            {
                CompetiyiveProductDtotList.Add(new CompetitiveProductDto
                {
                    Id=competitive.Id,
                    Name = competitive.Name,
                    Category = competitive.Category,
                    ProductNames = competitive.Products.Select(c => c.Name).ToList()
                });
            }
            return CompetiyiveProductDtotList;
        }
        public static CompetitiveProductDto ConvertToDto(this CompetitiveProduct competitive)
        {
            return new CompetitiveProductDto
            {
                Id = competitive.Id,
                Name = competitive.Name,
                Category = competitive.Category,
                ProductNames = competitive.Products.Select(c => c.Name).ToList()
            };
        }
    }
}
