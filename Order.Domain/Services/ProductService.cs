using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
    public class ProductService : IProductService
    {
        public Task CreateAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string idProduct)
        {
            throw new NotImplementedException();
        }

        public Task<ProductModel> GetByIdAsync(string idProduct)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductModel>> ListByFilterAsync(string idProduct = null, string description = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdadeAsync(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}