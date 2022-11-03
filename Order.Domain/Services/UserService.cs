using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Interfaces.Services;
using Order.Domain.Models;

namespace Order.Domain.Services
{
    public class UserService : IUserService
    {
        public Task<bool> AutheticationAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task CreateAsync(UserModel user)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(string idUser)
        {
            throw new NotImplementedException();
        }

        public Task<UserModel> GetByIdAsync(string idUser)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserModel>> ListByFilterAsync(string idUser = null, string name = null)
        {
            throw new NotImplementedException();
        }

        public Task UpdadeAsync(UserModel user)
        {
            throw new NotImplementedException();
        }
    }
}