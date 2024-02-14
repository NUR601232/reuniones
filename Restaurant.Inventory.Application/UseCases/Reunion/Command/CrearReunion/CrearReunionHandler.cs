using MediatR;
using System;
using Restaurant.Inventory.Domain.Factories;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant.Inventory.Domain.Repositories;
using Restaurant.Inventory.Domain.Model.Reunion;

namespace Restaurant.Inventory.Application.UseCases.Reunion.Command.CrearReunion
{
    public class CrearReunionHandler : IRequestHandler<CrearReunionCommand, Guid>
    {
        private readonly IReunionRepository _reunionRepository;
        private readonly IUsuarioRepository _usuarioRepository;
        private readonly ILugarRepository _lugarRepository;
        private readonly IReunionFactory _reunionFactory;
        private readonly IUnitOfWork _unitOfWork;

        public CrearReunionHandler(IReunionRepository reunionRepository, IUsuarioRepository usuarioRepository,
            ILugarRepository lugarRepository, IReunionFactory reunionFactory, IUnitOfWork unitOfWork)
        {
            _usuarioRepository = usuarioRepository;
            _lugarRepository = lugarRepository;
            _reunionRepository = reunionRepository;
            _reunionFactory = reunionFactory;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CrearReunionCommand request, CancellationToken cancellationToken)
        {
            var creador = await _usuarioRepository.FindByIdAsync(request.Creador);
            if (creador == null)
            {
                throw new ArgumentException();
            }

            var lugar = await _lugarRepository.FindByIdAsync(request.Lugar);
            if (lugar == null)
                throw new ArgumentException();
            var reunionCreado = _reunionFactory.CreateReunion(request.Nombre, request.Descripcion, request.Creador, request.Lugar);

            await _reunionRepository.CreateAsync(reunionCreado);


            await _unitOfWork.Commit();


            return reunionCreado.Id;
        }
     
    }
}
