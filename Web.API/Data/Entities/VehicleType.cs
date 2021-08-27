using System.ComponentModel.DataAnnotations;

namespace Web.API.Data.Entities
{
    public class VehicleType

    {
        public int Id { get; set; }
        [Display(Name = "Tipo de vehiculo")]
        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracter")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Description { get; set; }

    }
}
