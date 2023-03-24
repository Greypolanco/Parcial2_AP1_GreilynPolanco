public class ProductosDetalle
{
    [Key]
    public int DetalleId { get; set; }
    public int ProductoId { get; set; }
    public string Descripcion { get; set; } = string.Empty;
    public int Cantidad { get; set; }
}