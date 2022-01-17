using MeFamilyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeFamilyBackEnd.ViewModels
{
    public class HomeViewModel
    {
        public List<Slider>Sliders { get; set; }
        public List<Service>Services { get; set; }
        public List<RecentPhoto> RecentPhotos { get; set; }
        public List<MyFamily> MyFamilies { get; set; }
    }
}
