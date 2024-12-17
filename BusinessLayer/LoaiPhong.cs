using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class LoaiPhong
    {
        Entities db;
        public LoaiPhong()
        {
            db = Entities.CreateEntities();
        }

        public LOAIPHONG getItem(string idloaiphong)
        {
            return db.LOAIPHONGs.FirstOrDefault(x => x.IDLoaiPhong == idloaiphong);
        }

        public List<LOAIPHONG> getAll()
        {
            return db.LOAIPHONGs.ToList();
        }

        public void add(LOAIPHONG loaiphong)
        {
            LOAIPHONG _loaiphong = db.LOAIPHONGs.FirstOrDefault(x => x.IDLoaiPhong == loaiphong.IDLoaiPhong);
            _loaiphong.TenLoaiPhong = loaiphong.TenLoaiPhong;
            _loaiphong.SoNguoiO = loaiphong.SoNguoiO;
            _loaiphong.DonGia = loaiphong.DonGia;
            _loaiphong.SoGiuong = loaiphong.SoGiuong;
            _loaiphong.Disabled = loaiphong.Disabled;
            try
            {
                db.LOAIPHONGs.Add(loaiphong);
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu " +ex.Message);
            }
        }

        public void update(LOAIPHONG loaiphong) 
        {
            LOAIPHONG _loaiphong = db.LOAIPHONGs.FirstOrDefault(x => x.IDLoaiPhong == loaiphong.IDLoaiPhong);
            _loaiphong.TenLoaiPhong = loaiphong.TenLoaiPhong;
            _loaiphong.SoNguoiO = loaiphong.SoNguoiO;
            _loaiphong.DonGia = loaiphong.DonGia;
            _loaiphong.SoGiuong = loaiphong.SoGiuong;
            _loaiphong.Disabled = loaiphong.Disabled;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
            }
        }

        public void delete(string isloaiphong)
        {
            LOAIPHONG _loaiphong = db.LOAIPHONGs.FirstOrDefault(x => x.IDLoaiPhong == isloaiphong);
            _loaiphong.Disabled = false;
            try
            {
                db.SaveChanges();

            }catch (Exception ex)
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu "+ex.Message);
            }
        }
    }
}
