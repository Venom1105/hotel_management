﻿namespace THUEPHONG
{
    partial class frmLoaiPhong
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.numericUpDownSoGiuong = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDonGia = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbDisabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.disabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.donGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soNguoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soGiuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAddCoSo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnXoaCoSo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUpdateCoSo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSaveCoSo = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSkip = new System.Windows.Forms.ToolStripButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoGiuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.numericUpDownSoGiuong);
            this.groupControl1.Controls.Add(this.numericUpDownDonGia);
            this.groupControl1.Controls.Add(this.numericUpDownSoNguoi);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.chbDisabled);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 250);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(709, 160);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin";
            // 
            // numericUpDownSoGiuong
            // 
            this.numericUpDownSoGiuong.Location = new System.Drawing.Point(407, 81);
            this.numericUpDownSoGiuong.Name = "numericUpDownSoGiuong";
            this.numericUpDownSoGiuong.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownSoGiuong.TabIndex = 14;
            this.numericUpDownSoGiuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownDonGia
            // 
            this.numericUpDownDonGia.Location = new System.Drawing.Point(407, 37);
            this.numericUpDownDonGia.Name = "numericUpDownDonGia";
            this.numericUpDownDonGia.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownDonGia.TabIndex = 13;
            this.numericUpDownDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // numericUpDownSoNguoi
            // 
            this.numericUpDownSoNguoi.Location = new System.Drawing.Point(121, 119);
            this.numericUpDownSoNguoi.Name = "numericUpDownSoNguoi";
            this.numericUpDownSoNguoi.Size = new System.Drawing.Size(109, 21);
            this.numericUpDownSoNguoi.TabIndex = 12;
            this.numericUpDownSoNguoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(121, 77);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(154, 21);
            this.txtTen.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên loại phòng";
            // 
            // chbDisabled
            // 
            this.chbDisabled.AutoSize = true;
            this.chbDisabled.Location = new System.Drawing.Point(398, 121);
            this.chbDisabled.Name = "chbDisabled";
            this.chbDisabled.Size = new System.Drawing.Size(66, 17);
            this.chbDisabled.TabIndex = 8;
            this.chbDisabled.Text = "Disabled";
            this.chbDisabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số giường";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số người";
            // 
            // gridControlDanhSach
            // 
            this.gridControlDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDanhSach.Location = new System.Drawing.Point(0, 40);
            this.gridControlDanhSach.MainView = this.gridViewDanhSach;
            this.gridControlDanhSach.Name = "gridControlDanhSach";
            this.gridControlDanhSach.Size = new System.Drawing.Size(709, 210);
            this.gridControlDanhSach.TabIndex = 4;
            this.gridControlDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSach});
            // 
            // gridViewDanhSach
            // 
            this.gridViewDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.disabled,
            this.maLoaiPhong,
            this.tenLoaiPhong,
            this.donGia,
            this.soNguoi,
            this.soGiuong});
            this.gridViewDanhSach.GridControl = this.gridControlDanhSach;
            this.gridViewDanhSach.Name = "gridViewDanhSach";
            this.gridViewDanhSach.OptionsView.ShowGroupPanel = false;
            // 
            // disabled
            // 
            this.disabled.Caption = "Del";
            this.disabled.FieldName = "Disabled";
            this.disabled.MaxWidth = 35;
            this.disabled.Name = "disabled";
            this.disabled.Visible = true;
            this.disabled.VisibleIndex = 0;
            this.disabled.Width = 35;
            // 
            // maLoaiPhong
            // 
            this.maLoaiPhong.Caption = "Mã loại phòng";
            this.maLoaiPhong.FieldName = "IDLoaiPhong";
            this.maLoaiPhong.MaxWidth = 100;
            this.maLoaiPhong.MinWidth = 80;
            this.maLoaiPhong.Name = "maLoaiPhong";
            this.maLoaiPhong.Visible = true;
            this.maLoaiPhong.VisibleIndex = 1;
            this.maLoaiPhong.Width = 100;
            // 
            // tenLoaiPhong
            // 
            this.tenLoaiPhong.Caption = "Tên loại phòng";
            this.tenLoaiPhong.FieldName = "TenLoaiPhong";
            this.tenLoaiPhong.MaxWidth = 200;
            this.tenLoaiPhong.MinWidth = 150;
            this.tenLoaiPhong.Name = "tenLoaiPhong";
            this.tenLoaiPhong.Visible = true;
            this.tenLoaiPhong.VisibleIndex = 2;
            this.tenLoaiPhong.Width = 200;
            // 
            // donGia
            // 
            this.donGia.Caption = "Đơn giá";
            this.donGia.FieldName = "DonGia";
            this.donGia.MaxWidth = 80;
            this.donGia.MinWidth = 50;
            this.donGia.Name = "donGia";
            this.donGia.Visible = true;
            this.donGia.VisibleIndex = 3;
            this.donGia.Width = 80;
            // 
            // soNguoi
            // 
            this.soNguoi.Caption = "Số người ở";
            this.soNguoi.FieldName = "SoNguoiO";
            this.soNguoi.MaxWidth = 80;
            this.soNguoi.MinWidth = 50;
            this.soNguoi.Name = "soNguoi";
            this.soNguoi.Visible = true;
            this.soNguoi.VisibleIndex = 4;
            this.soNguoi.Width = 80;
            // 
            // soGiuong
            // 
            this.soGiuong.Caption = "Số giường";
            this.soGiuong.FieldName = "SoGiuong";
            this.soGiuong.MaxWidth = 80;
            this.soGiuong.MinWidth = 50;
            this.soGiuong.Name = "soGiuong";
            this.soGiuong.Visible = true;
            this.soGiuong.VisibleIndex = 5;
            this.soGiuong.Width = 80;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAddCoSo,
            this.toolStripBtnXoaCoSo,
            this.toolStripBtnUpdateCoSo,
            this.toolStripBtnSaveCoSo,
            this.toolStripBtnSkip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 40);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAddCoSo
            // 
            this.toolStripBtnAddCoSo.Image = global::THUEPHONG.Properties.Resources.add_icon;
            this.toolStripBtnAddCoSo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAddCoSo.Name = "toolStripBtnAddCoSo";
            this.toolStripBtnAddCoSo.Size = new System.Drawing.Size(41, 37);
            this.toolStripBtnAddCoSo.Text = "Thêm";
            this.toolStripBtnAddCoSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnAddCoSo.Click += new System.EventHandler(this.toolStripBtnAddCoSo_Click);
            // 
            // toolStripBtnXoaCoSo
            // 
            this.toolStripBtnXoaCoSo.Image = global::THUEPHONG.Properties.Resources.delete_icon;
            this.toolStripBtnXoaCoSo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnXoaCoSo.Name = "toolStripBtnXoaCoSo";
            this.toolStripBtnXoaCoSo.Size = new System.Drawing.Size(31, 37);
            this.toolStripBtnXoaCoSo.Text = "Xóa";
            this.toolStripBtnXoaCoSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnXoaCoSo.Click += new System.EventHandler(this.toolStripBtnXoaCoSo_Click);
            // 
            // toolStripBtnUpdateCoSo
            // 
            this.toolStripBtnUpdateCoSo.Image = global::THUEPHONG.Properties.Resources.update_icon;
            this.toolStripBtnUpdateCoSo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUpdateCoSo.Name = "toolStripBtnUpdateCoSo";
            this.toolStripBtnUpdateCoSo.Size = new System.Drawing.Size(59, 37);
            this.toolStripBtnUpdateCoSo.Text = "Cập nhật";
            this.toolStripBtnUpdateCoSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnUpdateCoSo.Click += new System.EventHandler(this.toolStripBtnUpdateCoSo_Click);
            // 
            // toolStripBtnSaveCoSo
            // 
            this.toolStripBtnSaveCoSo.Image = global::THUEPHONG.Properties.Resources.save_icon;
            this.toolStripBtnSaveCoSo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSaveCoSo.Name = "toolStripBtnSaveCoSo";
            this.toolStripBtnSaveCoSo.Size = new System.Drawing.Size(31, 37);
            this.toolStripBtnSaveCoSo.Text = "Lưu";
            this.toolStripBtnSaveCoSo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSaveCoSo.Click += new System.EventHandler(this.toolStripBtnSaveCoSo_Click);
            // 
            // toolStripBtnSkip
            // 
            this.toolStripBtnSkip.Image = global::THUEPHONG.Properties.Resources.skip_icon;
            this.toolStripBtnSkip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSkip.Name = "toolStripBtnSkip";
            this.toolStripBtnSkip.Size = new System.Drawing.Size(48, 37);
            this.toolStripBtnSkip.Text = "Bỏ qua";
            this.toolStripBtnSkip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSkip.Click += new System.EventHandler(this.toolStripBtnSkip_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(121, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(154, 21);
            this.txtID.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã loại phòng";
            // 
            // frmLoaiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 410);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmLoaiPhong";
            this.Text = "Danh mục loại phòng";
            this.Load += new System.EventHandler(this.frmLoaiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoGiuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbDisabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn disabled;
        private DevExpress.XtraGrid.Columns.GridColumn maLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn tenLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn donGia;
        private DevExpress.XtraGrid.Columns.GridColumn soNguoi;
        private DevExpress.XtraGrid.Columns.GridColumn soGiuong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAddCoSo;
        private System.Windows.Forms.ToolStripButton toolStripBtnXoaCoSo;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpdateCoSo;
        private System.Windows.Forms.ToolStripButton toolStripBtnSaveCoSo;
        private System.Windows.Forms.ToolStripButton toolStripBtnSkip;
        private System.Windows.Forms.NumericUpDown numericUpDownSoGiuong;
        private System.Windows.Forms.NumericUpDown numericUpDownDonGia;
        private System.Windows.Forms.NumericUpDown numericUpDownSoNguoi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
    }
}