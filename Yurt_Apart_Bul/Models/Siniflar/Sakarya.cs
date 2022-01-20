using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yurt_Apart_Bul.Models.Siniflar
{
    public class Sakarya
    {
        [Key]
        public int ID { get; set; }
        public string YurtAd { get; set; }
        public string Aciklama { get; set; }
        public string YurtImage { get; set; }
    }
}