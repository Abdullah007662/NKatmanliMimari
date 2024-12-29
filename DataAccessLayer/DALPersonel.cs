using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Data.SqlClient;
using System.Data;



namespace DataAccessLayer
{
 
    public class DALPersonel
    {
        public static List<EntityPersonel> PersonelListesi()
        {
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            SqlCommand k1 = new SqlCommand("select * from TBL_BİLGİ", Baglanti.bgl);
            if (k1.Connection.State != ConnectionState.Open)
            {
                k1.Connection.Open();
            }
            SqlDataReader dr = k1.ExecuteReader();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = dr["AD"].ToString();
                ent.Soyad1 = dr["SOYAD"].ToString();
                ent.Görev = dr["GÖREV"].ToString();
                ent.Maaş = short.Parse(dr["MAAŞ"].ToString());
                ent.Şehir = dr["ŞEHİR"].ToString();
                degerler.Add(ent);


            }
            dr.Close();
            return degerler;

        }
        public static int PersonelEKle (EntityPersonel p)
        {
            SqlCommand k2 = new SqlCommand("insert into TBL_BİLGİ (AD,SOYAD,GÖREV,ŞEHİR,MAAŞ) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.bgl);
            if (k2.Connection.State != ConnectionState.Open)
            {
                k2.Connection.Open();
            }
            k2.Parameters.AddWithValue("@p1", p.Ad);
            k2.Parameters.AddWithValue("@p2", p.Soyad1);
            k2.Parameters.AddWithValue("@p3", p.Görev);
            k2.Parameters.AddWithValue("@p4", p.Şehir);
            k2.Parameters.AddWithValue("@p5", p.Maaş);
            return k2.ExecuteNonQuery();
        } 

        public static bool  PersonelSil(int k)
        {
            SqlCommand k3 = new SqlCommand("Delete from TBL_BİLGİ where ID=@P1", Baglanti.bgl);
            if (k3.Connection.State != ConnectionState.Open)
            {
                k3.Connection.Open();
            }
            k3.Parameters.AddWithValue("@P1", k);
             return k3.ExecuteNonQuery() > 0;
            

        }

        public static bool PersonelGüncelle (EntityPersonel ent)
        {
            SqlCommand k4 = new SqlCommand("Update TBL_BİLGİ SET AD=@P1,SOYAD=@P2,ŞEHİR=@P3,GÖREV=@P4,MAAŞ=@P5 where ID=@P6", Baglanti.bgl);
            if (k4.Connection.State != ConnectionState.Open)
            {
                k4.Connection.Open();
            }
            k4.Parameters.AddWithValue("@P1", ent.Ad);
            k4.Parameters.AddWithValue("@P2", ent.Soyad1);
            k4.Parameters.AddWithValue("@P3", ent.Şehir);
            k4.Parameters.AddWithValue("@P1", ent.Görev);
            k4.Parameters.AddWithValue("@P1", ent.Maaş);
            k4.Parameters.AddWithValue("@P1", ent.Id);
            return k4.ExecuteNonQuery() > 0;


        }
    }
}
