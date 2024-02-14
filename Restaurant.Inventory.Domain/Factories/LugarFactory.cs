using Restaurant.Inventory.Domain.Model.Lugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Factories
{
    public class LugarFactory : ILugarFactory
    {
        public Lugar CrearLugar(string nombre, string description, string url)
        {
            return new Lugar(nombre, description, url);
        }
    }
}
