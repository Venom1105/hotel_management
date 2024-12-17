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
    public partial class frmDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDichVu()
        {
            InitializeComponent();
        }

        DichVu _dichvu;
        bool _add;
        string _idDichVu;

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            _dichvu = new DichVu();
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
            checkBoxDisabled.Enabled = ena;
        }

        void _reset()
        {
            txtID.Text = "";
            txtTen.Text = "";
            numericUpDownDonGia.Value = 0;
            checkBoxDisabled.Checked = false;
        }

        void loadData()
        {
            gridControlDanhSach.DataSource = _dichvu.getAll();
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
                _dichvu.delete(_idDichVu);
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
                DICHVU dichvu = new DICHVU();
                dichvu.IDDichVu = txtID.Text;
                dichvu.TenDichVu = txtTen.Text;
                dichvu.DonGia = (float)numericUpDownDonGia.Value;
                dichvu.Disabled = checkBoxDisabled.Checked;
                _dichvu.add(dichvu);
            }
            else
            {
                DICHVU dichvu = _dichvu.getItem(_idDichVu);
                dichvu.TenDichVu = txtTen.Text;
                dichvu.DonGia = (float)numericUpDownDonGia.Value;
                dichvu.Disabled = checkBoxDisabled.Checked;
                _dichvu.update(dichvu);
            }
            _add = false; 
            loadData(); 
            showHiddenControl(true);
            _reset();
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
                _idDichVu = gridViewDanhSach.GetFocusedRowCellValue("IDDichVu").ToString();
                txtID.Text = gridViewDanhSach.GetFocusedRowCellValue("IDDichVu").ToString();
                txtTen.Text = gridViewDanhSach.GetFocusedRowCellValue("TenDichVu").ToString();
                numericUpDownDonGia.Value = (decimal)float.Parse(gridViewDanhSach.GetFocusedRowCellValue("DonGia").ToString());
                checkBoxDisabled.Checked = bool.Parse(gridViewDanhSach.GetFocusedRowCellValue("Disabled").ToString());
            }
        }
    }
}