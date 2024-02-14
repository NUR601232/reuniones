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

namespace Restaurant.Inventory.Application.UseCases.Reunion.Command.ResponderInvitacion
{
    public class ResponderInvitacionHandler : IRequestHandler<ResponderInvitacionCommand, InvitacionConfirmada>
    {
        private readonly IReunionRepository _reunionRepository;
        private readonly IUnitOfWork _unitOfWork;

        public ResponderInvitacionHandler(IReunionRepository reunionRepository,
            IUnitOfWork unitOfWork)
        {
            _reunionRepository = reunionRepository;
            _unitOfWork = unitOfWork;
        }

        /*public async Task<Guid> Handle(ResponderInvitacionCommand request, CancellationToken cancellationToken)
        {
            var reunion = await _reunionRepository.FindByIdAsync(request.Reunion);
            if (request.Confirmar)
            {
                reunion.Confirmar(request.Invitacion);
            }
            else
                reunion.Anular(request.Invitacion);


            await _reunionRepository.UpdateAsync(reunion);

            await _unitOfWork.Commit();

            return request.Reunion;

        }*/

        public async Task<InvitacionConfirmada> Handle(ResponderInvitacionCommand request, CancellationToken cancellationToken)
        {
            var reunion = await _reunionRepository.FindByIdAsync(request.Reunion);
            var confirmar = reunion.ConfirmarUsuario(request.Invitacion, request.Confirmar);


            await _reunionRepository.UpdateAsync(reunion);

            await _unitOfWork.Commit();

            return confirmar;
        }
    }
}
