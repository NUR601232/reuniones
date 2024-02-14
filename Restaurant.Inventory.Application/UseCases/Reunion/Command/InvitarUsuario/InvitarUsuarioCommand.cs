using MediatR;
using Restaurant.Inventory.Domain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Application.UseCases.Reunion.Command.InvitarUsuario
{
    public class InvitarUsuarioCommand : IRequest<InvitacionCreada>
    {
        public Guid Reunion { get; set; }
        public Guid Usuario { get; set; }

    }
}

