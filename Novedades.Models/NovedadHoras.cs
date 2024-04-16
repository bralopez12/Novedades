using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Novedades.Models
{
    public class NovedadHoras
    {
        public int IdNvn { get; set; }

        public int IdEmpresa { get; set; }

        public string IdCompania { get; set; } = null!;

        public string IdEmpleado { get; set; } = null!;

        public string IdConcepto { get; set; } = null!;

        public double? Horas { get; set; }

        public string? Observacion { get; set; }
    }
}
