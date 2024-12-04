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
    public partial class frmCoSo : DevExpress.XtraEditors.XtraForm
    {
        public frmCoSo()
        {
            InitializeComponent();
        }

        //Bảng không có khóa ngoại

        CoSo _coso;
        bool _add;
        string _idCoSo;
        private void frmCoSo_Load(object sender, EventArgs e)
        {
            _coso = new CoSo();
            loadData();
            showHiddenControl(true);
            _enabled(false);
            txtIDCoSo.Enabled = false;
        }

        //hàm hiển thị các button thêm xóa sửa lưu..... khi cần
        void showHiddenControl(bool sh)
        {
            toolStripBtnAddCoSo.Visible = sh;
            toolStripBtnXoaCoSo.Visible = sh;
            toolStripBtnUpdateCoSo.Visible = sh;
            toolStripBtnSaveCoSo.Visible = !sh;
            toolStripBtnSkip.Visible = !sh;
            toolStripBtnExit.Visible = sh;
        }

        //Ẩn hiện thông tin
        void _enabled(bool ena)
        {
            txtTenCoSo.Enabled = ena;
            txtDienThoai.Enabled = ena;
            txtEmail.Enabled = ena;
            txtDiaChi.Enabled = ena;
            chbDisabled.Enabled = ena;
        }

        //reset lại các textbox sau khi thêm xóa sửa...
        void _reset() 
        {
            txtIDCoSo.Text = "";
            txtTenCoSo.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
            chbDisabled.Checked = false;
        }

        void loadData()
        {
            gridControlDanhSach.DataSource = _coso.getAll();
            //set data ko đc chỉnh sửa trên lưới
            gridViewDanhSach.OptionsBehavior.Editable = false;
        }

        private void toolStripBtnAddCoSo_Click(object sender, EventArgs e)
        {
            _add = true;
            txtIDCoSo.Enabled = true; //thêm mới dùng đc idcoso
            showHiddenControl(false);
            _enabled(true);
            _reset();
        }

        private void toolStripBtnXoaCoSo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _coso.deleteCoSo(_idCoSo);
            }
            loadData();
        }

        private void toolStripBtnUpdateCoSo_Click(object sender, EventArgs e)
        {
            _add = false;
            txtIDCoSo.Enabled = false; //ko đc sửa idcoso
            showHiddenControl(false);
            _enabled(true);
        }

        private void toolStripBtnSaveCoSo_Click(object sender, EventArgs e)
        {
            if (_add)
            {
                COSO coso = new COSO();
                coso.IDCoSo = txtIDCoSo.Text;
                coso.TenCoSo = txtTenCoSo.Text;
                coso.DienThoai = txtDienThoai.Text;
                coso.Email = txtEmail.Text;
                coso.DiaChi = txtDiaChi.Text;
                coso.Disabled = chbDisabled.Checked;
                _coso.addCoSo(coso);
            }
            else
            {
                COSO coso = _coso.getItem(_idCoSo);
                coso.TenCoSo = txtTenCoSo.Text;
                coso.DienThoai = txtDienThoai.Text;
                coso.Email = txtEmail.Text;
                coso.DiaChi = txtDiaChi.Text;
                coso.Disabled = chbDisabled.Checked; 
                _coso.updateCoSo(coso);
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
            txtIDCoSo.Enabled = false;
            _enabled(false);
        }

        private void toolStripBtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //hiện dữ liệu lên các textbox
        private void gridViewDanhSach_Click(object sender, EventArgs e)
        {
            //kiểm tra có dữ liệu không
            if (gridViewDanhSach.RowCount > 0)
            {
                _idCoSo = gridViewDanhSach.GetFocusedRowCellValue("IDCoSo").ToString();
                txtIDCoSo.Text = gridViewDanhSach.GetFocusedRowCellValue("IDCoSo").ToString();
                txtTenCoSo.Text = gridViewDanhSach.GetFocusedRowCellValue("TenCoSo").ToString();
                txtDienThoai.Text = gridViewDanhSach.GetFocusedRowCellValue("DienThoai").ToString();
                txtEmail.Text = gridViewDanhSach.GetFocusedRowCellValue("Email").ToString();
                txtDiaChi.Text = gridViewDanhSach.GetFocusedRowCellValue("DiaChi").ToString();
                chbDisabled.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("Disabled").ToString());
            }
        }

       
    }
}