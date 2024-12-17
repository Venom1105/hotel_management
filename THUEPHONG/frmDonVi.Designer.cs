namespace THUEPHONG
{
    partial class frmDonVi
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
            this.toolStripBtnExit = new System.Windows.Forms.ToolStripButton();
            this.gridControlDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.disabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maDonVi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenCoSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dienThoai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maCoSo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBoxCoSo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIDDonVi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chbDisabled = new System.Windows.Forms.CheckBox();
            this.txtDienThoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenDonVi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
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
            this.toolStripBtnSkip,
            this.toolStripBtnExit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(769, 40);
            this.toolStrip1.TabIndex = 1;
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
            // toolStripBtnExit
            // 
            this.toolStripBtnExit.Image = global::THUEPHONG.Properties.Resources.exit_icon;
            this.toolStripBtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnExit.Name = "toolStripBtnExit";
            this.toolStripBtnExit.Size = new System.Drawing.Size(41, 37);
            this.toolStripBtnExit.Text = "Thoát";
            this.toolStripBtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripBtnExit.Click += new System.EventHandler(this.toolStripBtnExit_Click);
            // 
            // gridControlDanhSach
            // 
            this.gridControlDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDanhSach.Location = new System.Drawing.Point(0, 40);
            this.gridControlDanhSach.MainView = this.gridViewDanhSach;
            this.gridControlDanhSach.Name = "gridControlDanhSach";
            this.gridControlDanhSach.Size = new System.Drawing.Size(769, 210);
            this.gridControlDanhSach.TabIndex = 2;
            this.gridControlDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSach});
            // 
            // gridViewDanhSach
            // 
            this.gridViewDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.disabled,
            this.maDonVi,
            this.tenCoSo,
            this.dienThoai,
            this.email,
            this.diaChi,
            this.maCoSo});
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
            this.disabled.Width = 30;
            // 
            // maDonVi
            // 
            this.maDonVi.Caption = "Mã đơn vị";
            this.maDonVi.FieldName = "IDDonVI";
            this.maDonVi.MaxWidth = 70;
            this.maDonVi.MinWidth = 50;
            this.maDonVi.Name = "maDonVi";
            this.maDonVi.Visible = true;
            this.maDonVi.VisibleIndex = 1;
            this.maDonVi.Width = 70;
            // 
            // tenCoSo
            // 
            this.tenCoSo.Caption = "Tên đơn vị";
            this.tenCoSo.FieldName = "TenDonVi";
            this.tenCoSo.MaxWidth = 200;
            this.tenCoSo.MinWidth = 150;
            this.tenCoSo.Name = "tenCoSo";
            this.tenCoSo.Visible = true;
            this.tenCoSo.VisibleIndex = 2;
            this.tenCoSo.Width = 200;
            // 
            // dienThoai
            // 
            this.dienThoai.Caption = "Điện thoại";
            this.dienThoai.FieldName = "DienThoai";
            this.dienThoai.MaxWidth = 100;
            this.dienThoai.MinWidth = 80;
            this.dienThoai.Name = "dienThoai";
            this.dienThoai.Visible = true;
            this.dienThoai.VisibleIndex = 3;
            this.dienThoai.Width = 80;
            // 
            // email
            // 
            this.email.Caption = "Email";
            this.email.FieldName = "Email";
            this.email.MaxWidth = 200;
            this.email.MinWidth = 150;
            this.email.Name = "email";
            this.email.Visible = true;
            this.email.VisibleIndex = 4;
            this.email.Width = 150;
            // 
            // diaChi
            // 
            this.diaChi.Caption = "Địa chỉ";
            this.diaChi.FieldName = "DiaChi";
            this.diaChi.MaxWidth = 200;
            this.diaChi.MinWidth = 150;
            this.diaChi.Name = "diaChi";
            this.diaChi.Visible = true;
            this.diaChi.VisibleIndex = 5;
            this.diaChi.Width = 200;
            // 
            // maCoSo
            // 
            this.maCoSo.Caption = "Mã cơ sở";
            this.maCoSo.FieldName = "IDCoSo";
            this.maCoSo.MaxWidth = 70;
            this.maCoSo.MinWidth = 50;
            this.maCoSo.Name = "maCoSo";
            this.maCoSo.Width = 50;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.comboBoxCoSo);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.txtIDDonVi);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.chbDisabled);
            this.groupControl1.Controls.Add(this.txtDienThoai);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtDiaChi);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txtEmail);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtTenDonVi);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 250);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(769, 167);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Thông tin";
            // 
            // comboBoxCoSo
            // 
            this.comboBoxCoSo.FormattingEnabled = true;
            this.comboBoxCoSo.Location = new System.Drawing.Point(477, 130);
            this.comboBoxCoSo.Name = "comboBoxCoSo";
            this.comboBoxCoSo.Size = new System.Drawing.Size(250, 21);
            this.comboBoxCoSo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cơ sở / Chi nhánh";
            // 
            // txtIDDonVi
            // 
            this.txtIDDonVi.Location = new System.Drawing.Point(92, 49);
            this.txtIDDonVi.Name = "txtIDDonVi";
            this.txtIDDonVi.Size = new System.Drawing.Size(238, 21);
            this.txtIDDonVi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã đơn vị";
            // 
            // chbDisabled
            // 
            this.chbDisabled.AutoSize = true;
            this.chbDisabled.Location = new System.Drawing.Point(661, 51);
            this.chbDisabled.Name = "chbDisabled";
            this.chbDisabled.Size = new System.Drawing.Size(66, 17);
            this.chbDisabled.TabIndex = 8;
            this.chbDisabled.Text = "Disabled";
            this.chbDisabled.UseVisualStyleBackColor = true;
            // 
            // txtDienThoai
            // 
            this.txtDienThoai.Location = new System.Drawing.Point(477, 49);
            this.txtDienThoai.Name = "txtDienThoai";
            this.txtDienThoai.Size = new System.Drawing.Size(155, 21);
            this.txtDienThoai.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Số điện thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(92, 128);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(238, 21);
            this.txtDiaChi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(477, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 21);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(440, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // txtTenDonVi
            // 
            this.txtTenDonVi.Location = new System.Drawing.Point(92, 88);
            this.txtTenDonVi.Name = "txtTenDonVi";
            this.txtTenDonVi.Size = new System.Drawing.Size(238, 21);
            this.txtTenDonVi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đơn vị";
            // 
            // frmDonVi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 417);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmDonVi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh mục đơn vị";
            this.Load += new System.EventHandler(this.frmDonVi_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDanhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripBtnExit;
        private DevExpress.XtraGrid.GridControl gridControlDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn disabled;
        private DevExpress.XtraGrid.Columns.GridColumn maDonVi;
        private DevExpress.XtraGrid.Columns.GridColumn tenCoSo;
        private DevExpress.XtraGrid.Columns.GridColumn dienThoai;
        private DevExpress.XtraGrid.Columns.GridColumn email;
        private DevExpress.XtraGrid.Columns.GridColumn diaChi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txtIDDonVi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbDisabled;
        private System.Windows.Forms.TextBox txtDienThoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDonVi;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn maCoSo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCoSo;
    }
}