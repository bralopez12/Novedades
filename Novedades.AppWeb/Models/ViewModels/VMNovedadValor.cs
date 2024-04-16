namespace Novedades.AppWeb.Models.ViewModels
{
    public class VMNovedadValor //Se ponen los campos que se vayan a ver
    {
        public int IdNvn { get; set; }

        public int IdEmpresa { get; set; }

        public string IdCompania { get; set; } = null!;

        public string IdEmpleado { get; set; } = null!;

        public string IdConcepto { get; set; } = null!;

        public double? Valor { get; set; }

        public string? Observacion { get; set; }
    }
}
