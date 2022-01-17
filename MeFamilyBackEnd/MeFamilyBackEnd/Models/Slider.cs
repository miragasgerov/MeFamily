using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeFamilyBackEnd.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string Image { get; set; }
        
        [NotMapped]
        public IFormFile ImageFile { get; set; }

    }
}
