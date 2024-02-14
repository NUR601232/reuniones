using Restaurant.Inventory.Domain.Events;
using Restaurant.Inventory.Domain.Exceptions;
using Restaurant.Inventory.Domain.Model.Lugar;
using Restaurant.Inventory.Domain.Model.Usuario;
using Restaurant.SharedKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Restaurant.Inventory.Domain.Model.Reunion
{
    public class Reunion : AggregateRoot
    {
        public string Nombre { get; private set; }
        public string Descripcion { get; private set; }
        public Guid Creador { get; private set; }

        public Guid Lugar { get; private set; }

        private readonly List<Invitacion> _invitaciones;

        /*public IEnumerable<Invitacion> Invitaciones
        {
            get
            {
                return _invitaciones;
            }
        }*/

        internal Reunion(string nombre, string descripcion, Guid creador, Guid lugar)
        {
            Id = Guid.NewGuid();
            Nombre = nombre;
            Descripcion = descripcion;
            Creador = creador;
            Lugar = lugar;
            _invitaciones = new List<Invitacion>();
        }
        public InvitacionCreada InvitarUsuario(Guid usuarioId)
        {
            if (_invitaciones.Any(item => item.UsuarioId == usuarioId))
            {
                throw new ArgumentException("El usuario ya fue invitado");
            }
            Invitacion item = new Invitacion(Id, usuarioId);

            InvitacionCreada creada = new InvitacionCreada(item.Id, this, usuarioId);
            _invitaciones.Add(item);

            return creada;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }

        public bool Confirmar(Guid invitacionId)
        {
            foreach (var invitacion in _invitaciones)
            {
                if (invitacion.Id != invitacionId)
                {
                    invitacion.Aceptar();
                    return true;
                }
            }
            return false;
        }

        public bool Anular(Guid invitacionId)
        {
            foreach (var invitacion in _invitaciones)
            {
                if (invitacion.Id != invitacionId)
                {
                    invitacion.Rechazar();
                    return true;
                }
            }
            return false;
        }

        public InvitacionConfirmada ConfirmarUsuario(Guid invitacionId, bool asiste)
        {
            foreach (var invitacion in _invitaciones)
            {
                if (invitacion.Id == invitacionId)
                {
                    invitacion.Confirmar(asiste);
                    InvitacionConfirmada confirmado = new InvitacionConfirmada( this, invitacion.Id, invitacion.UsuarioId, invitacion.Asiste);
                    return confirmado;
                }
            }
            throw new NotImplementedException();
        }



    }
}
