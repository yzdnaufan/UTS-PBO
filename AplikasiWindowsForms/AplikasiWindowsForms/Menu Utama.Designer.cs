﻿namespace AplikasiWindowsForms
{
    partial class MenuUtama
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TambahSiswaButton = new System.Windows.Forms.Button();
            this.TambahKelasButton = new System.Windows.Forms.Button();
            this.HapusButton = new System.Windows.Forms.Button();
            this.SimpanButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.UserLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataSet1 = new AplikasiWindowsForms.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataKelasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataKelasTableAdapter = new AplikasiWindowsForms.DataSet1TableAdapters.DataKelasTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(771, 585);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.TambahSiswaButton);
            this.tabPage1.Controls.Add(this.TambahKelasButton);
            this.tabPage1.Controls.Add(this.HapusButton);
            this.tabPage1.Controls.Add(this.SimpanButton);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(763, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kehadiran";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TambahSiswaButton
            // 
            this.TambahSiswaButton.Location = new System.Drawing.Point(619, 111);
            this.TambahSiswaButton.Name = "TambahSiswaButton";
            this.TambahSiswaButton.Size = new System.Drawing.Size(136, 31);
            this.TambahSiswaButton.TabIndex = 8;
            this.TambahSiswaButton.Text = "Tambah Siswa";
            this.TambahSiswaButton.UseVisualStyleBackColor = true;
            // 
            // TambahKelasButton
            // 
            this.TambahKelasButton.Location = new System.Drawing.Point(619, 69);
            this.TambahKelasButton.Name = "TambahKelasButton";
            this.TambahKelasButton.Size = new System.Drawing.Size(136, 36);
            this.TambahKelasButton.TabIndex = 7;
            this.TambahKelasButton.Text = "Tambah Kelas";
            this.TambahKelasButton.UseVisualStyleBackColor = true;
            this.TambahKelasButton.Click += new System.EventHandler(this.TambahKelasButton_Click);
            // 
            // HapusButton
            // 
            this.HapusButton.Location = new System.Drawing.Point(400, 204);
            this.HapusButton.Name = "HapusButton";
            this.HapusButton.Size = new System.Drawing.Size(90, 34);
            this.HapusButton.TabIndex = 6;
            this.HapusButton.Text = "Hapus";
            this.HapusButton.UseVisualStyleBackColor = true;
            // 
            // SimpanButton
            // 
            this.SimpanButton.Location = new System.Drawing.Point(400, 164);
            this.SimpanButton.Name = "SimpanButton";
            this.SimpanButton.Size = new System.Drawing.Size(90, 34);
            this.SimpanButton.TabIndex = 5;
            this.SimpanButton.Text = "Simpan";
            this.SimpanButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(47, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 355);
            this.dataGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kelas";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.dataKelasBindingSource;
            this.comboBox1.DisplayMember = "NamaKelas";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "IDKelas";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(763, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Laporan";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserLabel,
            this.StatusLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(3, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(757, 25);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // UserLabel
            // 
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(45, 20);
            this.UserLabel.Text = "User :";
            // 
            // StatusLabelUser
            // 
            this.StatusLabelUser.Name = "StatusLabelUser";
            this.StatusLabelUser.Size = new System.Drawing.Size(15, 20);
            this.StatusLabelUser.Text = "-";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataKelasBindingSource
            // 
            this.dataKelasBindingSource.DataMember = "DataKelas";
            this.dataKelasBindingSource.DataSource = this.dataSet1;
            // 
            // dataKelasTableAdapter
            // 
            this.dataKelasTableAdapter.ClearBeforeFill = true;
            // 
            // MenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 585);
            this.Controls.Add(this.tabControl1);
            this.Name = "MenuUtama";
            this.Text = "Menu Utama";
            this.Activated += new System.EventHandler(this.MenuUtama_Activated);
            this.Load += new System.EventHandler(this.MenuUtama_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKelasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button TambahSiswaButton;
        private System.Windows.Forms.Button TambahKelasButton;
        private System.Windows.Forms.Button HapusButton;
        private System.Windows.Forms.Button SimpanButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel UserLabel;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelUser;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataKelasBindingSource;
        private DataSet1TableAdapters.DataKelasTableAdapter dataKelasTableAdapter;
    }
}