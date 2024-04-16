using AutoMapper;
using Novedades.DAL.SqlServer.Entities;
using Novedades.Models;

namespace Novedades.DAL.SqlServer.Mappers
{
    public static class MapUtilSQL
    {
        public static NovedadEntidad Map(this NovedadModel nvnModel)
        {
            return new()
            {
                IdNvn = nvnModel.IdNvn,
                IdEmpleado = nvnModel.IdEmpleado,
                IdCompania = nvnModel.IdCompania,
                IdConcepto = nvnModel.IdConcepto,
                IdEmpresa = nvnModel.IdEmpresa,
                FechaInicial = nvnModel.FechaInicial,
                FechaFinal = nvnModel.FechaFinal,
                Horas = nvnModel.Horas,
                Valor = nvnModel.Valor,
                Observacion = nvnModel.Observacion
            };
        }

        public static NovedadModel Map(this NovedadEntidad nvnEntidad)
        {
            return new()
            {
                IdNvn = nvnEntidad.IdNvn,
                IdEmpleado = nvnEntidad.IdEmpleado,
                IdCompania = nvnEntidad.IdCompania,
                IdConcepto = nvnEntidad.IdConcepto,
                IdEmpresa = nvnEntidad.IdEmpresa,
                FechaInicial = nvnEntidad.FechaInicial,
                FechaFinal = nvnEntidad.FechaFinal,
                Horas = nvnEntidad.Horas,
                Valor = nvnEntidad.Valor,
                Observacion = nvnEntidad.Observacion
            };
        }
    }
}
