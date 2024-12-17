using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class KhachHang
    {
        Entities db;
        public KhachHang()
        {
            db = Entities.CreateEntities();
        }

        //Phương thức lấy 1 đơn vị ra
        public KHACHHANG getItem(string idkh)
        {
            return db.KHACHHANGs.FirstOrDefault(x => x.IDKhachHang == idkh);
        }

        public List<KHACHHANG> getAll()
        {
            return db.KHACHHANGs.ToList();
        }

        //Lấy theo id
        public List<KHACHHANG> getAll(string idkh)
        {
            return db.KHACHHANGs.Where(x => x.IDKhachHang == idkh).ToList();
        }

        //Phương thức thêm
        public void add(KHACHHANG kh)
        {
            try
            {
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }

        //Phương thức update
        public void update(KHACHHANG kh)
        {
            KHACHHANG _kh = db.KHACHHANGs.FirstOrDefault(x => x.IDKhachHang == kh.IDKhachHang);
            _kh.IDKhachHang = kh.IDKhachHang;
            _kh.HoTen = kh.HoTen;
            _kh.CCCD = kh.CCCD;
            _kh.DienThoai = kh.DienThoai;
            _kh.Email = kh.Email;
            _kh.DiaChi = kh.DiaChi;
            try
            {
                db.KHACHHANGs.Add(kh);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void delete(string idkh)
        {
            KHACHHANG _kh = db.KHACHHANGs.FirstOrDefault(x => x.IDKhachHang == idkh);
            _kh.Disabled = true;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu!!!!!" + ex.Message);
            }
        }
    }
}
