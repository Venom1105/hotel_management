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
    public partial class frmThietBiPhong : DevExpress.XtraEditors.XtraForm
    {
        public frmThietBiPhong()
        {
            InitializeComponent();
        }

        ThietBiPhong _phongThietBi;
        ThietBi _thietbi;
        Phong _phong;
        bool _add;
        string _idtb, _idp;

        private void frmThietBiPhong_Load(object sender, EventArgs e)
        {
            _phongThietBi = new ThietBiPhong();
            loadDanhSach();
            loadThietBi_Phong();
            showHiddenControl(true);
        }

        void loadThietBi_Phong()
        {
            comboBoxTenThietBi.DataSource = _thietbi.getAll();
            comboBoxTenThietBi.DisplayMember = "TenThietBi";
            comboBoxTenThietBi.ValueMember = "IDThietBi";
            comboBoxTenPhong.DataSource = _phong.getAll();
            comboBoxTenPhong.DisplayMember = "TenPhong";
            comboBoxTenPhong.ValueMember = "IDPhong";
        }

        void loadDanhSach()
        {
            gridControlDanhSach.DataSource = _phongThietBi.getPhongThietBiAll();
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

        void _reset()
        {
            numericUpDownSoLuong.Value = 0;
        }

        private void toolStripBtnAdd_Click(object sender, EventArgs e)
        {
            _add = true;
            showHiddenControl(false);
            _reset();
        }

        private void toolStripBtnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _phongThietBi.delete(_idtb,_idp);
            }
            loadDanhSach();
        }

        private void toolStripBtnUpdate_Click(object sender, EventArgs e)
        {
            _add = false;
            showHiddenControl(false);
        }

        private void toolStripBtnSave_Click(object sender, EventArgs e)
        {

            if (_add)
            {
                PHONG_THIETBI ptb = new PHONG_THIETBI();
                ptb.IDThietBi = comboBoxTenThietBi.SelectedValue.ToString();
                ptb.IDPhong = comboBoxTenPhong.SelectedValue.ToString();
                ptb.SoLuong = (int)numericUpDownSoLuong.Value;
                _phongThietBi.add(ptb);
            }
            else
            {

                PHONG_THIETBI ptb = new PHONG_THIETBI();
                ptb.IDThietBi = comboBoxTenThietBi.SelectedValue.ToString();
                ptb.IDPhong = comboBoxTenPhong.SelectedValue.ToString();
                ptb.SoLuong = (int)numericUpDownSoLuong.Value;
                _phongThietBi.add(ptb);
            }
            _add = false;
            loadDanhSach();
            showHiddenControl(true);
        }

        private void toolStripBtnSkip_Click(object sender, EventArgs e)
        {
            _add = false;
            showHiddenControl(true);
        }

        private void gridViewDanhSach_Click(object sender, EventArgs e)
        {
            if (gridViewDanhSach.RowCount > 0)
            {
                _idp = gridViewDanhSach.GetFocusedRowCellValue("IDPhong").ToString();
                _idtb = gridViewDanhSach.GetFocusedRowCellValue("IDThietBi").ToString();
                comboBoxTenThietBi.SelectedValue = gridViewDanhSach.GetFocusedRowCellValue("IDThietBi").ToString();
                comboBoxTenPhong.SelectedValue = gridViewDanhSach.GetFocusedRowCellValue("IDPhong").ToString();
                numericUpDownSoLuong.Value = int.Parse(gridViewDanhSach.GetFocusedRowCellValue("SoLuong").ToString());
            }
        }
    }
}