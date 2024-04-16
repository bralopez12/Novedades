using System;
using System.Collections.Generic;

namespace Novedades.DAL.SqlServer.Entities;

public partial class ConceptoEntidad
{
    public int IdConcepto { get; set; }

    public int IdCompania { get; set; }

    public string Descripcion { get; set; } = null!;

    public string Clase { get; set; } = null!;

    public string Tipo { get; set; } = null!;
}
