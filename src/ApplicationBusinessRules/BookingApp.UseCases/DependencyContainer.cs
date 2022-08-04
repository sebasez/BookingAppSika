using AutoMapper;
using BookingApp.UseCases.CrearReserva;
using BookingApp.UseCases.Mappings;
using BookingApp.UseCasesPorts.ReservaPorts;
using Microsoft.Extensions.DependencyInjection;

namespace BookingApp.UseCases
{
    public static class DependencyContainer
    {
        
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            // Auto Mapper Configuracion
            var mapperConfig = new MapperConfiguration(mapperConfig =>
            {
                mapperConfig.AddProfile(new AutoMapping());
            });
            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddTransient<ICrearReservaInputPort, CrearReservaInteractor>();
            return services;
        }
    }
}
