using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JuanPr.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }

        public double Price { get; set; }
        public double oldPrice { get; set; }
        public string mainIcon { get; set; }
        public string Icon1 { get; set; }
        public string Icon2 { get; set; }

    }
}
