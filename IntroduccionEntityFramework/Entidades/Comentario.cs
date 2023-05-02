namespace IntroduccionEntityFramework.Entidades
{
    public class Comentario
    {
        public int Id { get; set; }
        public string?Contenido { get; set; }
        public bool Recomendar { get; set;}
        //Para la cardinalidad de relaciones
        public int PeliculaId { get; set; }//Llave foranea
        public Pelicula Pelicula { get; set; } = null!;
    }
}
