using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task CreateAsync(ProductModel product);
        Task UpdadeAsync(ProductModel product);
        Task DeleteAsync(string idProduct);
        Task<ProductModel> GetByIdAsync(string idProduct);
        Task<List<ProductModel>> ListByFilterAsync(string idProduct = null, string description = null);
        Task<bool> ExistsByIdyAsync(string idProduct);
    }
}