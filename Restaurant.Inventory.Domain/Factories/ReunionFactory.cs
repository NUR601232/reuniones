using Restaurant.Inventory.Domain.Events;
using Restaurant.Inventory.Domain.Model.Reunion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Factories
{
    public class ReunionFactory : IReunionFactory
    {
        public Reunion CreateReunion(string nombre, string correo, Guid creador, Guid lugar)
        {
            var reunion= new Reunion(nombre, correo, creador, lugar);
            //var creado = new ReunionCreado(reunion.Id, reunion.Nombre, reunion.Descripcion, reunion.Creador, reunion.Lugar);
            return reunion;
        }

       

    }
}
