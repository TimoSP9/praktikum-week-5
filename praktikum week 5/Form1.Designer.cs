
namespace praktikum_week_5
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
            this.lbl_data = new System.Windows.Forms.Label();
            this.txtBox_data = new System.Windows.Forms.TextBox();
            this.listB_data = new System.Windows.Forms.ListBox();
            this.Rbtn_merah = new System.Windows.Forms.RadioButton();
            this.Rbtn_biru = new System.Windows.Forms.RadioButton();
            this.lbl_setting = new System.Windows.Forms.Label();
            this.cekB_aktif = new System.Windows.Forms.CheckBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbl_output = new System.Windows.Forms.Label();
            this.lbl_koleksi = new System.Windows.Forms.Label();
            this.lbl_hasil = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_data
            // 
            this.lbl_data.AutoSize = true;
            this.lbl_data.Location = new System.Drawing.Point(51, 63);
            this.lbl_data.Name = "lbl_data";
            this.lbl_data.Size = new System.Drawing.Size(48, 20);
            this.lbl_data.TabIndex = 0;
            this.lbl_data.Text = "Data :";
            // 
            // txtBox_data
            // 
            this.txtBox_data.Location = new System.Drawing.Point(120, 60);
            this.txtBox_data.Name = "txtBox_data";
            this.txtBox_data.Size = new System.Drawing.Size(364, 27);
            this.txtBox_data.TabIndex = 1;
            // 
            // listB_data
            // 
            this.listB_data.FormattingEnabled = true;
            this.listB_data.ItemHeight = 20;
            this.listB_data.Location = new System.Drawing.Point(51, 199);
            this.listB_data.Name = "listB_data";
            this.listB_data.Size = new System.Drawing.Size(196, 304);
            this.listB_data.TabIndex = 2;
            this.listB_data.Click += new System.EventHandler(this.listB_data_Click);
            this.listB_data.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Rbtn_merah
            // 
            this.Rbtn_merah.AutoSize = true;
            this.Rbtn_merah.Location = new System.Drawing.Point(381, 148);
            this.Rbtn_merah.Name = "Rbtn_merah";
            this.Rbtn_merah.Size = new System.Drawing.Size(118, 24);
            this.Rbtn_merah.TabIndex = 3;
            this.Rbtn_merah.TabStop = true;
            this.Rbtn_merah.Text = "Warna Merah";
            this.Rbtn_merah.UseVisualStyleBackColor = true;
            this.Rbtn_merah.CheckedChanged += new System.EventHandler(this.Rbtn_merah_CheckedChanged);
            // 
            // Rbtn_biru
            // 
            this.Rbtn_biru.AutoSize = true;
            this.Rbtn_biru.Location = new System.Drawing.Point(381, 178);
            this.Rbtn_biru.Name = "Rbtn_biru";
            this.Rbtn_biru.Size = new System.Drawing.Size(102, 24);
            this.Rbtn_biru.TabIndex = 4;
            this.Rbtn_biru.TabStop = true;
            this.Rbtn_biru.Text = "Warna Biru";
            this.Rbtn_biru.UseVisualStyleBackColor = true;
            this.Rbtn_biru.CheckedChanged += new System.EventHandler(this.Rbtn_biru_CheckedChanged);
            // 
            // lbl_setting
            // 
            this.lbl_setting.AutoSize = true;
            this.lbl_setting.Location = new System.Drawing.Point(381, 120);
            this.lbl_setting.Name = "lbl_setting";
            this.lbl_setting.Size = new System.Drawing.Size(63, 20);
            this.lbl_setting.TabIndex = 6;
            this.lbl_setting.Text = "Setting :";
            // 
            // cekB_aktif
            // 
            this.cekB_aktif.AutoSize = true;
            this.cekB_aktif.Location = new System.Drawing.Point(450, 118);
            this.cekB_aktif.Name = "cekB_aktif";
            this.cekB_aktif.Size = new System.Drawing.Size(62, 24);
            this.cekB_aktif.TabIndex = 7;
            this.cekB_aktif.Text = "Aktif";
            this.cekB_aktif.UseVisualStyleBackColor = true;
            this.cekB_aktif.CheckedChanged += new System.EventHandler(this.cekB_aktif_CheckedChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(320, 215);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 8;
            // 
            // lbl_output
            // 
            this.lbl_output.AutoSize = true;
            this.lbl_output.Location = new System.Drawing.Point(320, 215);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(62, 20);
            this.lbl_output.TabIndex = 9;
            this.lbl_output.Text = "Output :";
            // 
            // lbl_koleksi
            // 
            this.lbl_koleksi.AutoSize = true;
            this.lbl_koleksi.Location = new System.Drawing.Point(51, 148);
            this.lbl_koleksi.Name = "lbl_koleksi";
            this.lbl_koleksi.Size = new System.Drawing.Size(63, 20);
            this.lbl_koleksi.TabIndex = 10;
            this.lbl_koleksi.Text = "Koleksi :";
            // 
            // lbl_hasil
            // 
            this.lbl_hasil.AutoSize = true;
            this.lbl_hasil.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_hasil.Location = new System.Drawing.Point(361, 279);
            this.lbl_hasil.Name = "lbl_hasil";
            this.lbl_hasil.Size = new System.Drawing.Size(0, 81);
            this.lbl_hasil.TabIndex = 11;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(334, 473);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(299, 29);
            this.btn_clear.TabIndex = 12;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(512, 57);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(94, 29);
            this.btn_add.TabIndex = 13;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.lbl_hasil);
            this.Controls.Add(this.lbl_koleksi);
            this.Controls.Add(this.lbl_output);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.cekB_aktif);
            this.Controls.Add(this.lbl_setting);
            this.Controls.Add(this.Rbtn_biru);
            this.Controls.Add(this.Rbtn_merah);
            this.Controls.Add(this.listB_data);
            this.Controls.Add(this.txtBox_data);
            this.Controls.Add(this.lbl_data);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_data;
        private System.Windows.Forms.TextBox txtBox_data;
        private System.Windows.Forms.ListBox listB_data;
        private System.Windows.Forms.RadioButton Rbtn_merah;
        private System.Windows.Forms.RadioButton Rbtn_biru;
        private System.Windows.Forms.Label lbl_setting;
        private System.Windows.Forms.CheckBox cekB_aktif;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Label lbl_koleksi;
        private System.Windows.Forms.Label lbl_hasil;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
    }
}

