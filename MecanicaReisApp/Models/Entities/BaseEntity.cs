using System;
using System.ComponentModel.DataAnnotations;

namespace MecanicaReisApp.Models.Entities
{
    public class BaseEntity
    {
        [Key]
        public string Id { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
