using MediatR;
using Restaurant.Inventory.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Application.UseCases.Reunion.Command.ResponderInvitacion
{
    public class ResponderInvitacionCommand : IRequest<InvitacionConfirmada>
    {
        public Guid Reunion { get; set; }
        public Guid Invitacion { get; set; }
        public bool Confirmar { get; set; }

    }
}


