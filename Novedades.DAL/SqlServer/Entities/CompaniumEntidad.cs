using System;
using System.Collections.Generic;

namespace Novedades.DAL.SqlServer.Entities;

public partial class CompaniumEntidad
{
    public int IdCompania { get; set; }

    public string Nombre { get; set; } = null!;
}
