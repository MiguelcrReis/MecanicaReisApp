using System;
using System.ComponentModel.DataAnnotations;

namespace MecanicaReisApp.Models.Entities
{
    public class Client : BaseEntity
    {
        [Required(ErrorMessage = "{0} required")]
        public Person Person { get; set; }

        //public PhysicalPerson PhysicalPerson { get; set; }
        //public LegalPerson LegalPerson { get; set; }
        public bool Active { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RegistrationDate { get; set; }
    }
}
