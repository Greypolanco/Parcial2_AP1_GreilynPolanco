
public class Empacados
{
    [Key]
    public int EmpacadoId { get; set; }
    public DateTime Fecha { get; set; }
    public string Concepto { get; set; } = string.Empty;
    [ForeignKey("ProductoId")]
    public virtual List<EmpacadosDetalle> EmpacadosDetalle { get; set; } = new List<EmpacadosDetalle>();
}