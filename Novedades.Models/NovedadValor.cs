using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novedades.Models
{

    public class NovedadValor
    {
        public int IdNvn { get; set; }

        public int IdEmpresa { get; set; }

        public string IdCompania { get; set; } = null!;

        public string IdEmpleado { get; set; } = null!;

        public string IdConcepto { get; set; } = null!;

        public double? Valor { get; set; }

        public string? Observacion { get; set; }
        public NovedadValor(int idNvn, int idEmpresa, string idCompania, string idEmpleado, string idConcepto, double? valor, string? observacion)
        {
            IdNvn = idNvn;
            IdEmpresa = idEmpresa;
            IdCompania = idCompania;
            IdEmpleado = idEmpleado;
            IdConcepto = idConcepto;
            Valor = valor;
            Observacion = observacion;
        }

    }
}
