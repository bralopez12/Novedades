using AutoMapper;
using Novedades.DAL.SqlServer.Entities;
using Novedades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novedades.DAL.SqlServer.Mappers
{
    public class ProfileSQL : Profile
    {
        public ProfileSQL()
        {
            CreateMap<NovedadEntidad, NovedadModel>().ReverseMap();
        }


    }
}
