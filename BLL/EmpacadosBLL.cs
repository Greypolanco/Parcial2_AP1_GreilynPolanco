public class EmpacadosBLL
{
    private Contexto _contexto;

    public EmpacadosBLL(Contexto _contexto)
    {
        this._contexto = _contexto;
    }
    public bool Existe(int EmpacadoId)
    {
        return _contexto.Empacados.Any(emp => emp.EmpacadoId == EmpacadoId);
    }
    public bool Insertar(Empacados empacado)
    {
        try{
            _contexto.Empacados.Add(empacado);
            return _contexto.SaveChanges() > 0;
        }
        catch(Exception)
        {
            return false;
        }
    }
    public bool Modificar(Empacados empacado)
    {
        try{
            _contexto.Database.ExecuteSqlRaw($"DELETE FROM EmpacadoDetalle WHERE EmpacadoId = {empacado.EmpacadoId}");
            foreach (var New in empacado.EmpacadosDetalle)
            {
                _contexto.Entry(New).State = EntityState.Added;
            }
            _contexto.Entry(empacado).State = EntityState.Modified;
            return _contexto.SaveChanges() > 0;
        }
        catch(Exception)
        {
            return false;
        }
    }
    public bool Guardar(Empacados empacado)
    {
        try{
            if(!Existe(empacado.EmpacadoId))
                return Insertar(empacado);
            else
                return Modificar(empacado);
        }
        catch(Exception)
        {
            return false;
        }
    }
    public bool Eliminar(Empacados empacado)
    {
        try{
            _contexto.Entry(empacado).State = EntityState.Deleted;
            return _contexto.SaveChanges() > 0;
        }
        catch(Exception)
        {
            return false;
        }

    }
    public Empacados? Buscar(int EmpacadoId)
    {
        return _contexto.Empacados.Include(e => e.EmpacadosDetalle).Where(emp => emp.EmpacadoId == EmpacadoId).AsNoTracking().SingleOrDefault();
    }
    public List<Empacados> GetList(Expression<Func<Empacados,bool>> criterio)
    {
        return _contexto.Empacados.Include(e => e.EmpacadosDetalle).AsNoTracking().Where(criterio).ToList();
    }
}
