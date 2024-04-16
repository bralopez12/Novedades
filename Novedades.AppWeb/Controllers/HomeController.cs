//using Microsoft.AspNetCore.Mvc;
//using Novedades.AppWeb.Models;
//using Novedades.AppWeb.Models.ViewModels;
//using Novedades.DAL.SqlServer.Entities;
//using Novedades.BLL.Service;
////using Novedades.DAL.Mongo;
//using Novedades.DAL.SqlServer.Entities;
//using Novedades.Models;
//using System.Diagnostics;
//using Novedades.DAL.SqlServer.Adaptador;

//namespace Novedades.AppWeb.Controllers
//{
//    public class HomeController : Controller
//    {
//        private readonly NovedadService _novedadService;

//        public HomeController(NovedadesRepository novedadServ)
//        {
//            _novedadService = novedadServ;
//        }

//        public IActionResult Index()
//        {
//            return View();
//        }

//        [HttpGet]

//        public async Task<IActionResult> Lista()
//        {
//            IQueryable<NovedadEntidad> queryNovedadSQL = await _novedadService.ObtenerTodos();

//            List<VMNovedadHoras> listaNovedadesAMostrar = queryNovedadSQL
//                                             .Select(x => new VMNovedadHoras()
//                                             {
//                                                 IdNvn = x.IdNvn,
//                                                 IdEmpleado = x.IdEmpleado,
//                                                 IdConcepto = x.IdConcepto,
//                                                 Valor = x.Valor,
//                                                 Horas = x.Horas,
//                                                 FechaInicial = x.FechaInicial,
//                                                 FechaFinal = x.FechaFinal,
//                                                 Observacion = x.Observacion
//                                             }).ToList();

//            return StatusCode(StatusCodes.Status200OK, listaNovedadesAMostrar);
//        }


//        [HttpPost]
//        public async Task<IActionResult> InsertarNovedadHoras([FromBody] VMNovedadHoras modelo)
//        {
//            NovedadHoras NuevoModeloHoras = new NovedadHoras()
//            {
//                IdNvn = modelo.IdNvn,
//                IdEmpleado = modelo.IdEmpleado,
//                IdConcepto = modelo.IdConcepto,
//                Horas = modelo.Horas,
//                Observacion = modelo.Observacion,
//            };

//            bool respuesta = await _novedadService.Insertar(NuevoModelo);

//            return StatusCode(StatusCodes.Status200OK, NuevoModelo);
//        }

//        public async Task<IActionResult> InsertarNovedadesValor([FromBody] VMNovedadValor modelo)
//        {
//            NovedadValor NuevoModeloValor = new NovedadValor(modelo.IdNvn, modelo.IdEmpresa, modelo.IdCompania, modelo.IdEmpleado, modelo.IdConcepto, modelo.Valor, modelo.Observacion);

//            bool respuesta = await _novedadService.Insertar(NuevoModeloValor);

//            return StatusCode(StatusCodes.Status200OK, NuevoModelo);
//        }

//        [HttpPut]
//        public async Task<IActionResult> Actualizar([FromBody] VMNovedadHoras modelo)
//        {
//            Novedades.Models.NovedadModel NuevoModelo = new NovedadModel()
//            {
//                IdNvn = modelo.IdNvn,
//                IdEmpleado = modelo.IdEmpleado,
//                IdConcepto = modelo.IdConcepto,
//                Valor = modelo.Valor,
//                Horas = modelo.Horas,
//                FechaInicial = modelo.FechaInicial,
//                FechaFinal = modelo.FechaFinal,
//                Observacion = modelo.Observacion
//            };

//            bool respuesta = await _novedadService.Insertar(NuevoModelo);

//            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
//        }


//        [HttpDelete]
//        public async Task<IActionResult> Eliminar(int id)
//        {


//            bool respuesta = await _novedadService.Eliminar(id);

//            return StatusCode(StatusCodes.Status200OK, new { valor = respuesta });
//        }




//        public IActionResult Privacy()
//        {
//            return View();
//        }

//        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
//        public IActionResult Error()
//        {
//            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
//        }
//    }
//}