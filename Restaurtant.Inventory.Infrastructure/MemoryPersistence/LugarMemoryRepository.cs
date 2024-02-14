using Restaurant.Inventory.Domain.Model.Lugar;
using Restaurant.Inventory.Domain.Model.Reunion;
using Restaurant.Inventory.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurtant.Inventory.Infrastructure.MemoryPersistence
{
    internal class LugarMemoryRepository : ILugarRepository
    {
        private readonly MemoryDatabase memoryDatabase;

        public LugarMemoryRepository(MemoryDatabase memoryDatabase)
        {
            this.memoryDatabase = memoryDatabase;
        }

        public Task CreateAsync(Lugar obj)
        {
            memoryDatabase.Lugares.Add(obj);

            return Task.CompletedTask;
        }

        public Task DeleteAsync(Lugar item)
        {
            throw new NotImplementedException();
        }

        public async Task<Lugar?> FindByIdAsync(Guid id)
        {
            return await Task.Run(() => memoryDatabase.Lugares.FirstOrDefault(r => r.Id == id));
        }

        public Task<IEnumerable<Lugar>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Lugar item)
        {
            throw new NotImplementedException();
        }
    }
}
