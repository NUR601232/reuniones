using MediatR;
using Restaurant.Inventory.Domain.Model.Lugar;
using Restaurant.Inventory.Domain.Model.Usuario;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Events
{
    public record ReunionCreado : DomainEvent, INotification
    {
        public Guid ReunionId { get; init; }
        public string Nombre { get; init; }
        public string Descripcion { get; init; }

        public Guid User { get; init; }

        public Guid Lugar { get; init; }

        public ReunionCreado(Guid lugarId, string nombre, string descripcion, Guid usuario, Guid lugar) : base(DateTime.Now)
        {
            ReunionId = lugarId;
            Nombre = nombre;
            Descripcion = descripcion;
            User = usuario;
            Lugar = lugar;
        }

    }
}
