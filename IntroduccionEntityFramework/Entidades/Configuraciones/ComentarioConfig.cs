using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace IntroduccionEntityFramework.Entidades.Configuraciones
{
    public class ComentarioConfig : IEntityTypeConfiguration<Comentario>
    {

       

        public void Configure(EntityTypeBuilder<Comentario> builder)
        {
            builder.Property(a => a.Contenido).HasMaxLength(500);
        }
    }
}
