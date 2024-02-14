using Restaurant.Inventory.Domain.Model.Lugar;
using Restaurant.Inventory.Domain.Model.Reunion;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Repositories
{
    public interface IReunionRepository : IRepository<Reunion, Guid>
    {
        Task UpdateAsync(Reunion item);

        Task CreateInvitacion(Guid reunion, Guid usuario);


    }
}
