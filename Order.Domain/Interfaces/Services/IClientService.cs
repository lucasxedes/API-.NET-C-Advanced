using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Models;
using Order.Domain.Validations.Base;

namespace Order.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task<Response> CreateAsync(ClientModel client);
        Task<Response> UpdadeAsync(ClientModel client);

        Task<Response> DeleteAsync(string idClient);

        Task<Response<ClientModel>> GetByIdAsync(string idClient);
        Task<Response<List<ClientModel>>> ListByFilterIdAsync(string idClient = null, string name = null);
    }
}