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
    public partial class frmLoaiPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        LoaiPhong _loaiphong;
        bool _add;
        string _idLoaiPhong;

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            _loaiphong = new LoaiPhong();
            loadData();
            showHiddenControl(true);
            _enabled(false);
            //txtIDCoSo.Enabled = false;
        }

        void showHiddenControl(bool sh)
        {
            toolStripBtnAddCoSo.Visible = sh;
            toolStripBtnXoaCoSo.Visible = sh;
            toolStripBtnUpdateCoSo.Visible = sh;
            toolStripBtnSaveCoSo.Visible = !sh;
            toolStripBtnSkip.Visible = !sh;
        }

        //Ẩn hiện thông tin
        void _enabled(bool ena)
        {
            txtTen.Enabled = ena;
            numericUpDownDonGia.Enabled = ena;
            numericUpDownSoNguoi.Enabled = ena;
            numericUpDownSoGiuong.Enabled = ena;
            chbDisabled.Enabled = ena;
        }

        //reset lại các textbox sau khi thêm xóa sửa...
        void _reset()
        {
            txtID.Text = "";
            txtTen.Text = "";
            numericUpDownDonGia.Value = 0;
            numericUpDownSoNguoi.Value = 0;
            numericUpDownSoGiuong.Value = 0;
            chbDisabled.Checked = false;
        }

        void loadData()
        {
            gridControlDanhSach.DataSource = _loaiphong.getAll();
            //set data ko đc chỉnh sửa trên lưới
            gridViewDanhSach.OptionsBehavior.Editable = false;
        }
        private void toolStripBtnAddCoSo_Click(object sender, EventArgs e)
        {
            _add = true;
            txtID.Enabled = true; //thêm mới dùng đc idcoso
            showHiddenControl(false);
            _enabled(true);
            _reset();
        }

        private void toolStripBtnXoaCoSo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _loaiphong.delete(_idLoaiPhong);
            }
            loadData();
        }

        private void toolStripBtnUpdateCoSo_Click(object sender, EventArgs e)
        {
            _add = false;
            txtID.Enabled = false; //ko đc sửa idcoso
            showHiddenControl(false);
            _enabled(true);
        }

        private void toolStripBtnSaveCoSo_Click(object sender, EventArgs e)
        {
            if (_add)
            {
                LOAIPHONG loaiphong = new LOAIPHONG();
                loaiphong.IDLoaiPhong = txtID.Text;
                loaiphong.TenLoaiPhong = txtTen.Text;
                loaiphong.DonGia = (float)numericUpDownDonGia.Value; //ép kiểu
                loaiphong.SoNguoiO = (int)numericUpDownSoNguoi.Value;
                loaiphong.SoGiuong = (int)numericUpDownSoGiuong.Value;
                loaiphong.Disabled = chbDisabled.Checked;
                _loaiphong.add(loaiphong);
            }
            else
            {
                LOAIPHONG loaiphong = _loaiphong.getItem(_idLoaiPhong);
                loaiphong.TenLoaiPhong = txtTen.Text;
                loaiphong.DonGia = (float)numericUpDownDonGia.Value;
                loaiphong.SoNguoiO = (int)numericUpDownSoNguoi.Value;
                loaiphong.SoGiuong = (int)numericUpDownSoGiuong.Value;
                loaiphong.Disabled = chbDisabled.Checked;
                _loaiphong.update(loaiphong);
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
            //kiểm tra có dữ liệu không
            if (gridViewDanhSach.RowCount > 0)
            {
                _idLoaiPhong = gridViewDanhSach.GetFocusedRowCellValue("IDLoaiPhong").ToString();
                txtID.Text = gridViewDanhSach.GetFocusedRowCellValue("IDLoaiPhong").ToString();
                txtTen.Text = gridViewDanhSach.GetFocusedRowCellValue("TenLoaiPhong").ToString();
                numericUpDownDonGia.Value = (decimal)float.Parse(gridViewDanhSach.GetFocusedRowCellValue("DonGia").ToString());
                numericUpDownSoNguoi.Value = (decimal)int.Parse(gridViewDanhSach.GetFocusedRowCellValue("SoNguoiO").ToString());
                numericUpDownSoGiuong.Value = (decimal)int.Parse(gridViewDanhSach.GetFocusedRowCellValue("SoGiuong").ToString());
                chbDisabled.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("Disabled").ToString());
            }
        }
    }
}