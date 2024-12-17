using BusinessLayer;
using DataLayer;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmPhong()
        {
            InitializeComponent();
        }

        Phong _phong;
        Tang _tang;
        LoaiPhong _loaiphong;
        bool _add;
        string _idphong;

        private void frmPhong_Load(object sender, EventArgs e)
        {
            _phong = new Phong();
            _tang = new Tang();
            _loaiphong = new LoaiPhong();
            loadData();
            showHiddenControl(true);
            loadTang_LoaiPhong();
            comboBoxTang.SelectedIndexChanged += ComboBoxTang_SelectedIndexChanged;
            comboBoxLoaiPhong.SelectedIndexChanged += ComboBoxLoaiPhong_SelectedIndexChanged;

        }

        private void ComboBoxLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPhongByLoaiPhong();
        }

        private void ComboBoxTang_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPhongByTang();
        }

        void loadTang_LoaiPhong()
        {
            comboBoxTang.DataSource = _tang.getAll();
            comboBoxTang.DisplayMember = "TenTang";
            comboBoxTang.ValueMember = "IDTang";
            comboBoxLoaiPhong.DataSource = _loaiphong.getAll();
            comboBoxLoaiPhong.DisplayMember = "TenLoaiPhong";
            comboBoxLoaiPhong.ValueMember = "IDLoaiPhong";
        }

        void loadPhongByTang()
        {
            gridControlDanhSach.DataSource = _phong.getByTang(comboBoxTang.SelectedValue.ToString());
            gridViewDanhSach.OptionsBehavior.Editable = false;
        }

        void loadPhongByLoaiPhong()
        {
            gridControlDanhSach.DataSource = _phong.getByLoaiPhong(comboBoxLoaiPhong.SelectedValue.ToString());
            gridViewDanhSach.OptionsBehavior.Editable = false;
        }

       void loadData()
       {
            gridControlDanhSach.DataSource = _phong.getAllWithDetails();
            gridViewDanhSach.OptionsBehavior.Editable = false;
            
        }

        void showHiddenControl(bool sh)
        {
            toolStripBtnAdd.Visible = sh;
            toolStripBtnXoa.Visible = sh;
            toolStripBtnUpdate.Visible = sh;
            toolStripBtnSave.Visible = !sh;
            toolStripBtnSkip.Visible = !sh;
        }

        //Ẩn hiện thông tin
        void _enabled(bool ena)
        {
            txtTenPhong.Enabled = ena;
            checkBoxTrangThai.Enabled = ena;
            chbDisabled.Enabled = ena;
        }

        //reset lại các textbox sau khi thêm xóa sửa...
        void _reset()
        {
            txtID.Text = "";
            txtTenPhong.Text = "";
            checkBoxTrangThai.Checked = false;
            chbDisabled.Checked = false;
        }

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            _add = true;
            txtID.Enabled = true;
            showHiddenControl(false);
            _enabled(true);
            _reset();
        }

        private void toolStripBtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _phong.delete(_idphong);
            }
            loadData();
        }

        private void toolStripBtnUpdate_Click(object sender, EventArgs e)
        {
            _add = false;
            txtID.Enabled = false;
            showHiddenControl(false);
            _enabled(true);
        }

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            if (_add)
            {
                PHONG phong = new PHONG();
                phong.IDPhong = txtID.Text;
                phong.TenPhong = txtTenPhong.Text;
                phong.TrangThai = checkBoxTrangThai.Checked;
                phong.IDTang = comboBoxTang.SelectedValue.ToString();
                phong.IDLoaiPhong = comboBoxLoaiPhong.SelectedValue.ToString();
                phong.Disabled = chbDisabled.Checked;
                _phong.add(phong);
            }
            else
            {
                PHONG phong = new PHONG();
                phong.TenPhong = txtTenPhong.Text;
                phong.TrangThai = checkBoxTrangThai.Checked;
                phong.IDTang = comboBoxTang.SelectedValue.ToString();
                phong.IDLoaiPhong = comboBoxLoaiPhong.SelectedValue.ToString();
                phong.Disabled = chbDisabled.Checked;
                _phong.update(phong);
            }
            _add = false;
            loadData();
            showHiddenControl(true);
            _enabled(false);
        }

        private void toolStripBtnSkip_Click(object sender, EventArgs e)
        {
            _add = false;
            showHiddenControl(true);
            txtID.Enabled = false;
            _enabled(false);
        }

        private void gridViewDanhSach_Click(object sender, EventArgs e)
        {
            if (gridViewDanhSach.RowCount > 0)
            {
                _idphong = gridViewDanhSach.GetFocusedRowCellValue("IDPhong").ToString();
                comboBoxTang.SelectedValue = gridViewDanhSach.GetFocusedRowCellValue("IDTang").ToString();
                txtID.Text = gridViewDanhSach.GetFocusedRowCellValue("IDPhong").ToString();
                txtTenPhong.Text = gridViewDanhSach.GetFocusedRowCellValue("TenPhong").ToString();
                comboBoxLoaiPhong.SelectedValue = gridViewDanhSach.GetFocusedRowCellValue("IDLoaiPhong").ToString();
                checkBoxTrangThai.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("TrangThai").ToString());
                chbDisabled.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("Disabled").ToString());
            }
        }
    }
}