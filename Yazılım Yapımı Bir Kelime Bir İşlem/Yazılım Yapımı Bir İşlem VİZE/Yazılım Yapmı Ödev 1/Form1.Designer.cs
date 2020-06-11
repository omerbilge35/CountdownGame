namespace Yazılım_Yapmı_Ödev_1
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
            this.rdb_manuel = new System.Windows.Forms.RadioButton();
            this.rdb_random = new System.Windows.Forms.RadioButton();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtxt_tek1 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_tek2 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_tek5 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_cift = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_tek3 = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_tek4 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mtxt_hedef = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_toplampuan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cozum = new System.Windows.Forms.TextBox();
            this.txt_sure = new System.Windows.Forms.TextBox();
            this.txt_kpuan = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_manuel
            // 
            this.rdb_manuel.AutoSize = true;
            this.rdb_manuel.Checked = true;
            this.rdb_manuel.Location = new System.Drawing.Point(12, 88);
            this.rdb_manuel.Name = "rdb_manuel";
            this.rdb_manuel.Size = new System.Drawing.Size(79, 17);
            this.rdb_manuel.TabIndex = 6;
            this.rdb_manuel.TabStop = true;
            this.rdb_manuel.Text = "Kendin Yaz";
            this.rdb_manuel.UseVisualStyleBackColor = true;
            this.rdb_manuel.CheckedChanged += new System.EventHandler(this.rdb_manuel_CheckedChanged);
            // 
            // rdb_random
            // 
            this.rdb_random.AutoSize = true;
            this.rdb_random.Location = new System.Drawing.Point(12, 117);
            this.rdb_random.Name = "rdb_random";
            this.rdb_random.Size = new System.Drawing.Size(103, 17);
            this.rdb_random.TabIndex = 7;
            this.rdb_random.Text = "Otomatik Oluştur";
            this.rdb_random.UseVisualStyleBackColor = true;
            this.rdb_random.CheckedChanged += new System.EventHandler(this.rdb_random_CheckedChanged);
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(159, 88);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(116, 46);
            this.btn_hesapla.TabIndex = 8;
            this.btn_hesapla.Text = "HESAPLA";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.mtxt_tek1);
            this.groupBox1.Controls.Add(this.mtxt_tek2);
            this.groupBox1.Controls.Add(this.mtxt_tek5);
            this.groupBox1.Controls.Add(this.mtxt_cift);
            this.groupBox1.Controls.Add(this.mtxt_tek3);
            this.groupBox1.Controls.Add(this.mtxt_tek4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanılacak Sayılar";
            // 
            // mtxt_tek1
            // 
            this.mtxt_tek1.Location = new System.Drawing.Point(15, 19);
            this.mtxt_tek1.Mask = "0";
            this.mtxt_tek1.Name = "mtxt_tek1";
            this.mtxt_tek1.Size = new System.Drawing.Size(32, 20);
            this.mtxt_tek1.TabIndex = 14;
            this.mtxt_tek1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mtxt_tek2
            // 
            this.mtxt_tek2.Location = new System.Drawing.Point(53, 19);
            this.mtxt_tek2.Mask = "0";
            this.mtxt_tek2.Name = "mtxt_tek2";
            this.mtxt_tek2.Size = new System.Drawing.Size(32, 20);
            this.mtxt_tek2.TabIndex = 15;
            this.mtxt_tek2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_tek2.ValidatingType = typeof(int);
            // 
            // mtxt_tek5
            // 
            this.mtxt_tek5.Location = new System.Drawing.Point(167, 19);
            this.mtxt_tek5.Mask = "0";
            this.mtxt_tek5.Name = "mtxt_tek5";
            this.mtxt_tek5.Size = new System.Drawing.Size(32, 20);
            this.mtxt_tek5.TabIndex = 18;
            this.mtxt_tek5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_tek5.ValidatingType = typeof(int);
            // 
            // mtxt_cift
            // 
            this.mtxt_cift.Location = new System.Drawing.Point(205, 19);
            this.mtxt_cift.Mask = "00";
            this.mtxt_cift.Name = "mtxt_cift";
            this.mtxt_cift.Size = new System.Drawing.Size(43, 20);
            this.mtxt_cift.TabIndex = 14;
            this.mtxt_cift.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_cift.ValidatingType = typeof(int);
            // 
            // mtxt_tek3
            // 
            this.mtxt_tek3.Location = new System.Drawing.Point(91, 19);
            this.mtxt_tek3.Mask = "0";
            this.mtxt_tek3.Name = "mtxt_tek3";
            this.mtxt_tek3.Size = new System.Drawing.Size(32, 20);
            this.mtxt_tek3.TabIndex = 16;
            this.mtxt_tek3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_tek3.ValidatingType = typeof(int);
            // 
            // mtxt_tek4
            // 
            this.mtxt_tek4.Location = new System.Drawing.Point(129, 19);
            this.mtxt_tek4.Mask = "0";
            this.mtxt_tek4.Name = "mtxt_tek4";
            this.mtxt_tek4.Size = new System.Drawing.Size(32, 20);
            this.mtxt_tek4.TabIndex = 17;
            this.mtxt_tek4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_tek4.ValidatingType = typeof(int);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mtxt_hedef);
            this.groupBox2.Location = new System.Drawing.Point(290, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 53);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hedef Sayı";
            // 
            // mtxt_hedef
            // 
            this.mtxt_hedef.Location = new System.Drawing.Point(21, 19);
            this.mtxt_hedef.Mask = "000";
            this.mtxt_hedef.Name = "mtxt_hedef";
            this.mtxt_hedef.Size = new System.Drawing.Size(74, 20);
            this.mtxt_hedef.TabIndex = 15;
            this.mtxt_hedef.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxt_hedef.ValidatingType = typeof(int);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txt_toplampuan);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(311, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(85, 57);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Toplam Puan";
            // 
            // txt_toplampuan
            // 
            this.txt_toplampuan.BackColor = System.Drawing.SystemColors.Control;
            this.txt_toplampuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_toplampuan.Location = new System.Drawing.Point(26, 28);
            this.txt_toplampuan.Name = "txt_toplampuan";
            this.txt_toplampuan.Size = new System.Drawing.Size(31, 13);
            this.txt_toplampuan.TabIndex = 0;
            this.txt_toplampuan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Çözüm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Geçen Süre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Kazanılan Puan:";
            // 
            // txt_cozum
            // 
            this.txt_cozum.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_cozum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_cozum.Location = new System.Drawing.Point(65, 157);
            this.txt_cozum.Name = "txt_cozum";
            this.txt_cozum.Size = new System.Drawing.Size(195, 13);
            this.txt_cozum.TabIndex = 17;
            // 
            // txt_sure
            // 
            this.txt_sure.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_sure.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sure.Location = new System.Drawing.Point(90, 192);
            this.txt_sure.Name = "txt_sure";
            this.txt_sure.Size = new System.Drawing.Size(100, 13);
            this.txt_sure.TabIndex = 18;
            // 
            // txt_kpuan
            // 
            this.txt_kpuan.BackColor = System.Drawing.SystemColors.Menu;
            this.txt_kpuan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_kpuan.Location = new System.Drawing.Point(296, 192);
            this.txt_kpuan.Name = "txt_kpuan";
            this.txt_kpuan.Size = new System.Drawing.Size(100, 13);
            this.txt_kpuan.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 227);
            this.Controls.Add(this.txt_kpuan);
            this.Controls.Add(this.txt_sure);
            this.Controls.Add(this.txt_cozum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.rdb_random);
            this.Controls.Add(this.rdb_manuel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bir İşlem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton rdb_manuel;
        private System.Windows.Forms.RadioButton rdb_random;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_toplampuan;
        private System.Windows.Forms.MaskedTextBox mtxt_tek1;
        private System.Windows.Forms.MaskedTextBox mtxt_tek2;
        private System.Windows.Forms.MaskedTextBox mtxt_tek4;
        private System.Windows.Forms.MaskedTextBox mtxt_tek3;
        private System.Windows.Forms.MaskedTextBox mtxt_tek5;
        private System.Windows.Forms.MaskedTextBox mtxt_cift;
        private System.Windows.Forms.MaskedTextBox mtxt_hedef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cozum;
        private System.Windows.Forms.TextBox txt_sure;
        private System.Windows.Forms.TextBox txt_kpuan;
    }
}

