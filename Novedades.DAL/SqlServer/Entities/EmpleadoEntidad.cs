using System;
using System.Collections.Generic;

namespace Novedades.DAL.SqlServer.Entities;

public partial class EmpleadoEntidad
{
    public int IdEmpleado { get; set; }

    public string Nombre { get; set; } = null!;
}
