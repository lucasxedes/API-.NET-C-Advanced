using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
    public class OrderService : IOrderService
    {
        public Task CreateAsync(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string idOrder)
        {
            throw new NotImplementedException();
        }

        public Task<OrderModel> GetByIdAsync(string idOrder)
        {
            throw new NotImplementedException();
        }

        public Task<List<OrderModel>> ListByFilterIdAsync(string idOrder = null, string idClient = null, string idUser = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdadeAsync(OrderModel order)
        {
            throw new NotImplementedException();
        }
    }
}