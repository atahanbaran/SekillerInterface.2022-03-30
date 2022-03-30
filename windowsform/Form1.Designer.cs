namespace windowsform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.tbGenislik = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbYaricap = new System.Windows.Forms.TextBox();
            this.bHesapla = new System.Windows.Forms.Button();
            this.ddlSekil = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbAlan = new System.Windows.Forms.RadioButton();
            this.rbCevre = new System.Windows.Forms.RadioButton();
            this.tbSonuc = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbPiucmu = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tbYukseklik);
            this.panel1.Controls.Add(this.tbGenislik);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 79);
            this.panel1.TabIndex = 0;
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(75, 43);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(141, 23);
            this.tbYukseklik.TabIndex = 5;
            // 
            // tbGenislik
            // 
            this.tbGenislik.Location = new System.Drawing.Point(75, 14);
            this.tbGenislik.Name = "tbGenislik";
            this.tbGenislik.Size = new System.Drawing.Size(141, 23);
            this.tbGenislik.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yukseklik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Genislik";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Yaricap";
            // 
            // tbYaricap
            // 
            this.tbYaricap.Location = new System.Drawing.Point(77, 6);
            this.tbYaricap.Name = "tbYaricap";
            this.tbYaricap.Size = new System.Drawing.Size(141, 23);
            this.tbYaricap.TabIndex = 5;
            // 
            // bHesapla
            // 
            this.bHesapla.Location = new System.Drawing.Point(12, 182);
            this.bHesapla.Name = "bHesapla";
            this.bHesapla.Size = new System.Drawing.Size(75, 23);
            this.bHesapla.TabIndex = 6;
            this.bHesapla.Text = "Hesapla";
            this.bHesapla.UseVisualStyleBackColor = true;
            this.bHesapla.Click += new System.EventHandler(this.bHesapla_Click);
            // 
            // ddlSekil
            // 
            this.ddlSekil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlSekil.FormattingEnabled = true;
            this.ddlSekil.Location = new System.Drawing.Point(49, 6);
            this.ddlSekil.Name = "ddlSekil";
            this.ddlSekil.Size = new System.Drawing.Size(183, 23);
            this.ddlSekil.TabIndex = 1;
            this.ddlSekil.SelectedIndexChanged += new System.EventHandler(this.ddlSekil_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Şekil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hesap";
            // 
            // rbAlan
            // 
            this.rbAlan.AutoSize = true;
            this.rbAlan.Checked = true;
            this.rbAlan.Location = new System.Drawing.Point(58, 30);
            this.rbAlan.Name = "rbAlan";
            this.rbAlan.Size = new System.Drawing.Size(49, 19);
            this.rbAlan.TabIndex = 2;
            this.rbAlan.TabStop = true;
            this.rbAlan.Text = "Alan";
            this.rbAlan.UseVisualStyleBackColor = true;
            this.rbAlan.CheckedChanged += new System.EventHandler(this.rbAlan_CheckedChanged);
            // 
            // rbCevre
            // 
            this.rbCevre.AutoSize = true;
            this.rbCevre.Location = new System.Drawing.Point(113, 30);
            this.rbCevre.Name = "rbCevre";
            this.rbCevre.Size = new System.Drawing.Size(55, 19);
            this.rbCevre.TabIndex = 3;
            this.rbCevre.Text = "Cevre";
            this.rbCevre.UseVisualStyleBackColor = true;
            // 
            // tbSonuc
            // 
            this.tbSonuc.Location = new System.Drawing.Point(93, 182);
            this.tbSonuc.Name = "tbSonuc";
            this.tbSonuc.ReadOnly = true;
            this.tbSonuc.Size = new System.Drawing.Size(147, 23);
            this.tbSonuc.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbYaricap);
            this.panel2.Location = new System.Drawing.Point(12, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 36);
            this.panel2.TabIndex = 8;
            // 
            // cbPiucmu
            // 
            this.cbPiucmu.AutoSize = true;
            this.cbPiucmu.Location = new System.Drawing.Point(170, 33);
            this.cbPiucmu.Name = "cbPiucmu";
            this.cbPiucmu.Size = new System.Drawing.Size(74, 19);
            this.cbPiucmu.TabIndex = 9;
            this.cbPiucmu.Text = "Pi 3 Mü ?";
            this.cbPiucmu.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(285, 217);
            this.Controls.Add(this.cbPiucmu);
            this.Controls.Add(this.tbSonuc);
            this.Controls.Add(this.rbCevre);
            this.Controls.Add(this.rbAlan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ddlSekil);
            this.Controls.Add(this.bHesapla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Şekil App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TextBox tbYukseklik;
        private TextBox tbGenislik;
        private Label label2;
        private Label label1;
        private Button bHesapla;
        private ComboBox ddlSekil;
        private Label label3;
        private Label label4;
        private RadioButton rbAlan;
        private RadioButton rbCevre;
        private TextBox tbSonuc;
        private Label label5;
        private TextBox tbYaricap;
        private Panel panel2;
        private CheckBox cbPiucmu;
    }
}