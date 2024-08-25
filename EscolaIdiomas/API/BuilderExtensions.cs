using Application.ColaboradorCQ.Handlers;
using Domain.Abstractions.Colaborador;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using Services.Colaborador;

namespace API
{
    public static class BuilderExtensions
    {
        public static void AddServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            /* Config Mediator referênciando 1 (CreateColaboradorCommandHandler) 
               ja referência todos os outros que estiverem no mesmo assembly*/
            builder.Services.AddMediatR(config => config.RegisterServicesFromAssemblies(
                    typeof(CreateColaboradorCommandHandler).Assembly));
        }

        // metodo para uso do contexto do database
        public static void AddDatabase(this WebApplicationBuilder builder)
        {
            // Config Banco de dados
            var configurationDb = builder.Configuration;
            builder.Services.AddDbContext<EscolaDbContext>(options => options.UseSqlServer(configurationDb.GetConnectionString("DefaultConnection")));
        }


        // metodo das injeções de dependencias
        public static void AddInjections(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IColaboradorService, ColaboradorService>();
        }
    }
}
