using BusinessLayer;
using DataLayer;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraNavBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace THUEPHONG
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        Tang _tang;
        Func _func;
        Phong _phong;
        GalleryItem item = null;
       
        private void frmMain_Load(object sender, EventArgs e)
        {
            // Kiểm tra và tạo file kết nối nếu chưa có
            //if (!File.Exists("connectdb.dba"))
            //{

            string enCryptServer = Encryptor.Encrypt(@"DESKTOP-530ACSJ\SQLEXPRESS", "qwertyiop", true);
            string enCryptUser = Encryptor.Encrypt("sa", "qwertyiop", true);
            string enCryptPassword = Encryptor.Encrypt("1105131102", "qwertyiop", true);
            string enCryptDatabase = Encryptor.Encrypt("Hotel_Management", "qwertyiop", true);
            Connect conn = new Connect(enCryptServer, enCryptUser, enCryptPassword, enCryptDatabase);
            conn.ConnectData(); // Tạo file connectdb.dba

            //}
            _tang = new Tang();
            _phong = new Phong();
            _func = new Func();
            //vừa chạy lên là hiện kết quả liền
            leftMenu();
            showRoom();
        }

        void leftMenu()
        {
            int i = 0; //đếm icon 
            var _isParent = _func.getParent();
            foreach (var _pr in _isParent)
            {
                // tạo navbar control chứa các chức năng
                NavBarGroup navGroup = new NavBarGroup(_pr.Decription);
                navGroup.Tag = _pr.Func_code;
                navGroup.Name = _pr.Func_code;
                // Hiện trên giao diện
                navGroup.ImageOptions.LargeImageIndex = i; //hiện icon cho menu cha
                i++; //i chạy hết các ic trong list
                navbarMain.Groups.Add(navGroup);

                var _isChild = _func.getChild(_pr.Func_code);
                foreach (var _ch in _isChild)
                {
                    NavBarItem navItem = new NavBarItem(_ch.Decription);
                    navItem.Tag = _ch.Func_code;
                    navItem.Name = _ch.Func_code;
                    navItem.ImageOptions.SmallImageIndex = 0;
                    navGroup.ItemLinks.Add(navItem);
                }

                //Lúc hiện form là các chức năng sổ ra 
                navbarMain.Groups[navGroup.Name].Expanded = true;
            }
        }

        private void navbarMain_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            //Xử lý click vào item nào thì hiện form của item đó
            string func_code = e.Link.Item.Tag.ToString();
            switch (func_code)
            {
                case "COSO":
                    {
                        frmCoSo frmcoso = new frmCoSo();
                        frmcoso.ShowDialog();
                        break;
                    }
                case "DONVI":
                    {
                        frmDonVi frmdovi = new frmDonVi();
                        frmdovi.ShowDialog();
                        break;
                    }
            }
        }

        //Hiển thị phòng lên giao diện
        void showRoom()
        {
            var listTang = _tang.getAll();
            galleryControl.Gallery.ItemImageLayout = ImageLayoutMode.ZoomInside;
            galleryControl.Gallery.ImageSize = new Size(64,64);
            galleryControl.Gallery.ShowItemText = true;
            galleryControl.Gallery.ShowGroupCaption = true;
            foreach (var _t in listTang) //add từng tầng vào 1 hàng trong GalleryControl
            {
                var galleryItem_Group = new GalleryItemGroup();
                galleryItem_Group.Caption = _t.TenTang;
                galleryItem_Group.CaptionAlignment = GalleryItemGroupCaptionAlignment.Stretch;
                var listPhong = _phong.getByTang(_t.IDTang);
                foreach (var _p in listPhong) //add từng phòng vào tầng
                {
                    var gallery_Item = new GalleryItem();
                    gallery_Item.Caption = _p.TenPhong;
                    gallery_Item.Value = _p.IDPhong;
                    //Hiện thị ic phòng đã đặt hoặc phòng trống
                    if (_p.TrangThai == true)
                        gallery_Item.ImageOptions.Image = imageList3.Images[1]; //phòng đã đặt
                    else
                        gallery_Item.ImageOptions.Image = imageList3.Images[0]; //phòng trống
                    galleryItem_Group.Items.Add(gallery_Item);
                }
                galleryControl.Gallery.Groups.Add(galleryItem_Group);
            }
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void popupMenu1_Popup(object sender, EventArgs e)
        {
            //bắt vị trí
            Point point = galleryControl.PointToClient(Control.MousePosition);
            RibbonHitInfo hitInfo = galleryControl.CalcHitInfo(point);
            if (hitInfo.InGalleryItem || hitInfo.HitTest == RibbonHitTest.GalleryImage)
                item = hitInfo.GalleryItem;
        }

        private void barBtnItemDatPhong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var gc_item = new GalleryItem();
            //lấy ID của galleryItem
            string id = item.Value.ToString();
            MessageBox.Show(id);
        }
    }
}
