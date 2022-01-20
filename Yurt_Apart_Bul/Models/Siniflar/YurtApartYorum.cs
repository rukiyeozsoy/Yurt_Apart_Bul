using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace Yurt_Apart_Bul.Models.Siniflar
{
    public class YurtApartYorum
    {
        public IEnumerable<YurtApart> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<YurtApart> Deger3 { get; set; }
    }
}