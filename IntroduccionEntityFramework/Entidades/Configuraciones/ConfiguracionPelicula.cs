using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionEntityFramework.Entidades.Configuraciones
{
    public class ConfiguracionPelicula
    {
        public void Configure(EntityTypeBuilder<Pelicula> builder)
        {
            //modelBuilder.Entity<Pelicula>().Property(a => a.Titulo).HasMaxLength(150);
            builder.Property(a => a.FechaEstreno).HasColumnType("date");//para que sea solo fecha sin hora
        }
    }
}
