using Restaurant.Inventory.Domain.ValueObjects;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Model.Usuario
{
    public class Usuario : AggregateRoot
    {
        public string Nombre { get; private set; }
        public string Correo { get; private set; }
        public string Contrasenha { get; private set; }

        internal Usuario(string nombre, string correo, string contrasenha )
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Correo = correo;
            Contrasenha = contrasenha;
        }

        public Usuario(string id, string nombre, string correo, string contrasenha)
        {
            Id = Guid.Parse(id);
            Nombre = nombre;
            Correo = correo;
            Contrasenha = contrasenha;
        }

        public void Edit(string nombre)
        {
            Nombre = nombre;
        }

        

    }
}