using Microsoft.EntityFrameworkCore;
using nextia_challenge_api.Data;
using nextia_challenge_api.Models;
using nextia_challenge_api.Repositories.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace nextia_challenge_api.Repositories
{
    public class PromocaoRepository : IPromocaoRepository
    {
        private readonly DataContext _context;

        public PromocaoRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Promocao>> GetAllAsync()
        {
            return await _context.Promocoes.ToListAsync();
        }

        public async Task<Promocao> GetByIdAsync(int id)
        {
            return await _context.Promocoes.FindAsync(id);
        }

        public async Task AddAsync(Promocao promocao)
        {
            await _context.Promocoes.AddAsync(promocao);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Promocao promocao)
        {
            _context.Promocoes.Update(promocao);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var promocao = await _context.Promocoes.FindAsync(id);
            if (promocao != null)
            {
                _context.Promocoes.Remove(promocao);
                await _context.SaveChangesAsync();
            }
        }
    }
}
