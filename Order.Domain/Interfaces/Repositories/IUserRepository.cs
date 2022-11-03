using Order.Domain.Models;

namespace Order.Domain.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task CreateAsync(UserModel user);
        Task UpdadeAsync(UserModel user);
        Task DeleteAsync(string idUser);
        Task<UserModel> GetByIdAsync(string idUser);
        Task<List<UserModel>> ListByFilterAsync(string idUser = null, string name = null);

        Task<bool> ExistsByIdyAsync(string idUser);
        Task<bool> ExistsByLoginyAsync(string login);
        
    }
}