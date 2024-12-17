namespace THUEPHONG
{
    partial class frmThietBiPhong
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
            this.comboBoxTenPhong = new System.Windows.Forms.ComboBox();
            this.comboBoxTenThietBi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenThietBi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSkip = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSoLuong = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.numericUpDownSoLuong);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.comboBoxTenPhong);
            this.groupControl1.Controls.Add(this.comboBoxTenThietBi);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 250);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(481, 131);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "Thông tin";
            // 
            // comboBoxTenPhong
            // 
            this.comboBoxTenPhong.FormattingEnabled = true;
            this.comboBoxTenPhong.Location = new System.Drawing.Point(103, 42);
            this.comboBoxTenPhong.Name = "comboBoxTenPhong";
            this.comboBoxTenPhong.Size = new System.Drawing.Size(118, 21);
            this.comboBoxTenPhong.TabIndex = 15;
            // 
            // comboBoxTenThietBi
            // 
            this.comboBoxTenThietBi.FormattingEnabled = true;
            this.comboBoxTenThietBi.Location = new System.Drawing.Point(103, 90);
            this.comboBoxTenThietBi.Name = "comboBoxTenThietBi";
            this.comboBoxTenThietBi.Size = new System.Drawing.Size(194, 21);
            this.comboBoxTenThietBi.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên thiết bị";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên phòng";
            // 
            // gridControlDanhSach
            // 
            this.gridControlDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDanhSach.Location = new System.Drawing.Point(0, 40);
            this.gridControlDanhSach.MainView = this.gridViewDanhSach;
            this.gridControlDanhSach.Name = "gridControlDanhSach";
            this.gridControlDanhSach.Size = new System.Drawing.Size(481, 210);
            this.gridControlDanhSach.TabIndex = 8;
            this.gridControlDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSach});
            // 
            // gridViewDanhSach
            // 
            this.gridViewDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tenPhong,
            this.tenThietBi,
            this.soLuong});
            this.gridViewDanhSach.GridControl = this.gridControlDanhSach;
            this.gridViewDanhSach.Name = "gridViewDanhSach";
            this.gridViewDanhSach.OptionsView.ShowGroupPanel = false;
            this.gridViewDanhSach.Click += new System.EventHandler(this.gridViewDanhSach_Click);
            // 
            // tenPhong
            // 
            this.tenPhong.Caption = "Tên phòng";
            this.tenPhong.FieldName = "TenPhong";
            this.tenPhong.MaxWidth = 100;
            this.tenPhong.MinWidth = 80;
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.Visible = true;
            this.tenPhong.VisibleIndex = 0;
            this.tenPhong.Width = 100;
            // 
            // tenThietBi
            // 
            this.tenThietBi.Caption = "Tên thiết bị";
            this.tenThietBi.FieldName = "TenThietBi";
            this.tenThietBi.MaxWidth = 200;
            this.tenThietBi.MinWidth = 150;
            this.tenThietBi.Name = "tenThietBi";
            this.tenThietBi.Visible = true;
            this.tenThietBi.VisibleIndex = 1;
            this.tenThietBi.Width = 200;
            // 
            // soLuong
            // 
            this.soLuong.Caption = "Số lượng";
            this.soLuong.FieldName = "SoLuong";
            this.soLuong.MaxWidth = 100;
            this.soLuong.MinWidth = 80;
            this.soLuong.Name = "soLuong";
            this.soLuong.Visible = true;
            this.soLuong.VisibleIndex = 2;
            this.soLuong.Width = 100;
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
            this.toolStrip1.Size = new System.Drawing.Size(481, 40);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số lượng";
            // 
            // numericUpDownSoLuong
            // 
            this.numericUpDownSoLuong.Location = new System.Drawing.Point(364, 40);
            this.numericUpDownSoLuong.Name = "numericUpDownSoLuong";
            this.numericUpDownSoLuong.Size = new System.Drawing.Size(76, 21);
            this.numericUpDownSoLuong.TabIndex = 17;
            this.numericUpDownSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmThietBiPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 381);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmThietBiPhong";
            this.Text = "Quản lý thiết bị theo phòng";
            this.Load += new System.EventHandler(this.frmThietBiPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBoxTenPhong;
        private System.Windows.Forms.ComboBox comboBoxTenThietBi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn tenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn tenThietBi;
        private DevExpress.XtraGrid.Columns.GridColumn soLuong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnXoa;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpdate;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnSkip;
        private System.Windows.Forms.NumericUpDown numericUpDownSoLuong;
        private System.Windows.Forms.Label label2;
    }
}