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
    public partial class frmQlyKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public frmQlyKhachHang()
        {
            InitializeComponent();
        }

        KhachHang _khachhang;
        bool _add;
        string _idKH;

        private void frmQlyKhachHang_Load(object sender, EventArgs e)
        {
            _khachhang = new KhachHang();
            loadData();
            showHiddenControl(true);
            _enabled(false);
            txtID.Enabled = false;
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
            txtHoTen.Enabled = ena;
            txtCCCD.Enabled = ena;
            txtDienThoai.Enabled = ena;
            txtEmail.Enabled = ena;
            txtDiaChi.Enabled = ena;
            chbDisabled.Enabled = ena;
        }

        //reset lại các textbox sau khi thêm xóa sửa...
        void _reset()
        {
            txtID.Text = "";
            txtHoTen.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            chbDisabled.Checked = false;
        }

        void loadData()
        {
            gridControlDanhSach.DataSource = _khachhang.getAll();
            //set data ko đc chỉnh sửa trên lưới
            gridViewDanhSach.OptionsBehavior.Editable = false;
        }

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            _add = true;
            txtID.Enabled = true; //thêm mới dùng đc idcoso
            showHiddenControl(false);
            _enabled(true);
            _reset();
        }

        private void toolStripBtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _khachhang.delete(_idKH);
            }
            loadData();
        }

        private void toolStripBtnUpdate_Click(object sender, EventArgs e)
        {
            _add = false;
            txtID.Enabled = false; //ko đc sửa idcoso
            showHiddenControl(false);
            _enabled(true);
        }

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            if (_add)
            {
                KHACHHANG khachhang = new KHACHHANG();
                khachhang.IDKhachHang = txtID.Text;
                khachhang.CCCD = txtCCCD.Text;
                khachhang.HoTen = txtHoTen.Text;
                khachhang.DienThoai = txtDienThoai.Text;
                khachhang.Email = txtEmail.Text;
                khachhang.DiaChi = txtDiaChi.Text;
                khachhang.Disabled = chbDisabled.Checked;
                _khachhang.add(khachhang);
            }
            else
            {
                KHACHHANG khachhang = _khachhang.getItem(_idKH);
                khachhang.HoTen = txtHoTen.Text;
                khachhang.CCCD = txtCCCD.Text;
                khachhang.DienThoai = txtDienThoai.Text;
                khachhang.Email = txtEmail.Text;
                khachhang.DiaChi = txtDiaChi.Text;
                khachhang.Disabled = chbDisabled.Checked;
                _khachhang.update(khachhang);
            }
            _add = false; //đảm bảo khi thêm hoặc sửa có nhấn thì quay về như cũ
            loadData(); //cập nhật lại data
            showHiddenControl(true);
            //_reset();
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
                _idKH = gridViewDanhSach.GetFocusedRowCellValue("IDKhachHang").ToString();
                txtID.Text = gridViewDanhSach.GetFocusedRowCellValue("IDKhachHang").ToString();
                txtCCCD.Text = gridViewDanhSach.GetFocusedRowCellValue("CCCD").ToString();
                txtHoTen.Text = gridViewDanhSach.GetFocusedRowCellValue("HoTen").ToString();
                txtDienThoai.Text = gridViewDanhSach.GetFocusedRowCellValue("DienThoai").ToString();
                txtEmail.Text = gridViewDanhSach.GetFocusedRowCellValue("Email").ToString();
                txtDiaChi.Text = gridViewDanhSach.GetFocusedRowCellValue("DiaChi").ToString();
                chbDisabled.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("Disabled").ToString());
            }
        }
    }
}