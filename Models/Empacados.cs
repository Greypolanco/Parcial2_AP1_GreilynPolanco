
public class Empacados
{
    [Key]
    public int EmpacadoId { get; set; }
    public DateOnly Fecha { get; set; } 
    public string Concepto { get; set; } = string.Empty;
    [ForeignKey("EmpacadoId")]
    public virtual List<EmpacadosDetalle> EmpacadosDetalle { get; set; } = new List<EmpacadosDetalle>();
    public int Cantidad { get; set; }
    public int ProductoId {get; set;}
}