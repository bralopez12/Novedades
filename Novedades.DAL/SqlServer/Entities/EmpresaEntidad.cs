using System;
using System.Collections.Generic;

namespace Novedades.DAL.SqlServer.Entities;

public partial class EmpresaEntidad
{
    public int NitEmpresa { get; set; }

    public string Nombre { get; set; } = null!;
}
