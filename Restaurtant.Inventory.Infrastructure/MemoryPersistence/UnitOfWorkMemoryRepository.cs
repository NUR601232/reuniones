using Restaurant.Inventory.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurtant.Inventory.Infrastructure.MemoryPersistence
{
    internal class UnitOfWorkMemoryRepository : IUnitOfWork
    {
        public Task Commit()
        {
            return Task.CompletedTask;
        }
    }
}
