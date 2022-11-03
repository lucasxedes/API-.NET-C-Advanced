using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task CreateAsync(ProductModel product);
        Task UpdadeAsync(ProductModel product);
        Task DeleteAsync(string idProduct);
        Task<ProductModel> GetByIdAsync(string idProduct);
        Task<List<ProductModel>> ListByFilterAsync(string idProduct = null, string description = null);
    }
}