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
    public partial class frmQlyTang : DevExpress.XtraEditors.XtraForm
    {
        public frmQlyTang()
        {
            InitializeComponent();
        }

        Tang _tang;
        bool _add;
        string _idTang;

        private void frmQlyTang_Load(object sender, EventArgs e)
        {
            _tang = new Tang();
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
            txtTen.Enabled = ena;
            chbDisabled.Enabled = ena;
        }

        //reset lại các textbox sau khi thêm xóa sửa...
        void _reset()
        {
            txtID.Text = "";
            txtTen.Text = "";
            chbDisabled.Checked = false;
        }

        void loadData()
        {
            gridControlDanhSach.DataSource = _tang.getAll();
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
                _tang.delete(_idTang);
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
                TANG tang = new TANG();
                tang.IDTang = txtID.Text;
                tang.TenTang = txtTen.Text;
                tang.Disabled = chbDisabled.Checked;
                _tang.add(tang);
            }
            else
            {
                TANG tang = _tang.getItem(_idTang);
                tang.TenTang = txtTen.Text;
                tang.Disabled = chbDisabled.Checked;
                _tang.update(tang);
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
                _idTang = gridViewDanhSach.GetFocusedRowCellValue("IDTang").ToString();
                txtID.Text = gridViewDanhSach.GetFocusedRowCellValue("IDTang").ToString();
                txtTen.Text = gridViewDanhSach.GetFocusedRowCellValue("TenTang").ToString();
                chbDisabled.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("Disabled").ToString());
            }
        }
    }
}