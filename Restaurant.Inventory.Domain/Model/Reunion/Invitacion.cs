
using Restaurant.Inventory.Domain.ValueObjects;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Domain.Model.Reunion
{
    internal class Invitacion : Entity
    {
        public Guid ReuionId { get; private set; }
        public Guid UsuarioId { get; private set; }
        public bool Asiste { get; private set; }

        public Invitacion(Guid itemId, Guid usuarioId)
        {
            Id = Guid.NewGuid();
            ReuionId = itemId;
            UsuarioId = usuarioId;
            Asiste = true;
        }

        public void Aceptar()
        {
            Asiste = true;
        }

        public void Rechazar()
        {
            Asiste = false;
        }
        public void Confirmar(bool asiste)
        {
            Asiste = asiste;
        }

    }
}
