using AutoMapper;
using Novedades.AppWeb.Models.ViewModels;
using Novedades.Models;

namespace Novedades.AppWeb.AutoMapper
{
    public class ProfileVM : Profile
    {
        public ProfileVM()
        {
            CreateMap <VMNovedadHoras,NovedadModel>().ReverseMap();
            CreateMap<VMNovedadFechas, NovedadModel>().ReverseMap();
            CreateMap<VMNovedadValor, NovedadModel>().ReverseMap();
        }
    }
}
