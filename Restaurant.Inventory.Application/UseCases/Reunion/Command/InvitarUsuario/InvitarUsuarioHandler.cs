using MediatR;
using Restaurant.Inventory.Application.UseCases.Reunion.Command.CrearReunion;
using Restaurant.Inventory.Domain.Events;
using Restaurant.Inventory.Domain.Factories;
using Restaurant.Inventory.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Inventory.Application.UseCases.Reunion.Command.InvitarUsuario
{
    public class InvitarUsuarioHandler : IRequestHandler<InvitarUsuarioCommand, InvitacionCreada>
    {
        private readonly IReunionRepository _reunionRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly IUnitOfWork _unitOfWork;

        public InvitarUsuarioHandler(IReunionRepository reunionRepository, IUsuarioRepository usuarioRepository,
        IUnitOfWork unitOfWork)
        {
            _usuarioRepository = usuarioRepository;
            _reunionRepository = reunionRepository;
            _unitOfWork = unitOfWork;
        }

        /*public async Task<Guid> Handle(InvitarUsuarioCommand request, CancellationToken cancellationToken)
        {
            var reunion = await _reunionRepository.FindByIdAsync(request.Reunion);

            var invitacion= reunion.InvitarUsuario(request.Usuario);

            await _reunionRepository.UpdateAsync(reunion);

            await _unitOfWork.Commit();

            return invitacion.InvitacionId;
        }*/

        async Task<InvitacionCreada> IRequestHandler<InvitarUsuarioCommand, InvitacionCreada>.Handle(InvitarUsuarioCommand request, CancellationToken cancellationToken)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));
            var usuario = await _usuarioRepository.FindByIdAsync(request.Usuario);
            if (usuario == null)
                throw new ArgumentNullException(nameof(request));

            var reunion = await _reunionRepository.FindByIdAsync(request.Reunion);

            var invitacion = reunion.InvitarUsuario(request.Usuario);

            await _reunionRepository.UpdateAsync(reunion);

            await _unitOfWork.Commit();

            return invitacion;
        }
    }
}
