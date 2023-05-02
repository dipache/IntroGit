using IntroduccionEntityFramework.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace IntroduccionEntityFramework
{
    public class AplicationDbContext : DbContext/*Control . y genero contrusctor con options*/
    {
        public AplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)//Para Api fluente tipo de caracteres longitud etc
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());//aplicando clases de configuraciones
            
     
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {
            configurationBuilder.Properties<string>().HaveMaxLength(150);

        }
        public DbSet<Genero> Generos => Set<Genero>();//Con DbSet digo que una clase a va ser una tabla de base de datos
        public DbSet<Actor> Actores => Set<Actor>(); 
        public DbSet<Pelicula> Peliculas => Set<Pelicula>();
        public DbSet<Comentario> Comentario => Set<Comentario>();

    }
   
    
}
