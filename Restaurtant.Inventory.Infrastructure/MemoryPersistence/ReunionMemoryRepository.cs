using Restaurant.Inventory.Domain.Model.Reunion;
using Restaurant.Inventory.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurtant.Inventory.Infrastructure.MemoryPersistence
{
    internal class ReunionMemoryRepository : IReunionRepository
    {
        private readonly MemoryDatabase memoryDatabase;

        public ReunionMemoryRepository(MemoryDatabase memoryDatabase)
        {
            this.memoryDatabase = memoryDatabase;
        }

        public Task CreateAsync(Reunion obj)
        {
            memoryDatabase.Reuniones.Add(obj);

            return Task.CompletedTask;
        }

        async Task IReunionRepository.CreateInvitacion(Guid reunion, Guid usuario)
        {
            
            Reunion reunionObj = await Task.Run(() => memoryDatabase.Reuniones.FirstOrDefault(r => r.Id == reunion));
            if (reunionObj == null)
            {
                return;
            }
            reunionObj.InvitarUsuario(usuario);
            
        }

        public async Task<Reunion?> FindByIdAsync(Guid id)
        {
            return await Task.Run(() => memoryDatabase.Reuniones.FirstOrDefault(r => r.Id == id));
        }

        
        public async Task UpdateAsync(Reunion item)
        {
            await Task.Run(() =>
            {
                Reunion reunionExistente = memoryDatabase.Reuniones.FirstOrDefault(r => r.Id == item.Id);
                if (reunionExistente != null)
                {
                    // Actualizar las propiedades de la reunión existente con las del nuevo objeto 'item'
                    
                    // Actualiza otras propiedades según sea necesario

                    // Puedes realizar otras operaciones de actualización si es necesario

                    // No necesitas hacer nada más ya que los cambios se reflejan en la lista _reuniones
                }
                else
                {
                    throw new ArgumentException($"La reunión con el ID {item.Id} no existe.");
                }
            });
        }
    }
}
