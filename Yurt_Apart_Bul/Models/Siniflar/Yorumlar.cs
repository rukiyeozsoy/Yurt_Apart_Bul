using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yurt_Apart_Bul.Models.Siniflar
{
    public class Yorumlar
    {
        [Key]
        public int ID { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int YurtApartID { get; set; }
        public virtual YurtApart YurtApart { get; set; }
    }
}