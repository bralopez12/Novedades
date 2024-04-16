namespace Novedades.AppWeb.Models.ViewModels
{
    public class VMNovedadFechas //Se ponen los campos que se vayan a ver
    {
        public int IdNvn { get; set; }

        public string IdEmpleado { get; set; } = null!;

        public string IdConcepto { get; set; } = null!;

        public DateTime? FechaInicial { get; set; }

        public DateTime? FechaFinal { get; set; }

        public string? Observacion { get; set; }
    }
}
