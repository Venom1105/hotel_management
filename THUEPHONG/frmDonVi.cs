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
    public partial class frmDonVi : DevExpress.XtraEditors.XtraForm
    {
        public frmDonVi()
        {
            InitializeComponent();
        }

        DonVi _donvi;
        CoSo _coso;
        bool _add;
        string _iddonvi;

        private void frmDonVi_Load(object sender, EventArgs e)
        {
            _donvi = new DonVi();
            _coso = new CoSo();
            //loadData();
            loadCoSo();
            showHiddenControl(true);
            _enabled(false);

            //hiển thị các đơn vị liên quan đến Cơ Sở đó
            comboBoxCoSo.SelectedIndexChanged += comboBoxCoSo_SelectedIndexChanged;
            loadDonViByCoSo(); // phải chạy sau sự kiện load Cơ sở và sự kiện các đơn vị liên quan đến Cơ Sở,
                               // nếu ko sẽ ko lấy được mã cơ sở và sẽ lỗi
        }

        private void comboBoxCoSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadDonViByCoSo();
        }

        void loadCoSo()
        {
            comboBoxCoSo.DataSource = _coso.getAll();
            comboBoxCoSo.DisplayMember = "TenCoSo";
            comboBoxCoSo.ValueMember = "IDCoSo";
        }

        void loadDonViByCoSo()
        {
            gridControlDanhSach.DataSource = _donvi.getAll(comboBoxCoSo.SelectedValue.ToString());
            gridViewDanhSach.OptionsBehavior.Editable = false;
        }
        void showHiddenControl(bool sh)
        {
            toolStripBtnAdd.Visible = sh;
            toolStripBtnXoa.Visible = sh;
            toolStripBtnUpdate.Visible = sh;
            toolStripBtnSave.Visible = !sh;
            toolStripBtnSkip.Visible = !sh;
            toolStripBtnExit.Visible = sh;
        }

        //Ẩn hiện thông tin
        void _enabled(bool ena)
        {
            txtTenDonVi.Enabled = ena;
            txtDienThoai.Enabled = ena;
            txtEmail.Enabled = ena;
            txtDiaChi.Enabled = ena;
            chbDisabled.Enabled = ena;
        }

        //reset lại các textbox sau khi thêm xóa sửa...
        void _reset()
        {
            txtIDDonVi.Text = "";
            txtTenDonVi.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            chbDisabled.Checked = false;
        }
        void loadData()
        {
            gridControlDanhSach.DataSource = _donvi.getAll();
            gridViewDanhSach.OptionsBehavior.Editable = false;
        }
        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            _add = true;
            txtIDDonVi.Enabled = true;
            showHiddenControl(false);
            _enabled(true);
            _reset();
        }

        private void toolStripBtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _donvi.deleteDonVi(_iddonvi);
            }
            loadData();
        }

        private void toolStripBtnUpdate_Click(object sender, EventArgs e)
        {
            _add = false;
            txtIDDonVi.Enabled = false;
            showHiddenControl(false);
            _enabled(true);
        }

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {
            if (_add)
            {
                DONVI donvi = new DONVI();
                donvi.IDDonVi = txtIDDonVi.Text;
                donvi.IDCoSo = comboBoxCoSo.SelectedValue.ToString();
                donvi.TenDonVi = txtTenDonVi.Text;
                donvi.DienThoai = txtDienThoai.Text;
                donvi.Email = txtEmail.Text;
                donvi.DiaChi = txtDiaChi.Text;
                donvi.Disabled = chbDisabled.Checked;
                _donvi.addDonVi(donvi);
            }
            else
            {
                DONVI donvi = new DONVI();
                donvi.TenDonVi = txtTenDonVi.Text;
                donvi.IDCoSo = comboBoxCoSo.SelectedValue.ToString();
                donvi.DienThoai = txtDienThoai.Text;
                donvi.Email = txtEmail.Text;
                donvi.DiaChi = txtDiaChi.Text;
                donvi.Disabled = chbDisabled.Checked;
                _donvi.updateDonVi(donvi);
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
            txtIDDonVi.Enabled = false;
            _enabled(false);
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewDanhSach_Click(object sender, EventArgs e)
        {
            if (gridViewDanhSach.RowCount > 0)
            {
                _iddonvi = gridViewDanhSach.GetFocusedRowCellValue("IDDonVi").ToString();
                comboBoxCoSo.SelectedValue = gridViewDanhSach.GetFocusedRowCellValue("IDCoSo").ToString();
                txtIDDonVi.Text = gridViewDanhSach.GetFocusedRowCellValue("IDDonVi").ToString();
                txtTenDonVi.Text = gridViewDanhSach.GetFocusedRowCellValue("TenDonVi").ToString();
                txtDienThoai.Text = gridViewDanhSach.GetFocusedRowCellValue("DienThoai").ToString();
                txtEmail.Text = gridViewDanhSach.GetFocusedRowCellValue("Email").ToString();
                txtDiaChi.Text = gridViewDanhSach.GetFocusedRowCellValue("DiaChi").ToString();
                chbDisabled.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("Disabled").ToString());
            }
        }
    }
}