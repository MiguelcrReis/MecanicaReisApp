using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace MecanicaReisApp.Models.Entities
{
    public class LegalPerson
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        public Person Person { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }
        [Required(ErrorMessage = "{0} required")]
        public string Cpf { get; set; }
    }
}
