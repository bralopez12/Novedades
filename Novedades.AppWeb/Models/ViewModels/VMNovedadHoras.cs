namespace Novedades.AppWeb.Models.ViewModels
{
    public class VMNovedadHoras //Se ponen los campos que se vayan a ver en el front
    {
        public int IdNvn { get; set; }

        public string IdEmpleado { get; set; } = null!;

        public string IdConcepto { get; set; } = null!;

        public double? Horas { get; set; }

        public string? Observacion { get; set; }
    }
}
