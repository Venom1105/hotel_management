namespace THUEPHONG
{
    partial class frmPhong
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTang = new System.Windows.Forms.ComboBox();
            this.checkBoxTrangThai = new System.Windows.Forms.CheckBox();
            this.comboBoxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbDisabled = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.disabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.trangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenTang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSkip = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.comboBoxTang);
            this.groupControl1.Controls.Add(this.checkBoxTrangThai);
            this.groupControl1.Controls.Add(this.comboBoxLoaiPhong);
            this.groupControl1.Controls.Add(this.txtTenPhong);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.chbDisabled);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 250);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(550, 165);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(92, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(146, 21);
            this.txtID.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mã phòng";
            // 
            // comboBoxTang
            // 
            this.comboBoxTang.FormattingEnabled = true;
            this.comboBoxTang.Location = new System.Drawing.Point(92, 132);
            this.comboBoxTang.Name = "comboBoxTang";
            this.comboBoxTang.Size = new System.Drawing.Size(146, 21);
            this.comboBoxTang.TabIndex = 15;
            // 
            // checkBoxTrangThai
            // 
            this.checkBoxTrangThai.AutoSize = true;
            this.checkBoxTrangThai.Location = new System.Drawing.Point(319, 92);
            this.checkBoxTrangThai.Name = "checkBoxTrangThai";
            this.checkBoxTrangThai.Size = new System.Drawing.Size(82, 17);
            this.checkBoxTrangThai.TabIndex = 14;
            this.checkBoxTrangThai.Text = "Đã sử dụng";
            this.checkBoxTrangThai.UseVisualStyleBackColor = true;
            // 
            // comboBoxLoaiPhong
            // 
            this.comboBoxLoaiPhong.FormattingEnabled = true;
            this.comboBoxLoaiPhong.Location = new System.Drawing.Point(382, 49);
            this.comboBoxLoaiPhong.Name = "comboBoxLoaiPhong";
            this.comboBoxLoaiPhong.Size = new System.Drawing.Size(146, 21);
            this.comboBoxLoaiPhong.TabIndex = 13;
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(92, 91);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(146, 21);
            this.txtTenPhong.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên phòng";
            // 
            // chbDisabled
            // 
            this.chbDisabled.AutoSize = true;
            this.chbDisabled.Location = new System.Drawing.Point(319, 134);
            this.chbDisabled.Name = "chbDisabled";
            this.chbDisabled.Size = new System.Drawing.Size(66, 17);
            this.chbDisabled.TabIndex = 8;
            this.chbDisabled.Text = "Disabled";
            this.chbDisabled.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "LoaiPhong";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tầng";
            // 
            // gridControlDanhSach
            // 
            this.gridControlDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDanhSach.Location = new System.Drawing.Point(0, 40);
            this.gridControlDanhSach.MainView = this.gridViewDanhSach;
            this.gridControlDanhSach.Name = "gridControlDanhSach";
            this.gridControlDanhSach.Size = new System.Drawing.Size(550, 210);
            this.gridControlDanhSach.TabIndex = 5;
            this.gridControlDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSach});
            // 
            // gridViewDanhSach
            // 
            this.gridViewDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.disabled,
            this.maPhong,
            this.tenPhong,
            this.trangThai,
            this.tenTang,
            this.tenLoaiPhong});
            this.gridViewDanhSach.GridControl = this.gridControlDanhSach;
            this.gridViewDanhSach.Name = "gridViewDanhSach";
            this.gridViewDanhSach.OptionsView.ShowGroupPanel = false;
            this.gridViewDanhSach.Click += new System.EventHandler(this.gridViewDanhSach_Click);
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
            // maPhong
            // 
            this.maPhong.Caption = "Mã phòng";
            this.maPhong.FieldName = "IDPhong";
            this.maPhong.MaxWidth = 70;
            this.maPhong.MinWidth = 50;
            this.maPhong.Name = "maPhong";
            this.maPhong.Visible = true;
            this.maPhong.VisibleIndex = 1;
            this.maPhong.Width = 70;
            // 
            // tenPhong
            // 
            this.tenPhong.Caption = "Tên phòng";
            this.tenPhong.FieldName = "TenPhong";
            this.tenPhong.MaxWidth = 100;
            this.tenPhong.MinWidth = 80;
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.Visible = true;
            this.tenPhong.VisibleIndex = 2;
            this.tenPhong.Width = 100;
            // 
            // trangThai
            // 
            this.trangThai.Caption = "Trạng thái";
            this.trangThai.FieldName = "TrangThai";
            this.trangThai.MaxWidth = 80;
            this.trangThai.MinWidth = 50;
            this.trangThai.Name = "trangThai";
            this.trangThai.Visible = true;
            this.trangThai.VisibleIndex = 3;
            this.trangThai.Width = 80;
            // 
            // tenTang
            // 
            this.tenTang.Caption = "Tầng";
            this.tenTang.FieldName = "TenTang";
            this.tenTang.MaxWidth = 100;
            this.tenTang.MinWidth = 80;
            this.tenTang.Name = "tenTang";
            this.tenTang.Visible = true;
            this.tenTang.VisibleIndex = 4;
            this.tenTang.Width = 100;
            // 
            // tenLoaiPhong
            // 
            this.tenLoaiPhong.Caption = "Loại phòng";
            this.tenLoaiPhong.FieldName = "TenLoaiPhong";
            this.tenLoaiPhong.MaxWidth = 100;
            this.tenLoaiPhong.MinWidth = 80;
            this.tenLoaiPhong.Name = "tenLoaiPhong";
            this.tenLoaiPhong.Visible = true;
            this.tenLoaiPhong.VisibleIndex = 5;
            this.tenLoaiPhong.Width = 100;
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
            this.toolStrip1.Size = new System.Drawing.Size(550, 40);
            this.toolStrip1.TabIndex = 4;
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
            this.toolStripBtnAdd.Click += new System.EventHandler(this.toolStripBtnAdd_Click);
            // 
            // toolStripBtnXoa
            // 
            this.toolStripBtnXoa.Image = global::THUEPHONG.Properties.Resources.delete_icon;
            this.toolStripBtnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnXoa.Name = "toolStripBtnXoa";
            this.toolStripBtnXoa.Size = new System.Drawing.Size(31, 37);
            this.toolStripBtnXoa.Text = "Xóa";
            this.toolStripBtnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnXoa.Click += new System.EventHandler(this.toolStripBtnXoa_Click);
            // 
            // toolStripBtnUpdate
            // 
            this.toolStripBtnUpdate.Image = global::THUEPHONG.Properties.Resources.update_icon;
            this.toolStripBtnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnUpdate.Name = "toolStripBtnUpdate";
            this.toolStripBtnUpdate.Size = new System.Drawing.Size(59, 37);
            this.toolStripBtnUpdate.Text = "Cập nhật";
            this.toolStripBtnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnUpdate.Click += new System.EventHandler(this.toolStripBtnUpdate_Click);
            // 
            // toolStripBtnSave
            // 
            this.toolStripBtnSave.Image = global::THUEPHONG.Properties.Resources.save_icon;
            this.toolStripBtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnSave.Name = "toolStripBtnSave";
            this.toolStripBtnSave.Size = new System.Drawing.Size(31, 37);
            this.toolStripBtnSave.Text = "Lưu";
            this.toolStripBtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnSave.Click += new System.EventHandler(this.toolStripBtnSave_Click);
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
            // frmPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 415);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmPhong";
            this.Text = "Quản lý phòng";
            this.Load += new System.EventHandler(this.frmPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbDisabled;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn disabled;
        private DevExpress.XtraGrid.Columns.GridColumn maPhong;
        private DevExpress.XtraGrid.Columns.GridColumn tenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn trangThai;
        private DevExpress.XtraGrid.Columns.GridColumn tenTang;
        private DevExpress.XtraGrid.Columns.GridColumn tenLoaiPhong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnXoa;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpdate;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnSkip;
        private System.Windows.Forms.CheckBox checkBoxTrangThai;
        private System.Windows.Forms.ComboBox comboBoxLoaiPhong;
        private System.Windows.Forms.ComboBox comboBoxTang;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
    }
}