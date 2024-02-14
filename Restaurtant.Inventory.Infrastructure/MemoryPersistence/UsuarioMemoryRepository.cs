using Restaurant.Inventory.Domain.Model.Reunion;
using Restaurant.Inventory.Domain.Model.Usuario;
using Restaurant.Inventory.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurtant.Inventory.Infrastructure.MemoryPersistence
{
    internal class UsuarioMemoryRepository : IUsuarioRepository
    {
        private readonly MemoryDatabase memoryDatabase;


        public UsuarioMemoryRepository(MemoryDatabase memoryDatabase)
        {
            this.memoryDatabase = memoryDatabase;
        }

        public Task CreateAsync(Usuario obj)
        {
            memoryDatabase.Usuarios.Add(obj);

            return Task.CompletedTask;
        }

        public async Task<Usuario?> FindByIdAsync(Guid id)
        {
            return await Task.Run(() => memoryDatabase.Usuarios.FirstOrDefault(r => r.Id == id));
        }

        public Task UpdateAsync(Usuario item)
        {
            throw new NotImplementedException();
        }
    }
}
