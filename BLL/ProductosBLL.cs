
public class ProductosBLL
{
    private Contexto _contexto;
    public ProductosBLL(Contexto _contexto)
    {
        this._contexto = _contexto;
    }

    public Productos? Buscar(int ProductoId)
    {
        return _contexto.Productos.Where(p => p.ProductoId == ProductoId).AsNoTracking().SingleOrDefault();
    }

    public List<Productos> GetList(Expression<Func<Productos, bool>>criterios){
        return _contexto.Productos.AsNoTracking().Where(criterios).ToList();
    }
}