using MediatR;
using Restaurant.Inventory.Domain.Model.Reunion;
using Restaurant.Inventory.Domain.Model.Usuario;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Events
{
    public record InvitacionCreada : DomainEvent, INotification
    {
        public Guid InvitacionId { get; init; }
        public Reunion ReunionId { get; init; }
        public Guid Usuarios { get; init; }

        public InvitacionCreada(Guid invitacionId, Reunion reunionId,
            Guid usuario) : base(DateTime.Now)
        {
            InvitacionId = invitacionId;
            ReunionId = reunionId;
            Usuarios = usuario;
        }

        public record DetalleUsuarioConfirmada(Guid UsuarioId, string nombre, string correo, string contrasenha);

    }
}
