using Restaurant.Inventory.Domain.Model.Lugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Factories
{
    public interface ILugarFactory
    {
        Lugar CrearLugar(string nombre, string description, string url);
    }
}
