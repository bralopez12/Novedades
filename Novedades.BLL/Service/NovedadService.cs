//using Novedades.DAL.SqlServer.Adaptador;
//using Novedades.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Novedades.BLL.Service
//{
//    public class NovedadService : INovedadService
//    {
//        private readonly IGenericRepository<NovedadModel> _novedadRepo;
//        public NovedadService(IGenericRepository<NovedadModel> novedadRepo)
//        {
//            _novedadRepo = novedadRepo;
//        }
//        public async Task<bool> Actualizar(NovedadModel modelo)
//        {
//            return await _novedadRepo.Actualizar(modelo);
//        }

//        public async Task<bool> Eliminar(int id)
//        {
//            return await _novedadRepo.Eliminar(id);

//        }

//        public async Task<bool> Insertar(NovedadModel modelo)
//        {
//            return await _novedadRepo.Insertar(modelo);

//        }

//        public async Task<NovedadModel> Obtener(int id)
//        {
//            return await _novedadRepo.Obtener(id);

//        }

//        public async Task<IQueryable<NovedadModel>> ObtenerTodos()
//        {
//            return await _novedadRepo.ObtenerTodos();
//        }

//        public async Task<NovedadModel> ObtenerPorEmpleado(string nombreEmpleado)
//        {
//            IQueryable<NovedadModel> queryNovedadSQL = await _novedadRepo.ObtenerTodos();
//            NovedadModel novedad = queryNovedadSQL.Where(x => x.IdEmpleado == nombreEmpleado).FirstOrDefault();
//            return novedad;
//        }
//        /// <summary>
//        /// /////////////////////////////////////////////////////////////////////////////////////////
//        /// </summary>
//        /// <returns></returns>
//        public async Task<bool> InsertarNovedadValor(NovedadValor modelo)
//        {
//            return await _novedadRepo.Insertar(modelo);

//        }

//        public async Task<bool> InsertarNovedadFecha(NovedadFechas modelo)
//        {
//            return await _novedadRepo.Insertar(modelo);
//        }

//        public async Task<bool> InsertarNovedadHoras(NovedadHoras modelo)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> ActualizarNovedadValor(NovedadValor modelo)
//        {
//            return await _novedadRepo.Actualizar(modelo);
//        }

//        public async Task<bool> ActualizarNovedadFecha(NovedadFechas modelo)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> ActualizarNovedadHoras(NovedadHoras modelo)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> EliminarNovedadValor(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> EliminarNovedadFecha(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<bool> EliminarNovedadHoras(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<NovedadValor> ObtenerNovedadValor(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<NovedadFechas> ObtenerNovedadFecha(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<NovedadHoras> ObtenerNovedadHoras(int id)
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<NovedadValor>> ObtenerTodosNovedadValor()
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<NovedadFechas>> ObtenerTodosNovedadFechas()
//        {
//            throw new NotImplementedException();
//        }

//        public async Task<IEnumerable<NovedadHoras>> ObtenerTodosNovedadHoras()
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
