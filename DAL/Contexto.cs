public class Contexto : DbContext
{
    #nullable disable
    public DbSet<Productos> Productos { get; set; }

    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

     protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Productos>().HasData(
            new Productos{
                ProductoId =1,
                Fecha = DateTime.Today,
                Concepto = "Many"
            },

            new Productos{
                ProductoId =2,
                Fecha = DateTime.Today,
                Concepto = "Pasas"
            },

            new Productos{
                ProductoId =3,
                Fecha = DateTime.Today,
                Concepto = "Ciruela"
            },

            new Productos{
                ProductoId =4,
                Fecha = DateTime.Today,
                Concepto = "Arandanos"
            }

        );
    }

}