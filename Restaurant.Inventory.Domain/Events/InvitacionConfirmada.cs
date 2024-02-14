using MediatR;
using Restaurant.Inventory.Domain.Model.Reunion;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Events
{
    public record InvitacionConfirmada : DomainEvent, INotification
    {

       // public Invitacion InvitacionId { get; set; }

        public Reunion ReunionId { get; init; }
        public Guid InvitacionId { get; init; }
        public Guid Usuario { get; init; }

        public bool Asiste {  get; init; }


        public InvitacionConfirmada(Reunion reunionId, Guid invitacionId, Guid usuario, bool asiste) : base(DateTime.Now)
        {
            ReunionId = reunionId;
            InvitacionId = invitacionId;
            Usuario = usuario;
            Asiste = asiste;
        }
        

        public record DetalleUsuarioConfirmada(Guid UsuarioId, string nombre, string correo, string contrasenha);

    }
}
