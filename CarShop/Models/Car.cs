using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace CarShop.Models
{
    public class Car
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "The field is required")]
        public string Name { get; set; } = default!;
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy}")]
        public int Year { get; set; }

        [ForeignKey("Brand")]
        public int BrandId { get; set; }
        public Brand? Brand { get; set; }

    }
}
