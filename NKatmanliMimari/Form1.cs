﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = txtAD.Text;
            ent.Soyad1 = txtSoyad.Text;
            ent.Görev = txtmaaş.Text;
            ent.Şehir = txtŞehir.Text;
            ent.Maaş = short.Parse(txtmaaş.Text);
            LogicPersonel.LLPersonelEkle(ent);
            MessageBox.Show("Personel Eklendi");
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
            MessageBox.Show("Personel Silindi");
        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Ad = txtAD.Text;
            ent.Soyad1 = txtSoyad.Text;
            ent.Şehir = txtŞehir.Text;
            ent.Görev = txtgörev.Text;
            ent.Maaş = short.Parse(txtmaaş.Text);
            LogicPersonel.LLPersonelGüncelle(ent);  

        }
    }
}
