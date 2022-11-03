using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Models;

namespace Order.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<bool> AutheticationAsync(UserModel user);
        Task CreateAsync(UserModel user);
        Task UpdadeAsync(UserModel user);
        Task DeleteAsync(string idUser);
        Task<UserModel> GetByIdAsync(string idUser);
        Task<List<UserModel>> ListByFilterAsync(string idUser = null, string name = null);

    }
}