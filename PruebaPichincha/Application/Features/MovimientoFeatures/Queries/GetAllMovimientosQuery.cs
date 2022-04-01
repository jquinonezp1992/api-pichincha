using Application.Interfaces;
using Domain.Entity;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.MovimientoFeatures.Queries
{
    public class GetAllMovimientosQuery : IRequest<IEnumerable<Movimiento>>
    {
        public class GetAllMovimientosQueryHandler : IRequestHandler<GetAllMovimientosQuery, IEnumerable<Movimiento>>
        {
            private readonly IMovimientoRepository _movimientoRepository;
            public GetAllMovimientosQueryHandler(IMovimientoRepository movimientoRepository)
            {
                _movimientoRepository = movimientoRepository;
            }

            public async Task<IEnumerable<Movimiento>> Handle(GetAllMovimientosQuery query, CancellationToken cancellationToken)
            {
                var movimientos = _movimientoRepository.GetAll();
                if (movimientos == null)
                {
                    return null;
                }
                return movimientos;
            }
        }
    }
}
