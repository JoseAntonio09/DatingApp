using System;
using System.ComponentModel.DataAnnotations;
using static ApiPeliculas.Models.Pelicula;

namespace ApiPeliculas.Models.Dtos
{
    public class PeliculaDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        public string Nombre { get; set; }
        public string RutaImagen { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Description { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Duracion { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public TipoClasificacion Clasificacion { get; set; }
        public int categoriaId { get; set; }
        public Categoria Categoria { get; set; }
    }
}
