using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MeFamilyBackEnd.Models
{
    public class MyFamily
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TopText { get; set; }
        public string ParagraphText { get; set; }
        public string List { get; set; }
        public string AboutText { get; set; }
        public string Image { get; set; }
        public string BtnText { get; set; }

        [NotMapped]
        public IFormFile ImageFile {get;set;}
    }
}
