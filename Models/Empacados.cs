
public class Empacados
{
    [Key]
    public int EmpacadoId { get; set; }
    public DateOnly Fecha { get; set; } 
    public string Concepto { get; set; } = string.Empty;
    public int Cantidad { get; set; }
    [ForeignKey("ProductoId")]
    public virtual List<EmpacadosDetalle> EmpacadosDetalle { get; set; } = new List<EmpacadosDetalle>();
}