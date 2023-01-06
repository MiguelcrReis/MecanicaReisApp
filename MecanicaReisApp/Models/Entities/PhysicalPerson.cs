using System.ComponentModel.DataAnnotations;

namespace MecanicaReisApp.Models.Entities
{
    public class PhysicalPerson
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "{0} required")]
        public Person Person { get; set; }

        [Required(ErrorMessage = "{0} required")]
        public string FantasyName { get; set; }

        [Required(ErrorMessage = "{0} required")]
        public string CorporateName { get; set; }

        [Required(ErrorMessage = "{0} required")]
        public string Cnpj { get; set; }
    }
}
