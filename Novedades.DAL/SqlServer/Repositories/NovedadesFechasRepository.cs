﻿//using Novedades.DAL.SqlServer.DataContext;
//using Novedades.DAL.SqlServer.Entities;
//using Novedades.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Novedades.DAL.SqlServer.Repositories
//{
//    public class NovedadesFechasRepository
//    {
//        private readonly DbnovedadesContext _dbcontext;

//        public NovedadesRepository(DbnovedadesContext context)
//        {
//            _dbcontext = context;
//        }
//        public async Task<bool> Actualizar(NovedadModel modelo)
//        {
//            _dbcontext.Novedades.Update(modelo.Map());
//            await _dbcontext.SaveChangesAsync();
//            return true;
//        }

//        public async Task<bool> Eliminar(int id)
//        {
//            NovedadEntidad modelo = _dbcontext.Novedades.First(x => x.IdNvn == id);
//            _dbcontext.Novedades.Remove(modelo);
//            await _dbcontext.SaveChangesAsync();
//            return true;
//        }

//        public async Task<bool> Insertar(NovedadModel modelo)
//        {
//            _dbcontext.Novedades.Add(modelo.Map());
//            await _dbcontext.SaveChangesAsync();
//            return true;
//        }

//        public async Task<NovedadModel?> Obtener(int id)
//        {
//            NovedadEntidad? novedadEntidad = await _dbcontext.Novedades.FindAsync(id);
//            if (novedadEntidad == null)
//                return null;

//            return novedadEntidad.Map();
//        }

//        public async Task<IEnumerable<NovedadModel>> ObtenerTodos()
//        {
//            List<NovedadEntidad> queryNovedadSQL = await _dbcontext.Novedades.ToListAsync();
//            return queryNovedadSQL.Select(x => x.Map());
//        }
//    }
//}
