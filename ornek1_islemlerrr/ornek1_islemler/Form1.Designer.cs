namespace ornek1_islemler
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
            this.dortislem = new System.Windows.Forms.RadioButton();
            this.alanhesabi = new System.Windows.Forms.RadioButton();
            this.panel4islem = new System.Windows.Forms.Panel();
            this.carpmacek = new System.Windows.Forms.CheckBox();
            this.bolmecek = new System.Windows.Forms.CheckBox();
            this.cikarmacek = new System.Windows.Forms.CheckBox();
            this.toplamacek = new System.Windows.Forms.CheckBox();
            this.panelalan = new System.Windows.Forms.Panel();
            this.karecek = new System.Windows.Forms.CheckBox();
            this.ucgencek = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelsayi = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sayi2 = new System.Windows.Forms.TextBox();
            this.sayi1 = new System.Windows.Forms.TextBox();
            this.panelucgenalan = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ucgen_taban = new System.Windows.Forms.TextBox();
            this.ucgen_h = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4islem.SuspendLayout();
            this.panelalan.SuspendLayout();
            this.panelsayi.SuspendLayout();
            this.panelucgenalan.SuspendLayout();
            this.SuspendLayout();
            // 
            // dortislem
            // 
            this.dortislem.AutoSize = true;
            this.dortislem.Location = new System.Drawing.Point(75, 26);
            this.dortislem.Name = "dortislem";
            this.dortislem.Size = new System.Drawing.Size(57, 17);
            this.dortislem.TabIndex = 0;
            this.dortislem.Text = "4 işlem";
            this.dortislem.UseVisualStyleBackColor = true;
            this.dortislem.CheckedChanged += new System.EventHandler(this.dortislem_CheckedChanged);
            // 
            // alanhesabi
            // 
            this.alanhesabi.AutoSize = true;
            this.alanhesabi.Location = new System.Drawing.Point(244, 26);
            this.alanhesabi.Name = "alanhesabi";
            this.alanhesabi.Size = new System.Drawing.Size(100, 17);
            this.alanhesabi.TabIndex = 1;
            this.alanhesabi.Text = "Alan hesaplama";
            this.alanhesabi.UseVisualStyleBackColor = true;
            this.alanhesabi.CheckedChanged += new System.EventHandler(this.alanhesabi_CheckedChanged);
            // 
            // panel4islem
            // 
            this.panel4islem.Controls.Add(this.carpmacek);
            this.panel4islem.Controls.Add(this.bolmecek);
            this.panel4islem.Controls.Add(this.cikarmacek);
            this.panel4islem.Controls.Add(this.toplamacek);
            this.panel4islem.Location = new System.Drawing.Point(29, 70);
            this.panel4islem.Name = "panel4islem";
            this.panel4islem.Size = new System.Drawing.Size(164, 105);
            this.panel4islem.TabIndex = 2;
            this.panel4islem.Visible = false;
            // 
            // carpmacek
            // 
            this.carpmacek.AutoSize = true;
            this.carpmacek.Location = new System.Drawing.Point(46, 72);
            this.carpmacek.Name = "carpmacek";
            this.carpmacek.Size = new System.Drawing.Size(61, 17);
            this.carpmacek.TabIndex = 3;
            this.carpmacek.Text = "çarpma";
            this.carpmacek.UseVisualStyleBackColor = true;
            // 
            // bolmecek
            // 
            this.bolmecek.AutoSize = true;
            this.bolmecek.Location = new System.Drawing.Point(46, 49);
            this.bolmecek.Name = "bolmecek";
            this.bolmecek.Size = new System.Drawing.Size(54, 17);
            this.bolmecek.TabIndex = 2;
            this.bolmecek.Text = "bolme";
            this.bolmecek.UseVisualStyleBackColor = true;
            // 
            // cikarmacek
            // 
            this.cikarmacek.AutoSize = true;
            this.cikarmacek.Location = new System.Drawing.Point(46, 26);
            this.cikarmacek.Name = "cikarmacek";
            this.cikarmacek.Size = new System.Drawing.Size(64, 17);
            this.cikarmacek.TabIndex = 1;
            this.cikarmacek.Text = "Çıkarma";
            this.cikarmacek.UseVisualStyleBackColor = true;
            this.cikarmacek.CheckedChanged += new System.EventHandler(this.cikarmacek_CheckedChanged);
            // 
            // toplamacek
            // 
            this.toplamacek.AutoSize = true;
            this.toplamacek.Location = new System.Drawing.Point(46, 3);
            this.toplamacek.Name = "toplamacek";
            this.toplamacek.Size = new System.Drawing.Size(63, 17);
            this.toplamacek.TabIndex = 0;
            this.toplamacek.Text = "toplama";
            this.toplamacek.UseVisualStyleBackColor = true;
            this.toplamacek.CheckedChanged += new System.EventHandler(this.toplamacek_CheckedChanged);
            // 
            // panelalan
            // 
            this.panelalan.Controls.Add(this.karecek);
            this.panelalan.Controls.Add(this.ucgencek);
            this.panelalan.Location = new System.Drawing.Point(244, 70);
            this.panelalan.Name = "panelalan";
            this.panelalan.Size = new System.Drawing.Size(200, 77);
            this.panelalan.TabIndex = 2;
            this.panelalan.Visible = false;
            // 
            // karecek
            // 
            this.karecek.AutoSize = true;
            this.karecek.Location = new System.Drawing.Point(32, 26);
            this.karecek.Name = "karecek";
            this.karecek.Size = new System.Drawing.Size(73, 17);
            this.karecek.TabIndex = 1;
            this.karecek.Text = "Kare alanı";
            this.karecek.UseVisualStyleBackColor = true;
            // 
            // ucgencek
            // 
            this.ucgencek.AutoSize = true;
            this.ucgencek.Location = new System.Drawing.Point(32, 3);
            this.ucgencek.Name = "ucgencek";
            this.ucgencek.Size = new System.Drawing.Size(83, 17);
            this.ucgencek.TabIndex = 0;
            this.ucgencek.Text = "Üçgen alanı";
            this.ucgencek.UseVisualStyleBackColor = true;
            this.ucgencek.CheckedChanged += new System.EventHandler(this.ucgencek_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelsayi
            // 
            this.panelsayi.Controls.Add(this.label2);
            this.panelsayi.Controls.Add(this.label1);
            this.panelsayi.Controls.Add(this.sayi2);
            this.panelsayi.Controls.Add(this.sayi1);
            this.panelsayi.Location = new System.Drawing.Point(29, 181);
            this.panelsayi.Name = "panelsayi";
            this.panelsayi.Size = new System.Drawing.Size(200, 78);
            this.panelsayi.TabIndex = 3;
            this.panelsayi.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "sayi2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "sayi1:";
            // 
            // sayi2
            // 
            this.sayi2.Location = new System.Drawing.Point(64, 36);
            this.sayi2.Name = "sayi2";
            this.sayi2.Size = new System.Drawing.Size(100, 20);
            this.sayi2.TabIndex = 1;
            // 
            // sayi1
            // 
            this.sayi1.Location = new System.Drawing.Point(64, 10);
            this.sayi1.Name = "sayi1";
            this.sayi1.Size = new System.Drawing.Size(100, 20);
            this.sayi1.TabIndex = 0;
            // 
            // panelucgenalan
            // 
            this.panelucgenalan.Controls.Add(this.label4);
            this.panelucgenalan.Controls.Add(this.label3);
            this.panelucgenalan.Controls.Add(this.ucgen_taban);
            this.panelucgenalan.Controls.Add(this.ucgen_h);
            this.panelucgenalan.Location = new System.Drawing.Point(276, 159);
            this.panelucgenalan.Name = "panelucgenalan";
            this.panelucgenalan.Size = new System.Drawing.Size(259, 100);
            this.panelucgenalan.TabIndex = 4;
            this.panelucgenalan.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "yükseklik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Taban uzunluğu";
            // 
            // ucgen_taban
            // 
            this.ucgen_taban.Location = new System.Drawing.Point(87, 39);
            this.ucgen_taban.Name = "ucgen_taban";
            this.ucgen_taban.Size = new System.Drawing.Size(100, 20);
            this.ucgen_taban.TabIndex = 1;
            // 
            // ucgen_h
            // 
            this.ucgen_h.Location = new System.Drawing.Point(87, 3);
            this.ucgen_h.Name = "ucgen_h";
            this.ucgen_h.Size = new System.Drawing.Size(100, 20);
            this.ucgen_h.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(409, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 467);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelucgenalan);
            this.Controls.Add(this.panelsayi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelalan);
            this.Controls.Add(this.panel4islem);
            this.Controls.Add(this.alanhesabi);
            this.Controls.Add(this.dortislem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel4islem.ResumeLayout(false);
            this.panel4islem.PerformLayout();
            this.panelalan.ResumeLayout(false);
            this.panelalan.PerformLayout();
            this.panelsayi.ResumeLayout(false);
            this.panelsayi.PerformLayout();
            this.panelucgenalan.ResumeLayout(false);
            this.panelucgenalan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton dortislem;
        private System.Windows.Forms.RadioButton alanhesabi;
        private System.Windows.Forms.Panel panel4islem;
        private System.Windows.Forms.CheckBox cikarmacek;
        private System.Windows.Forms.CheckBox toplamacek;
        private System.Windows.Forms.Panel panelalan;
        private System.Windows.Forms.CheckBox karecek;
        private System.Windows.Forms.CheckBox ucgencek;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox carpmacek;
        private System.Windows.Forms.CheckBox bolmecek;
        private System.Windows.Forms.Panel panelsayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sayi2;
        private System.Windows.Forms.TextBox sayi1;
        private System.Windows.Forms.Panel panelucgenalan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ucgen_taban;
        private System.Windows.Forms.TextBox ucgen_h;
        private System.Windows.Forms.Panel panel1;
    }
}

