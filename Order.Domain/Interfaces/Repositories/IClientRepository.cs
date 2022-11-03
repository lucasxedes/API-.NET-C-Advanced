using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task CreateAsync(ClientModel client);
        Task UpdadeAsync(ClientModel client);
        Task DeleteAsync(string idClient);
        Task<bool> ExistsByIdyAsync(string idClient);
        Task<ClientModel> GetByIdAsync(string idClient);
        Task<List<ClientModel>> ListByFilterAsync(string idClient = null, string name = null);

    }
}