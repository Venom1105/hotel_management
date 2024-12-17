namespace THUEPHONG
{
    partial class frmDichVu
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
            this.checkBoxDisabled = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDonGia = new System.Windows.Forms.NumericUpDown();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gridControlDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.disabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenDichVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.donGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripBtnAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnXoa = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnSkip = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkBoxDisabled);
            this.groupControl1.Controls.Add(this.txtID);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.numericUpDownDonGia);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 250);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(641, 115);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Thông tin";
            // 
            // checkBoxDisabled
            // 
            this.checkBoxDisabled.AutoSize = true;
            this.checkBoxDisabled.Location = new System.Drawing.Point(363, 79);
            this.checkBoxDisabled.Name = "checkBoxDisabled";
            this.checkBoxDisabled.Size = new System.Drawing.Size(66, 17);
            this.checkBoxDisabled.TabIndex = 17;
            this.checkBoxDisabled.Text = "Disabled";
            this.checkBoxDisabled.UseVisualStyleBackColor = true;
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
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mã dịch vụ";
            // 
            // numericUpDownDonGia
            // 
            this.numericUpDownDonGia.Location = new System.Drawing.Point(407, 37);
            this.numericUpDownDonGia.Name = "numericUpDownDonGia";
            this.numericUpDownDonGia.Size = new System.Drawing.Size(120, 21);
            this.numericUpDownDonGia.TabIndex = 13;
            this.numericUpDownDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tên dịch vụ";
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
            // gridControlDanhSach
            // 
            this.gridControlDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDanhSach.Location = new System.Drawing.Point(0, 40);
            this.gridControlDanhSach.MainView = this.gridViewDanhSach;
            this.gridControlDanhSach.Name = "gridControlDanhSach";
            this.gridControlDanhSach.Size = new System.Drawing.Size(641, 210);
            this.gridControlDanhSach.TabIndex = 7;
            this.gridControlDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSach});
            // 
            // gridViewDanhSach
            // 
            this.gridViewDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.disabled,
            this.maDichVu,
            this.tenDichVu,
            this.donGia});
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
            // maDichVu
            // 
            this.maDichVu.Caption = "Mã dịch vụ";
            this.maDichVu.FieldName = "IDDichVu";
            this.maDichVu.MaxWidth = 100;
            this.maDichVu.MinWidth = 80;
            this.maDichVu.Name = "maDichVu";
            this.maDichVu.Visible = true;
            this.maDichVu.VisibleIndex = 1;
            this.maDichVu.Width = 100;
            // 
            // tenDichVu
            // 
            this.tenDichVu.Caption = "Tên dịch vụ";
            this.tenDichVu.FieldName = "TenDichVu";
            this.tenDichVu.MaxWidth = 200;
            this.tenDichVu.MinWidth = 150;
            this.tenDichVu.Name = "tenDichVu";
            this.tenDichVu.Visible = true;
            this.tenDichVu.VisibleIndex = 2;
            this.tenDichVu.Width = 200;
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
            this.toolStrip1.Size = new System.Drawing.Size(641, 40);
            this.toolStrip1.TabIndex = 6;
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
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 365);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDichVu";
            this.Text = "Quản lý dịch vụ";
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDonGia;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl gridControlDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn disabled;
        private DevExpress.XtraGrid.Columns.GridColumn maDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn tenDichVu;
        private DevExpress.XtraGrid.Columns.GridColumn donGia;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnXoa;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpdate;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnSkip;
        private System.Windows.Forms.CheckBox checkBoxDisabled;
    }
}