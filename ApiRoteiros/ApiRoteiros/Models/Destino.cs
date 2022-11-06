using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiRoteiros.Models
{
    [Table("Destino")]
    public class Destino
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o pais de destino")]
        [StringLength(50)]
        public string Pais { get; set; }
        [Required(ErrorMessage = "Informe a cidade de destino")]
        public string Cidade { get; set; }
    }
}
