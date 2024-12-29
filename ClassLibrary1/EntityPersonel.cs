using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
     public  class EntityPersonel
    {
        private int id;
        private string ad;
        private string Soyad;
        private string şehir;
        private string görev;
        private short maaş;

        public int Id { get => id; set => id = value; }
        public string Ad { get => ad; set => ad = value; }
        public string Soyad1 { get => Soyad; set => Soyad = value; }
        public string Şehir { get => şehir; set => şehir = value; }
        public string Görev { get => görev; set => görev = value; }
        public short Maaş { get => maaş; set => maaş = value; }
    }
}
