namespace THUEPHONG
{
    partial class frmQlyTang
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
            this.label5 = new System.Windows.Forms.Label();
            this.chbDisabled = new System.Windows.Forms.CheckBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControlDanhSach = new DevExpress.XtraGrid.GridControl();
            this.gridViewDanhSach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.disabled = new DevExpress.XtraGrid.Columns.GridColumn();
            this.maTang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenTang = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.chbDisabled);
            this.groupControl1.Controls.Add(this.txtTen);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 209);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(286, 157);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Thông tin";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(92, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(119, 21);
            this.txtID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ID tầng";
            // 
            // chbDisabled
            // 
            this.chbDisabled.AutoSize = true;
            this.chbDisabled.Location = new System.Drawing.Point(92, 125);
            this.chbDisabled.Name = "chbDisabled";
            this.chbDisabled.Size = new System.Drawing.Size(66, 17);
            this.chbDisabled.TabIndex = 8;
            this.chbDisabled.Text = "Disabled";
            this.chbDisabled.UseVisualStyleBackColor = true;
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(92, 88);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(119, 21);
            this.txtTen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tầng";
            // 
            // gridControlDanhSach
            // 
            this.gridControlDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridControlDanhSach.Location = new System.Drawing.Point(0, 40);
            this.gridControlDanhSach.MainView = this.gridViewDanhSach;
            this.gridControlDanhSach.Name = "gridControlDanhSach";
            this.gridControlDanhSach.Size = new System.Drawing.Size(286, 169);
            this.gridControlDanhSach.TabIndex = 4;
            this.gridControlDanhSach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDanhSach});
            // 
            // gridViewDanhSach
            // 
            this.gridViewDanhSach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.disabled,
            this.maTang,
            this.tenTang});
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
            // maTang
            // 
            this.maTang.Caption = "ID tầng";
            this.maTang.FieldName = "IDTang";
            this.maTang.MaxWidth = 70;
            this.maTang.MinWidth = 50;
            this.maTang.Name = "maTang";
            this.maTang.Visible = true;
            this.maTang.VisibleIndex = 1;
            this.maTang.Width = 70;
            // 
            // tenTang
            // 
            this.tenTang.Caption = "Tên tầng";
            this.tenTang.FieldName = "TenTang";
            this.tenTang.MaxWidth = 100;
            this.tenTang.MinWidth = 80;
            this.tenTang.Name = "tenTang";
            this.tenTang.Visible = true;
            this.tenTang.VisibleIndex = 2;
            this.tenTang.Width = 100;
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
            this.toolStrip1.Size = new System.Drawing.Size(286, 40);
            this.toolStrip1.TabIndex = 3;
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
            // frmQlyTang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 366);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlDanhSach);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmQlyTang";
            this.Text = "Quản lý tầng";
            this.Load += new System.EventHandler(this.frmQlyTang_Load);
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
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chbDisabled;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControlDanhSach;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDanhSach;
        private DevExpress.XtraGrid.Columns.GridColumn disabled;
        private DevExpress.XtraGrid.Columns.GridColumn maTang;
        private DevExpress.XtraGrid.Columns.GridColumn tenTang;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripBtnAdd;
        private System.Windows.Forms.ToolStripButton toolStripBtnXoa;
        private System.Windows.Forms.ToolStripButton toolStripBtnUpdate;
        private System.Windows.Forms.ToolStripButton toolStripBtnSave;
        private System.Windows.Forms.ToolStripButton toolStripBtnSkip;
    }
}