﻿namespace QuanLiPhongKhamNhaKhoa_New
{
    partial class TraCuuBenhNhan
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
            System.Windows.Forms.Label maBNLabel;
            System.Windows.Forms.Label tenBNLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label ngSinhLabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label benhLyLabel;
            System.Windows.Forms.Label gioiTinhLabel;
            System.Windows.Forms.Label soPhieuDVLabel;
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phongKhamNhaKhoaDataSet = new QuanLiPhongKhamNhaKhoa_New.PhongKhamNhaKhoaDataSet();
            this.bENHNHANBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bENHNHANTableAdapter = new QuanLiPhongKhamNhaKhoa_New.PhongKhamNhaKhoaDataSetTableAdapters.BENHNHANTableAdapter();
            this.tableAdapterManager = new QuanLiPhongKhamNhaKhoa_New.PhongKhamNhaKhoaDataSetTableAdapters.TableAdapterManager();
            this.maBNTextBox = new System.Windows.Forms.TextBox();
            this.tenBNTextBox = new System.Windows.Forms.TextBox();
            this.cMNDTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.ngSinhDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.benhLyTextBox = new System.Windows.Forms.TextBox();
            this.gioiTinhRadioButton = new System.Windows.Forms.RadioButton();
            this.soPhieuDVTextBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            maBNLabel = new System.Windows.Forms.Label();
            tenBNLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            diaChiLabel = new System.Windows.Forms.Label();
            ngSinhLabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            benhLyLabel = new System.Windows.Forms.Label();
            gioiTinhLabel = new System.Windows.Forms.Label();
            soPhieuDVLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongKhamNhaKhoaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(177, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(311, 26);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã bệnh nhân";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 48);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tra cứu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(maBNLabel);
            this.groupBox1.Controls.Add(this.maBNTextBox);
            this.groupBox1.Controls.Add(tenBNLabel);
            this.groupBox1.Controls.Add(this.tenBNTextBox);
            this.groupBox1.Controls.Add(cMNDLabel);
            this.groupBox1.Controls.Add(this.cMNDTextBox);
            this.groupBox1.Controls.Add(diaChiLabel);
            this.groupBox1.Controls.Add(this.diaChiTextBox);
            this.groupBox1.Controls.Add(ngSinhLabel);
            this.groupBox1.Controls.Add(this.ngSinhDateTimePicker);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextBox);
            this.groupBox1.Controls.Add(benhLyLabel);
            this.groupBox1.Controls.Add(this.benhLyTextBox);
            this.groupBox1.Controls.Add(gioiTinhLabel);
            this.groupBox1.Controls.Add(this.gioiTinhRadioButton);
            this.groupBox1.Controls.Add(soPhieuDVLabel);
            this.groupBox1.Controls.Add(this.soPhieuDVTextBox);
            this.groupBox1.Location = new System.Drawing.Point(17, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 379);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bệnh nhân";
            // 
            // phongKhamNhaKhoaDataSet
            // 
            this.phongKhamNhaKhoaDataSet.DataSetName = "PhongKhamNhaKhoaDataSet";
            this.phongKhamNhaKhoaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bENHNHANBindingSource
            // 
            this.bENHNHANBindingSource.DataMember = "BENHNHAN";
            this.bENHNHANBindingSource.DataSource = this.phongKhamNhaKhoaDataSet;
            // 
            // bENHNHANTableAdapter
            // 
            this.bENHNHANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BACSITableAdapter = null;
            this.tableAdapterManager.BENHNHANTableAdapter = this.bENHNHANTableAdapter;
            this.tableAdapterManager.CT_DICHVUTableAdapter = null;
            this.tableAdapterManager.DICHVUTableAdapter = null;
            this.tableAdapterManager.LOAIDICHVUTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.PHIEUDICHVUTableAdapter = null;
            this.tableAdapterManager.PHIEUKETQUATableAdapter = null;
            this.tableAdapterManager.PHONGKHAMTableAdapter = null;
            this.tableAdapterManager.TAIKHAMTableAdapter = null;
            this.tableAdapterManager.TIEPDONBNTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanLiPhongKhamNhaKhoa_New.PhongKhamNhaKhoaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // maBNLabel
            // 
            maBNLabel.AutoSize = true;
            maBNLabel.Location = new System.Drawing.Point(6, 35);
            maBNLabel.Name = "maBNLabel";
            maBNLabel.Size = new System.Drawing.Size(61, 20);
            maBNLabel.TabIndex = 0;
            maBNLabel.Text = "Ma BN:";
            // 
            // maBNTextBox
            // 
            this.maBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "MaBN", true));
            this.maBNTextBox.Location = new System.Drawing.Point(116, 32);
            this.maBNTextBox.Name = "maBNTextBox";
            this.maBNTextBox.Size = new System.Drawing.Size(337, 26);
            this.maBNTextBox.TabIndex = 1;
            // 
            // tenBNLabel
            // 
            tenBNLabel.AutoSize = true;
            tenBNLabel.Location = new System.Drawing.Point(6, 67);
            tenBNLabel.Name = "tenBNLabel";
            tenBNLabel.Size = new System.Drawing.Size(66, 20);
            tenBNLabel.TabIndex = 2;
            tenBNLabel.Text = "Ten BN:";
            // 
            // tenBNTextBox
            // 
            this.tenBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "TenBN", true));
            this.tenBNTextBox.Location = new System.Drawing.Point(116, 64);
            this.tenBNTextBox.Name = "tenBNTextBox";
            this.tenBNTextBox.Size = new System.Drawing.Size(337, 26);
            this.tenBNTextBox.TabIndex = 3;
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(6, 99);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(60, 20);
            cMNDLabel.TabIndex = 4;
            cMNDLabel.Text = "CMND:";
            // 
            // cMNDTextBox
            // 
            this.cMNDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "CMND", true));
            this.cMNDTextBox.Location = new System.Drawing.Point(116, 96);
            this.cMNDTextBox.Name = "cMNDTextBox";
            this.cMNDTextBox.Size = new System.Drawing.Size(337, 26);
            this.cMNDTextBox.TabIndex = 5;
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(6, 131);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(64, 20);
            diaChiLabel.TabIndex = 6;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(116, 128);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(337, 26);
            this.diaChiTextBox.TabIndex = 7;
            // 
            // ngSinhLabel
            // 
            ngSinhLabel.AutoSize = true;
            ngSinhLabel.Location = new System.Drawing.Point(6, 164);
            ngSinhLabel.Name = "ngSinhLabel";
            ngSinhLabel.Size = new System.Drawing.Size(69, 20);
            ngSinhLabel.TabIndex = 8;
            ngSinhLabel.Text = "Ng Sinh:";
            // 
            // ngSinhDateTimePicker
            // 
            this.ngSinhDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bENHNHANBindingSource, "NgSinh", true));
            this.ngSinhDateTimePicker.Location = new System.Drawing.Point(116, 160);
            this.ngSinhDateTimePicker.Name = "ngSinhDateTimePicker";
            this.ngSinhDateTimePicker.Size = new System.Drawing.Size(337, 26);
            this.ngSinhDateTimePicker.TabIndex = 9;
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(6, 195);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(45, 20);
            sDTLabel.TabIndex = 10;
            sDTLabel.Text = "SDT:";
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(116, 192);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(337, 26);
            this.sDTTextBox.TabIndex = 11;
            // 
            // benhLyLabel
            // 
            benhLyLabel.AutoSize = true;
            benhLyLabel.Location = new System.Drawing.Point(6, 227);
            benhLyLabel.Name = "benhLyLabel";
            benhLyLabel.Size = new System.Drawing.Size(71, 20);
            benhLyLabel.TabIndex = 12;
            benhLyLabel.Text = "Benh Ly:";
            // 
            // benhLyTextBox
            // 
            this.benhLyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "BenhLy", true));
            this.benhLyTextBox.Location = new System.Drawing.Point(116, 224);
            this.benhLyTextBox.Name = "benhLyTextBox";
            this.benhLyTextBox.Size = new System.Drawing.Size(337, 26);
            this.benhLyTextBox.TabIndex = 13;
            // 
            // gioiTinhLabel
            // 
            gioiTinhLabel.AutoSize = true;
            gioiTinhLabel.Location = new System.Drawing.Point(6, 262);
            gioiTinhLabel.Name = "gioiTinhLabel";
            gioiTinhLabel.Size = new System.Drawing.Size(75, 20);
            gioiTinhLabel.TabIndex = 14;
            gioiTinhLabel.Text = "Gioi Tinh:";
            // 
            // gioiTinhRadioButton
            // 
            this.gioiTinhRadioButton.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bENHNHANBindingSource, "GioiTinh", true));
            this.gioiTinhRadioButton.Location = new System.Drawing.Point(116, 256);
            this.gioiTinhRadioButton.Name = "gioiTinhRadioButton";
            this.gioiTinhRadioButton.Size = new System.Drawing.Size(337, 24);
            this.gioiTinhRadioButton.TabIndex = 15;
            this.gioiTinhRadioButton.TabStop = true;
            this.gioiTinhRadioButton.Text = "Nam";
            this.gioiTinhRadioButton.UseVisualStyleBackColor = true;
            // 
            // soPhieuDVLabel
            // 
            soPhieuDVLabel.AutoSize = true;
            soPhieuDVLabel.Location = new System.Drawing.Point(6, 291);
            soPhieuDVLabel.Name = "soPhieuDVLabel";
            soPhieuDVLabel.Size = new System.Drawing.Size(104, 20);
            soPhieuDVLabel.TabIndex = 16;
            soPhieuDVLabel.Text = "So Phieu DV:";
            // 
            // soPhieuDVTextBox
            // 
            this.soPhieuDVTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bENHNHANBindingSource, "SoPhieuDV", true));
            this.soPhieuDVTextBox.Location = new System.Drawing.Point(116, 288);
            this.soPhieuDVTextBox.Name = "soPhieuDVTextBox";
            this.soPhieuDVTextBox.Size = new System.Drawing.Size(337, 26);
            this.soPhieuDVTextBox.TabIndex = 17;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(277, 257);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(54, 24);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Nữ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // TraCuuBenhNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 507);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "TraCuuBenhNhan";
            this.Text = "TraCuuBenhNhan";
            this.Load += new System.EventHandler(this.TraCuuBenhNhan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phongKhamNhaKhoaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bENHNHANBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private PhongKhamNhaKhoaDataSet phongKhamNhaKhoaDataSet;
        private System.Windows.Forms.BindingSource bENHNHANBindingSource;
        private PhongKhamNhaKhoaDataSetTableAdapters.BENHNHANTableAdapter bENHNHANTableAdapter;
        private PhongKhamNhaKhoaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox maBNTextBox;
        private System.Windows.Forms.TextBox tenBNTextBox;
        private System.Windows.Forms.TextBox cMNDTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.DateTimePicker ngSinhDateTimePicker;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox benhLyTextBox;
        private System.Windows.Forms.RadioButton gioiTinhRadioButton;
        private System.Windows.Forms.TextBox soPhieuDVTextBox;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}