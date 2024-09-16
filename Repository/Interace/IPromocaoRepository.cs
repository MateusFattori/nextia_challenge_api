using nextia_challenge_api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace nextia_challenge_api.Repositories.Interfaces
{
    public interface IPromocaoRepository
    {
        Task<IEnumerable<Promocao>> GetAllAsync();
        Task<Promocao> GetByIdAsync(int id);
        Task AddAsync(Promocao promocao);
        Task UpdateAsync(Promocao promocao);
        Task DeleteAsync(int id);
    }
}
