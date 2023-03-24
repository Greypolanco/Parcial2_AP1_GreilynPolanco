
public class ProductosBLL
{
    private Contexto _contexto;
    public ProductosBLL(Contexto _contexto)
    {
        this._contexto = _contexto;
    }

    public List<Productos> GetList(Expression<Func<Productos, bool>>criterios){
        return _contexto.Productos.AsNoTracking().Where(criterios).ToList();
    }
}