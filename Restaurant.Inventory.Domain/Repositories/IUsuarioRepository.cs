using Restaurant.Inventory.Domain.Model.Usuario;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Repositories
{
    public interface IUsuarioRepository : IRepository<Usuario, Guid>
    {
        Task UpdateAsync(Usuario item);

    }
}
