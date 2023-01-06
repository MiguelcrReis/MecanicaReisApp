using MecanicaReisApp.Models.Enums;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace MecanicaReisApp.Models.Entities
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [BindProperty, Required(ErrorMessage = "{0} required")]
        [Display(Name = "Person Type")]
        public PersonType PersonType { get; set; }

        [Required(ErrorMessage = "{0} required")]
        public RegistrationType RegistrationType { get; set; }

        [Required(ErrorMessage = "{0} required")]
        [Display(Name = "Registration Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime RegistrationDate { get; set; }
    }
}
