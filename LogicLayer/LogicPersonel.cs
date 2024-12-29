using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }
        public static int LLPersonelEkle(EntityPersonel p)
        {
            if(p.Ad !="" && p.Soyad1!=""&&p.Maaş>3500 && p.Ad.Length >= 3)
            {
                return DALPersonel.PersonelEKle(p);
            }
            else
            {
                return -1;
            }
            
        }
        public static bool LLPersonelSil(int Per)
        {
            if(Per>=1 )
            {
                return DALPersonel.PersonelSil(Per);
            }
            else
            {
                return false;
            }
        }

        public static bool LLPersonelGüncelle(EntityPersonel ent)
        {
            if(ent.Ad.Length>=3 && ent.Ad!="" && ent.Maaş>=6000)
            {
                return DALPersonel.PersonelGüncelle(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
