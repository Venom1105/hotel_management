using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DatPhong
    {
        Entities db;
        public DatPhong()
        {
            db = Entities.CreateEntities();
        }

        public DATPHONG getItem(string iddp)
        {
            return db.DATPHONGs.FirstOrDefault(x => x.IDDatPhong == iddp);
        }

        public List<DATPHONG> getAll()
        {
            return db.DATPHONGs.ToList();
        }

        public void add(DATPHONG dp)
        {
            try
            {
                db.DATPHONGs.Add(dp);
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Đã xảy ra lỗi trong quá trình xử lý dữ liệu !!!!! " +ex.Message);
            }
        }

        public void update(DATPHONG _dp)
        {
            DATPHONG dp = db.DATPHONGs.FirstOrDefault(x => x.IDDatPhong == _dp.IDDatPhong);
            dp.IDKhachHang = _dp.IDKhachHang;
            dp.IDCoSo = _dp.IDCoSo;
            dp.IDDonVi = _dp.IDDonVi;
            dp.SoNguoiO = _dp.SoNguoiO;
            dp.NgayDat = _dp.NgayDat;
            dp.NgayTra = _dp.NgayTra;
            dp.SoTien = _dp.SoTien;
            dp.UserID = _dp.UserID;
            dp.Disabled = _dp.Disabled;
            dp.GhiChu = _dp.GhiChu;
            dp.TheoDoan = _dp.TheoDoan;
            dp.CreateDate = _dp.CreateDate;

            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu!!!!! " + ex.Message);
            }
        }

        public void delete(string iddp)
        {
            DATPHONG dp = db.DATPHONGs.FirstOrDefault(x => x.IDDatPhong == iddp);
            dp.Disabled = false;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý liệu!!!!! " +ex.Message);
            }
        }

    }
}
