using Application.ColaboradorCQ.Dtos;
using Application.Response;
using Domain.Abstractions.Colaborador;
using Infra.Persistence;
using MediatR;

namespace Application.ColaboradorCQ.Handlers
{
    public class CreateColaboradorCommandHandler(
        EscolaDbContext context, IColaboradorService colaboradorService
        ) : IRequestHandler<ColaboradorCreateDTO, Response<ColaboradorResponseDTO>>
    {
        // injeções de dependencia
        private readonly EscolaDbContext _context = context;
        private readonly IColaboradorService _colaboradorService = colaboradorService;

        public async Task<Response<ColaboradorResponseDTO>> Handle(
            ColaboradorCreateDTO request, CancellationToken cancellationToken)
        {
            // formatação de resposta
            var resposta = new Response<ColaboradorResponseDTO>();

            

            
            resposta.Status = true;
            resposta.Mensagem = "resposta default";
            
            return resposta;
        }
    }
}
