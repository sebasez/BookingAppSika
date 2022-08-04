using AutoMapper;
using BookingApp.DTOs;
using BookingApp.Entities.POCOs;

namespace BookingApp.UseCases.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            //Reserva
            CreateMap<CrearReservaDTO, Reserva>().ReverseMap();
            CreateMap<ActualizarReservaDTO, Reserva>().ReverseMap();
            CreateMap<ObtenerReservaDTO, Reserva>().ReverseMap();
            CreateMap<ReservaDTO, Reserva>().ReverseMap();
            //Sala
            CreateMap<CrearSalaDTO, Sala>().ReverseMap();
            CreateMap<ObtenerSalaDTO, Sala>().ReverseMap();
            CreateMap<SalaDTO, Sala>().ReverseMap();
            //Recursos
            CreateMap<CrearRecursoDTO, Recurso>().ReverseMap();
            CreateMap<RecursoDTO, Recurso>().ReverseMap();


        }
    }
}
