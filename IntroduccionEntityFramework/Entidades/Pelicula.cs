namespace IntroduccionEntityFramework.Entidades
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = null!;
        public bool EnCines { get; set; }   
        public DateTime FechaEstreno { get; set; }
        public HashSet<Comentario> Comentarios { get; set; } = new HashSet<Comentario>();//Son varios comentarios
        //muchos a muchos entre peliculas y generos
        public HashSet<Genero> Generos { get; set; } = new HashSet<Genero>();
    }
}
