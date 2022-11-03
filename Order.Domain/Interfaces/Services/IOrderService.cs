using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IOrderService
    {
        Task CreateAsync(OrderModel order);
        Task UpdadeAsync(OrderModel order);
        Task DeleteAsync(string idOrder);
        Task<OrderModel> GetByIdAsync(string idOrder);
        Task<List<OrderModel>> ListByFilterIdAsync(string idOrder = null, string idClient = null, string idUser = null);
    }
}