using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Repositories
{
    public interface IUnitOfWork
    {
        Task Commit();
    }
}
