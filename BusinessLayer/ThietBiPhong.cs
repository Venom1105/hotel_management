using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThietBiPhong
    {
        Entities db;
        public ThietBiPhong()
        {
            db = Entities.CreateEntities();
        }

        // Lấy danh sách thiết bị theo phòng
        public List<dynamic> getPhongThietBiAll()
        {
            var result = from ptb in db.PHONG_THIETBI
                         join p in db.PHONGs on ptb.IDPhong equals p.IDPhong
                         join tb in db.THIETBIs on ptb.IDThietBi equals tb.IDThietBi
                         select new
                         {
                             TenPhong = p.TenPhong,
                             TenThietBi = tb.TenThietBi,
                             SoLuong = ptb.SoLuong
                         };

            return result.ToList<dynamic>();
        }
        public void add(PHONG_THIETBI ptb)
        {
            try
            {
                db.PHONG_THIETBI.Add(ptb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
            }
        }

        public void delete(string idphong, string idtb)
        {
            PHONG_THIETBI _ptb_ = db.PHONG_THIETBI.FirstOrDefault(x => x.IDThietBi == idtb && x.IDPhong == idphong);
            _ptb_.Disabled = false;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy lỗi trong quá trình dữ liệu " + ex.Message);
            }
        }

        public void update(PHONG_THIETBI ptb)
        {
            PHONG_THIETBI _ptb = db.PHONG_THIETBI.FirstOrDefault(x => x.IDThietBi == ptb.IDThietBi && x.IDPhong == ptb.IDPhong);
            try
            {
                db.PHONG_THIETBI.Add(ptb);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi trong quá trình xử lý dữ liệu " + ex.Message);
            }
        }
    }
}

