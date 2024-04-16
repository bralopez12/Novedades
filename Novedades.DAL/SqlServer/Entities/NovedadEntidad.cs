using System;
using System.Collections.Generic;

namespace Novedades.DAL.SqlServer.Entities;

public partial class NovedadEntidad
{
    public int IdNvn { get; set; }

    public int IdEmpresa { get; set; }

    public string IdCompania { get; set; } = null!;

    public string IdEmpleado { get; set; } = null!;

    public string IdConcepto { get; set; } = null!;

    public double? Valor { get; set; }

    public double? Horas { get; set; }

    public DateTime? FechaInicial { get; set; }

    public DateTime? FechaFinal { get; set; }

    public string? Observacion { get; set; }
}
