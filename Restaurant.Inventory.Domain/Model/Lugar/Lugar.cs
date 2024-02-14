using Restaurant.Inventory.Domain.Events;
using Restaurant.Inventory.Domain.Exceptions;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Model.Lugar
{
    public class Lugar : AggregateRoot
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public string Url { get; private set; }

        public bool Tipo { get; private set; }

        internal Lugar(string nombre, string correo, string contrasenha)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = correo;
            Url = contrasenha;
            Tipo = true;
        }

        public Lugar(string id, string nombre, string descripcion, string url)
        {
            Id = Guid.Parse(id);
            Nombre = nombre;
            Descripcion = descripcion;
            Url = url ;
            Tipo = true;
        }

    }
}
