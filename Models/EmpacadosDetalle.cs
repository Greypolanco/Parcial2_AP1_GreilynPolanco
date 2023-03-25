public class EmpacadosDetalle
{
    [Key]
    public int DetalleId { get; set; }
    public int ProductoId { get; set; }
    public int EmpacadoId { get; set; }
    public int Cantidad { get; set; }
}