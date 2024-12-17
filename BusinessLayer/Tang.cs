using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Tang
    {
        Entities db;
        public Tang() 
        {
            db = Entities.CreateEntities();
        }

        public TANG getItem(string idtang)
        {
            return db.TANGs.FirstOrDefault(x => x.IDTang == idtang);
        }
        public List<TANG> getAll()
        {
            return db.TANGs.ToList();
        }

        public void add (TANG tang)
        {
            try
            {
                db.TANGs.Add(tang);
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Có lỗi trong quá trình xử lý dữ liệu !!!!!" +ex.Message);
            }
        }

        public void delete(string idtang)
        {
            TANG _tang = db.TANGs.FirstOrDefault(x => x.IDTang == idtang);
            _tang.Disabled = false;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra lỗi trong quá trình xử lý dữ liệu !!!!!" +ex.Message);
            }
        }

        public void update(TANG tang)
        {
            TANG _tang = db.TANGs.FirstOrDefault(x => x.IDTang == tang.IDTang);
            //Lấy bản ghi ra đc thì gắn và sửa nó
            _tang.TenTang = tang.TenTang;
            _tang.Disabled = tang.Disabled;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trông quá trình xử lý dữ liệu!!!!! " + ex.Message);
            }
        }
    }
}
