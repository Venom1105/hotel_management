namespace THUEPHONG
{
    partial class frmDatPhong
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSkip = new System.Windows.Forms.ToolStripButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.pageDanhSach = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.dateTimePickerDenNgay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTuNgay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlDanhSachdatPhong = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSachDatPhong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pageChiTiet = new DevExpress.XtraTab.XtraTabPage();
            this.Disabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDDatPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayDat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SoNguoiO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDCoSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TheoDoan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.pageDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachdatPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachDatPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBtnAdd,
            this.toolStripBtnXoa,
            this.toolStripBtnUpdate,
            this.toolStripBtnSave,
            this.toolStripBtnSkip});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(856, 40);
            this.toolStrip1.TabIndex = 7;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnAdd
            // 
            this.toolStripBtnAdd.Image = global::THUEPHONG.Properties.Resources.add_icon;
            this.toolStripBtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnAdd.Name = "toolStripBtnAdd";
            this.toolStripBtnAdd.Size = new System.Drawing.Size(41, 37);
            this.toolStripBtnAdd.Text = "Thêm";
            this.toolStripBtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripBtnXoa
            // 
            this.toolStripBtnXoa.Image = global::THUEPHONG.Properties.Resources.delete_icon;
            this.toolStripBtnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnXoa.Name = "toolStripBtnXoa";
            this.toolStripBtnXoa.Size = new System.Drawing.Size(31, 37);
            this.toolStripBtnXoa.Text = "Xóa";
            this.toolStripBtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripBtnUpdate
            // 
            this.toolStripBtnUpdate.Image = global::THUEPHONG.Properties.Resources.update_icon;
            this.toolStripBtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUpdate.Name = "toolStripBtnUpdate";
            this.toolStripBtnUpdate.Size = new System.Drawing.Size(59, 37);
            this.toolStripBtnUpdate.Text = "Cập nhật";
            this.toolStripBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.Image = global::THUEPHONG.Properties.Resources.save_icon;
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(31, 37);
            this.toolStripBtnSave.Text = "Lưu";
            this.toolStripBtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripBtnSkip
            // 
            this.toolStripBtnSkip.Image = global::THUEPHONG.Properties.Resources.skip_icon;
            this.toolStripBtnSkip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSkip.Name = "toolStripBtnSkip";
            this.toolStripBtnSkip.Size = new System.Drawing.Size(48, 37);
            this.toolStripBtnSkip.Text = "Bỏ qua";
            this.toolStripBtnSkip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 40);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.pageDanhSach;
            this.xtraTabControl1.Size = new System.Drawing.Size(856, 423);
            this.xtraTabControl1.TabIndex = 8;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.pageDanhSach,
            this.pageChiTiet});
            // 
            // pageDanhSach
            // 
            this.pageDanhSach.Controls.Add(this.splitContainerControl1);
            this.pageDanhSach.Name = "pageDanhSach";
            this.pageDanhSach.Size = new System.Drawing.Size(854, 398);
            this.pageDanhSach.Text = "Danh sách đặt phòng";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.dateTimePickerDenNgay);
            this.splitContainerControl1.Panel1.Controls.Add(this.dateTimePickerTuNgay);
            this.splitContainerControl1.Panel1.Controls.Add(this.label2);
            this.splitContainerControl1.Panel1.Controls.Add(this.label1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControlDanhSachdatPhong);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(854, 398);
            this.splitContainerControl1.SplitterPosition = 56;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // dateTimePickerDenNgay
            // 
            this.dateTimePickerDenNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDenNgay.Location = new System.Drawing.Point(467, 20);
            this.dateTimePickerDenNgay.Name = "dateTimePickerDenNgay";
            this.dateTimePickerDenNgay.Size = new System.Drawing.Size(101, 21);
            this.dateTimePickerDenNgay.TabIndex = 3;
            // 
            // dateTimePickerTuNgay
            // 
            this.dateTimePickerTuNgay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerTuNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerTuNgay.Location = new System.Drawing.Point(239, 20);
            this.dateTimePickerTuNgay.Name = "dateTimePickerTuNgay";
            this.dateTimePickerTuNgay.Size = new System.Drawing.Size(101, 21);
            this.dateTimePickerTuNgay.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày";
            // 
            // gridControlDanhSachdatPhong
            // 
            this.gridControlDanhSachdatPhong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDanhSachdatPhong.Location = new System.Drawing.Point(0, 0);
            this.gridControlDanhSachdatPhong.MainView = this.gridViewDanhSachDatPhong;
            this.gridControlDanhSachdatPhong.Name = "gridControlDanhSachdatPhong";
            this.gridControlDanhSachdatPhong.Size = new System.Drawing.Size(854, 332);
            this.gridControlDanhSachdatPhong.TabIndex = 0;
            this.gridControlDanhSachdatPhong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSachDatPhong});
            // 
            // gridViewDanhSachDatPhong
            // 
            this.gridViewDanhSachDatPhong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Disabled,
            this.IDDatPhong,
            this.NgayDat,
            this.NgayTra,
            this.SoTien,
            this.SoNguoiO,
            this.IDCoSo,
            this.IDDonVi,
            this.TrangThai,
            this.TheoDoan,
            this.IDKhachHang,
            this.HoTen,
            this.GhiChu});
            this.gridViewDanhSachDatPhong.GridControl = this.gridControlDanhSachdatPhong;
            this.gridViewDanhSachDatPhong.Name = "gridViewDanhSachDatPhong";
            // 
            // pageChiTiet
            // 
            this.pageChiTiet.Name = "pageChiTiet";
            this.pageChiTiet.Size = new System.Drawing.Size(854, 398);
            this.pageChiTiet.Text = "Chi tiết";
            // 
            // Disabled
            // 
            this.Disabled.Caption = "DEL";
            this.Disabled.FieldName = "Disabled";
            this.Disabled.Name = "Disabled";
            this.Disabled.Visible = true;
            this.Disabled.VisibleIndex = 0;
            // 
            // IDDatPhong
            // 
            this.IDDatPhong.Caption = "Số HĐ";
            this.IDDatPhong.FieldName = "IDDatPhong";
            this.IDDatPhong.Name = "IDDatPhong";
            this.IDDatPhong.Visible = true;
            this.IDDatPhong.VisibleIndex = 1;
            // 
            // NgayDat
            // 
            this.NgayDat.Caption = "Ngày đặt";
            this.NgayDat.FieldName = "NgayDat";
            this.NgayDat.Name = "NgayDat";
            this.NgayDat.Visible = true;
            this.NgayDat.VisibleIndex = 2;
            // 
            // NgayTra
            // 
            this.NgayTra.Caption = "Ngày trả";
            this.NgayTra.FieldName = "NgayTra";
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Visible = true;
            this.NgayTra.VisibleIndex = 3;
            // 
            // SoTien
            // 
            this.SoTien.Caption = "Số tiền";
            this.SoTien.FieldName = "SoTien";
            this.SoTien.Name = "SoTien";
            this.SoTien.Visible = true;
            this.SoTien.VisibleIndex = 4;
            // 
            // SoNguoiO
            // 
            this.SoNguoiO.Caption = "Số người";
            this.SoNguoiO.FieldName = "SoNguoiO";
            this.SoNguoiO.Name = "SoNguoiO";
            this.SoNguoiO.Visible = true;
            this.SoNguoiO.VisibleIndex = 5;
            // 
            // IDCoSo
            // 
            this.IDCoSo.Caption = "Mã cơ sở";
            this.IDCoSo.FieldName = "IDCoSo";
            this.IDCoSo.Name = "IDCoSo";
            this.IDCoSo.Visible = true;
            this.IDCoSo.VisibleIndex = 6;
            // 
            // IDDonVi
            // 
            this.IDDonVi.Caption = "Mã đơn vị";
            this.IDDonVi.FieldName = "IDDonVi";
            this.IDDonVi.Name = "IDDonVi";
            this.IDDonVi.Visible = true;
            this.IDDonVi.VisibleIndex = 7;
            // 
            // TrangThai
            // 
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 8;
            // 
            // TheoDoan
            // 
            this.TheoDoan.Caption = "Đoàn";
            this.TheoDoan.FieldName = "TheoDoan";
            this.TheoDoan.Name = "TheoDoan";
            this.TheoDoan.Visible = true;
            this.TheoDoan.VisibleIndex = 9;
            // 
            // IDKhachHang
            // 
            this.IDKhachHang.Caption = "IDKH";
            this.IDKhachHang.FieldName = "IDKhachHang";
            this.IDKhachHang.Name = "IDKhachHang";
            this.IDKhachHang.Visible = true;
            this.IDKhachHang.VisibleIndex = 10;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Khách hàng";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 11;
            // 
            // GhiChu
            // 
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 12;
            // 
            // frmDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 463);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDatPhong";
            this.Text = "Quản lý đặt phòng";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.pageDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSachdatPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSachDatPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnXoa;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpdate;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnSkip;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage pageDanhSach;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.DateTimePicker dateTimePickerDenNgay;
        private System.Windows.Forms.DateTimePicker dateTimePickerTuNgay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraTab.XtraTabPage pageChiTiet;
        private DevExpress.XtraGrid.GridControl gridControlDanhSachdatPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSachDatPhong;
        private DevExpress.XtraGrid.Columns.GridColumn Disabled;
        private DevExpress.XtraGrid.Columns.GridColumn IDDatPhong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayDat;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn SoTien;
        private DevExpress.XtraGrid.Columns.GridColumn SoNguoiO;
        private DevExpress.XtraGrid.Columns.GridColumn IDCoSo;
        private DevExpress.XtraGrid.Columns.GridColumn IDDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn TheoDoan;
        private DevExpress.XtraGrid.Columns.GridColumn IDKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
    }
}