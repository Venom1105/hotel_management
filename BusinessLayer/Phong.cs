using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace BusinessLayer
{
    public class Phong
    {
        Entities db;
        public Phong()
        {
            db = Entities.CreateEntities();
        }
        public List<PHONG> getAll()
        {
            return db.PHONGs.ToList();
        }

        public PHONG getItem(string isphong)
        {
            return db.PHONGs.FirstOrDefault(x => x.IDPhong == isphong);
        }

       
        public List<PHONG> getByTang(string idTang)
        {
            return db.PHONGs.Where(x => x.IDTang == idTang ).ToList();
        }

        public List<PHONG> getByLoaiPhong(string idLoaiPhong)
        {
            return db.PHONGs.Where(x => x.IDLoaiPhong == idLoaiPhong).ToList();
        }

        public List<dynamic> getAllWithDetails()
        {
            var result = from p in db.PHONGs
                         join t in db.TANGs on p.IDTang equals t.IDTang
                         join lp in db.LOAIPHONGs on p.IDLoaiPhong equals lp.IDLoaiPhong
                         select new
                         {
                             IDPhong = p.IDPhong,
                             TenPhong = p.TenPhong,
                             TrangThai = p.TrangThai,
                             TenTang = t.TenTang,
                             TenLoaiPhong = lp.TenLoaiPhong
                         };
            return result.ToList<dynamic>();
        }


        public void add(PHONG phong)
        {
            try
            {
                db.PHONGs.Add(phong);
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu " +ex.Message);
            }
        }

        public void delete(string idphong)
        {
            PHONG phong = db.PHONGs.FirstOrDefault(x => x.IDPhong ==  idphong);
            phong.Disabled = false;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Đã xảy lỗi trong quá trình dữ liệu " +ex.Message);
            }
        }

        public void update(PHONG phong) 
        {
            PHONG _phong = db.PHONGs.FirstOrDefault(x => x.IDPhong == phong.IDPhong);
            try
            {
                db.PHONGs.Add(phong);
                db.SaveChanges();
            }catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi trong quá trình xử lý dữ liệu " +ex.Message);
            }
        }
    }
}
