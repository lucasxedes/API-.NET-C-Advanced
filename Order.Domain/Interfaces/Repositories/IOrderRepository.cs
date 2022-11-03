using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IOrderRepository
    {
        Task CreateAsync(OrderModel order);
        Task CreateItemAsync(OrderItemModel item);
        Task UpdadeAsync(OrderModel order);
        Task UpdadeItemAsync(OrderItemModel item);
        Task DeleteAsync(string idOrder);
        Task DeleteItemAsync(string idItem);
        Task<OrderModel> GetByIdAsync(string idOrder);
        Task<List<OrderModel>> ListByFilterAsync(string idOrder = null, string idClient = null, string idUser = null);
        Task<List<OrderModel>> ListItemByOrderIdAsync(string idOrder);
        Task<bool> ExistsByIdyAsync(string idOrder);
    }
}