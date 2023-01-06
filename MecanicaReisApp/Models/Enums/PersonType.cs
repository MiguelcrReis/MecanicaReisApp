using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MecanicaReisApp.Models.Enums
{
    public enum PersonType
    {
        [Display(Name = "Physical Person")]
        PhysicalPerson = 1,

        [Display(Name = "Legal Person")]
        LegalPerson = 2
    }
}
