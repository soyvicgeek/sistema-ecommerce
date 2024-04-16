using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEcommerce.Modelos
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "El Número de serie es requerido")]
        [MaxLength(30, ErrorMessage = "Máximo 30 Caractéres")]
        public string NumeroSerie { get; set; }
        [Required(ErrorMessage = "La descripción es requereida")]
        [MaxLength(100, ErrorMessage = "Máximo 100 Caractéres")]
        public string Descripcion { get; set; }
        [Required(ErrorMessage = "Precio Requerido")]
        public double Precio { get; set; }
        [Required(ErrorMessage = "El costo es Requerido")]
        public double Costo { get; set; }
        public string ImagenUrl { get; set; }
        [Required(ErrorMessage = "El Estado es Requerdio")]
        public bool Estado { get; set; }

        //Hagamos la relación con la tabla categoría
        [Required(ErrorMessage = "La categpría es requerida")]
        public int CategoriaId { get; set; }
        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set; }

        //Hagamos la relación en la tabla Marca
        [Required(ErrorMessage = "La Marca es Requerida")]
        public int MarcaId { get; set; }
        [ForeignKey("MarcaId")]
        public Marca Marca { get; set; }

        //Hagamos la recursividad del padre
        public int? PadreId { get; set; }
        public virtual Producto Padre { get; set; }
    }
}
