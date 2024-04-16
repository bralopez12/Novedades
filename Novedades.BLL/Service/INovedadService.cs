using Novedades.DAL.SqlServer.Entities;
using Novedades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novedades.BLL.Service
{
    public interface INovedadService
    {
        Task<bool> InsertarNovedadValor(NovedadValor modelo);
        Task<bool> InsertarNovedadFecha(NovedadFechas modelo);
        Task<bool> InsertarNovedadHoras(NovedadHoras modelo);

        Task<bool> ActualizarNovedadValor(NovedadValor modelo);
        Task<bool> ActualizarNovedadFecha(NovedadFechas modelo);
        Task<bool> ActualizarNovedadHoras(NovedadHoras modelo);

        Task<bool> EliminarNovedadValor(int id);
        Task<bool> EliminarNovedadFecha(int id);
        Task<bool> EliminarNovedadHoras(int id);

        Task<NovedadValor> ObtenerNovedadValor(int id);
        Task<NovedadFechas> ObtenerNovedadFecha(int id);
        Task<NovedadHoras> ObtenerNovedadHoras(int id);

        Task<IEnumerable<NovedadValor>> ObtenerTodosNovedadValor();
        Task<IEnumerable<NovedadFechas>> ObtenerTodosNovedadFechas();
        Task<IEnumerable<NovedadHoras>> ObtenerTodosNovedadHoras();

    }
}
