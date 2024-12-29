namespace NKatmanliMimari
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlistele = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAD = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtŞehir = new System.Windows.Forms.TextBox();
            this.txtgörev = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmaaş = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.BTNGÜNCELLE = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 321);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1240, 235);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(64, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // btnlistele
            // 
            this.btnlistele.Location = new System.Drawing.Point(717, 21);
            this.btnlistele.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(282, 36);
            this.btnlistele.TabIndex = 2;
            this.btnlistele.Text = "LİSTELE";
            this.btnlistele.UseVisualStyleBackColor = true;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 34);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "AD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "SOYAD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 62);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "GÖREV:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "MAAŞ:";
            // 
            // txtAD
            // 
            this.txtAD.Location = new System.Drawing.Point(102, 67);
            this.txtAD.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAD.Name = "txtAD";
            this.txtAD.Size = new System.Drawing.Size(211, 34);
            this.txtAD.TabIndex = 8;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(102, 113);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(211, 34);
            this.txtSoyad.TabIndex = 9;
            // 
            // txtŞehir
            // 
            this.txtŞehir.Location = new System.Drawing.Point(448, 24);
            this.txtŞehir.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtŞehir.Name = "txtŞehir";
            this.txtŞehir.Size = new System.Drawing.Size(211, 34);
            this.txtŞehir.TabIndex = 10;
            // 
            // txtgörev
            // 
            this.txtgörev.Location = new System.Drawing.Point(448, 70);
            this.txtgörev.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtgörev.Name = "txtgörev";
            this.txtgörev.Size = new System.Drawing.Size(211, 34);
            this.txtgörev.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "ŞEHİR:";
            // 
            // txtmaaş
            // 
            this.txtmaaş.Location = new System.Drawing.Point(448, 116);
            this.txtmaaş.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtmaaş.Name = "txtmaaş";
            this.txtmaaş.Size = new System.Drawing.Size(211, 34);
            this.txtmaaş.TabIndex = 13;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(717, 70);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(282, 35);
            this.btnEkle.TabIndex = 14;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(717, 117);
            this.btnsil.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(282, 35);
            this.btnsil.TabIndex = 15;
            this.btnsil.Text = "SİL";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // BTNGÜNCELLE
            // 
            this.BTNGÜNCELLE.Location = new System.Drawing.Point(717, 164);
            this.BTNGÜNCELLE.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.BTNGÜNCELLE.Name = "BTNGÜNCELLE";
            this.BTNGÜNCELLE.Size = new System.Drawing.Size(282, 35);
            this.BTNGÜNCELLE.TabIndex = 16;
            this.BTNGÜNCELLE.Text = "GÜNCELLE";
            this.BTNGÜNCELLE.UseVisualStyleBackColor = true;
            this.BTNGÜNCELLE.Click += new System.EventHandler(this.BTNGÜNCELLE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(1268, 564);
            this.Controls.Add(this.BTNGÜNCELLE);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtmaaş);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgörev);
            this.Controls.Add(this.txtŞehir);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnlistele);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAD;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtŞehir;
        private System.Windows.Forms.TextBox txtgörev;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmaaş;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button BTNGÜNCELLE;
    }
}

