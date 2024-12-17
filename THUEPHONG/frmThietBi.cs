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
    public partial class frmThietBi : DevExpress.XtraEditors.XtraForm
    {
        public frmThietBi()
        {
            InitializeComponent();
        }

        ThietBi _thietbi;
        bool _add;
        string _idThietBi;

        private void frmThietBi_Load(object sender, EventArgs e)
        {
            _thietbi = new ThietBi();
            loadData();
            showHiddenControl(true);
            _enabled(false);
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
            numericUpDownDonGia.Enabled = ena;
            chbDisabled.Enabled = ena;
        }

        //reset lại các textbox sau khi thêm xóa sửa...
        void _reset()
        {
            txtID.Text = "";
            txtTen.Text = "";
            numericUpDownDonGia.Value = 0;
            chbDisabled.Checked = false;
        }

        void loadData()
        {
            gridControlDanhSach.DataSource = _thietbi.getAll();
            gridViewDanhSach.OptionsBehavior.Editable = false;
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
                _thietbi.delete(_idThietBi);
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
                THIETBI thietbi = new THIETBI();
                thietbi.IDThietBi = txtID.Text;
                thietbi.TenThietBi = txtTen.Text;
                thietbi.DonGia = (float)numericUpDownDonGia.Value;
                thietbi.Disabled = chbDisabled.Checked;
                _thietbi.add(thietbi);
            }
            else
            {
                THIETBI thietbi = _thietbi.getItem(_idThietBi);
                thietbi.TenThietBi = txtTen.Text;
                thietbi.DonGia = (float)numericUpDownDonGia.Value;
                thietbi.Disabled = chbDisabled.Checked;
                _thietbi.update(thietbi);
            }
            _add = false; 
            loadData(); 
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
                _idThietBi = gridViewDanhSach.GetFocusedRowCellValue("IDThietBi").ToString();
                txtID.Text = gridViewDanhSach.GetFocusedRowCellValue("IDThietBi").ToString();
                txtTen.Text = gridViewDanhSach.GetFocusedRowCellValue("TenThietBi").ToString();
                numericUpDownDonGia.Value = (decimal)float.Parse(gridViewDanhSach.GetFocusedRowCellValue("DonGia").ToString());
                chbDisabled.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("Disabled").ToString());
            }
        }
    }
}