using MediatR;
using Restaurant.Inventory.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Application.UseCases.Reunion.Command.CrearReunion
{
    public class CrearReunionCommand : IRequest<Guid>
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Guid Creador { get; set; }
        public Guid Lugar { get; set; }

        public CrearReunionCommand(string nombre, string descripcion, Guid creador, Guid lugar)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            Creador = creador;
            Lugar = lugar;
        }
    }
}

