using System.ComponentModel.DataAnnotations;

namespace IntroduccionEntityFramework.Entidades
{
    public class Genero
    {
        [Key] //PARA QUE ID SEA UNA LLAVE PRIMARIA
        public int Id { get; set; }
       // [StringLength(maximumLength:150)]  //permite longitud de caracteres
        public string Nombre { get; set; } = null!;/* para que no me salga alerta de nulo*/

        public HashSet<Pelicula> Peliculas  { get; set; }= new HashSet<Pelicula>(); //hace referencia peliculas mucho a muchos
     
    }
}
