using Restaurant.Inventory.Domain.Events;
using Restaurant.Inventory.Domain.Model.Reunion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Factories
{
    public interface IReunionFactory
    {
        Reunion CreateReunion(string nombre, string descripcion, Guid creador, Guid lugar);


    }
}
