
public class Productos
{
    [Key]
    public int ProductoId { get; set; }
    public DateTime Fecha { get; set; }
    public string Concepto { get; set; } = string.Empty;
    [ForeignKey("ProductoId")]
    public virtual List<ProductosDetalle> ProductosDetalle { get; set; } = new List<ProductosDetalle>();
}