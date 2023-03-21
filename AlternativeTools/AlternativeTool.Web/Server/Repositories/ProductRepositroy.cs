using AlternativeTool.Web.Server.Contexts;
using AlternativeTool.Web.Server.Entities;
using AlternativeTool.Web.Server.Extensions;
using AlternativeTool.Web.Server.Repositories.Contracts;
using AlternativeTool.Web.Shared.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlternativeTool.Web.Server.Repositories
{
    public class ProductRepositroy : IProductRepositroy
    {
        private readonly DBProductContext context;

        public ProductRepositroy(DBProductContext context)
        {
            this.context = context;
        }

        public async Task<bool> AddCompetitiveProduct(CompetitiveProductDto competitiveProductDto)
        {
            var res = await context.CompetitiveProducts.FirstOrDefaultAsync(n => n.Name == competitiveProductDto.Name);
            if (res != null)
            {
                return false;
            }
            else
            {
                var newCProduct = new CompetitiveProduct
                {
                    Name = competitiveProductDto.Name,
                    Category = competitiveProductDto.Category
                };
                //获取数据库中产品的名字的匿名集合
                var DBProductNames = await context.Products.Select(c => new { c.Name }).ToListAsync();
                //将匿名集合转化为字符串List，方便后面对比不同的产品名字
                List<string> ProductList = new List<string>();
                foreach (var competitive in DBProductNames)
                {
                    ProductList.Add(competitive.Name);
                }
                //新建需要添加的产品的列表
                var addProducts = new List<Product>();
                //如果数据库中产品为空，则说明所有Dto中产品的名字都需要创建对象
                if (DBProductNames == null)
                {
                    for (int i = 0; i < competitiveProductDto.ProductNames.Count; i++)
                    {
                        addProducts.Add(new Product { Name = competitiveProductDto.ProductNames[i],Category = competitiveProductDto.Category });
                    }
                }
                else
                {
                    //数据库中产品的名字不为空，则需要创建一下数据库中没有的产品,即数据库没有，传进来有的，要添加
                    var DIfferList = competitiveProductDto.ProductNames.Except(ProductList);

                    //创建数据库没有的产品类,并且添加进 待加入CProduct的列表addProduct 中
                    foreach (var item in DIfferList)
                    {
                        addProducts.Add(new Product { Name = item, Category = competitiveProductDto.Category });
                    }
                }
                //处理竞品和产品之间的关系 ----竞品关联产品
                foreach (var item in addProducts)
                {
                    item.CompetitiveProducts.Add(newCProduct);
                }


                //将需要关联好的竞品add进产品
                foreach (var item in addProducts)
                {
                    newCProduct.Products.Add(item);
                }
                //将产品存入
                await context.CompetitiveProducts.AddAsync(newCProduct);
                //关联数据库
                if (await context.SaveChangesAsync() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> AddProduct(ProductDto productDto)
        {
            var res = await context.Products.FirstOrDefaultAsync(n => n.Name == productDto.Name);
            if (res != null)
            {
                return false;
            }
            else
            {
                var newProduct = new Product
                {
                    Name = productDto.Name,
                    Category = productDto.Category,
                    Describe = productDto.Describe
                };
                //获取数据库中竞品的名字的匿名集合
                var DBcompetitiveNames = await context.CompetitiveProducts.Select(c=>new { c.Name}).ToListAsync();
                //将匿名集合转化为字符串List，方便后面对比不同的竞品名字
                List<string> CProductList = new List<string>();
                foreach (var competitive in DBcompetitiveNames)
                {
                    CProductList.Add(competitive.Name);
                }
                //新建需要添加的竞品的列表
                var addCompetitivesProduct = new List<CompetitiveProduct>();
                //如果数据库中竞品为空，则说明所有Dto中竞品的名字都需要创建对象
                if (DBcompetitiveNames == null)
                {
                    for (int i = 0; i < productDto.CometitiveProductNames.Count; i++)
                    {
                        addCompetitivesProduct.Add(new CompetitiveProduct { Name = productDto.CometitiveProductNames[i], Products = new List<Product>() , Category = productDto.Category }) ;
                    }
                }
                else
                {
                    //数据库中竞品的名字不为空，则需要创建一下数据库中没有的竞品,即数据库没有，传进来有的，要添加
                    var DIfferList = productDto.CometitiveProductNames.Except(CProductList);

                    //创建数据库没有的竞品类,并且添加进 待加入Product的列表addCompetitivesProduct 中
                    foreach (var item in DIfferList)
                    {
                        addCompetitivesProduct.Add(new CompetitiveProduct { Name = item, Products = new List<Product>() ,Category=productDto.Category});
                    }
                }
                //处理竞品和产品之间的关系 ----竞品关联产品
                foreach (var item in addCompetitivesProduct)
                {
                    item.Products.Add(newProduct);
                }


                //将需要关联好的竞品add进产品
                foreach (var item in addCompetitivesProduct)
                {
                    newProduct.CompetitiveProducts.Add(item);
                }
                //将产品存入
                await context.Products.AddAsync(newProduct);
                //关联数据库
                if (await context.SaveChangesAsync()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public async Task<bool> DeleteCompetitiveProduct(int CompetitiveProductId)
        {
            var deleModel=await context.CompetitiveProducts.FirstOrDefaultAsync(x => x.Id == CompetitiveProductId);
            context.CompetitiveProducts.Remove(deleModel);
            if (await context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> DeleteProduct(int ProductId)
        {
            var deleModel = await context.Products.FirstOrDefaultAsync(x => x.Id == ProductId);
            context.Products.Remove(deleModel);
            if (await context.SaveChangesAsync() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<IEnumerable<Product>> GetProductByCompetitiveProduct(int CompetitiveProductId)
        {
            return  await context.Products.Where(c=>c.Id==CompetitiveProductId).ToListAsync();
        }

        public async Task<IEnumerable<Product>> GetProductByCompetitiveProduct(string CompetitiveProductName)
        {
            return await context.Products.Where(c => c.Name == CompetitiveProductName).ToListAsync();
        }

        public async Task<bool> UpdateCompetitiveProduct(CompetitiveProductDto competitiveProduct)
        {
            var updateModel = await context.CompetitiveProducts.FirstOrDefaultAsync(x => x.Id == competitiveProduct.Id);
            if (updateModel != null)
            {
                updateModel.Name = competitiveProduct.Name;
                updateModel.Category = competitiveProduct.Category;
                if (await context.SaveChangesAsync() > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> UpdateProduct(ProductDto product)
        {
            var updateModel = await context.Products.FirstOrDefaultAsync(x => x.Id == product.Id);
            if (updateModel!=null)
            {
                updateModel.Name = product.Name;
                updateModel.Describe = product.Describe;
                updateModel.Category = product.Category;
                if (await context.SaveChangesAsync()>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
            else
            {
                return false;
            }
        }



        
        public async Task<IEnumerable<ProductDto>> GetAllProduct()
        {
            var products= await context.Products.Include(x=>x.CompetitiveProducts).ToListAsync();
            return products.ConvertToDto();
        }

        public async Task<IEnumerable<CompetitiveProductDto>> GetAllCompetitiveProduct()
        {
            var comeyitiveProducts = await context.CompetitiveProducts.Include(x => x.Products).ToListAsync();
            return comeyitiveProducts.ConvertToDto();
        }
    }
}
