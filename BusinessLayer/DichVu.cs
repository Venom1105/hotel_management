using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class DichVu
    {
        Entities db;
        public DichVu()
        {
            db = Entities.CreateEntities();
        }

        public List<DICHVU> getAll()
        {
            return db.DICHVUs.ToList();
        }

        public DICHVU getItem(string iddichvu)
        {
            return db.DICHVUs.FirstOrDefault(x => x.IDDichVu == iddichvu);
        }

        public void add(DICHVU dvu)
        {
            try
            {
                
                db.DICHVUs.Add(dvu);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trông quá trình xử lý dữ liệu!!!!! " + ex.Message);
            }
        }

        public void update(DICHVU dvu)
        {
            //Muốn sửa cái nào thì phải lấy một bản ghi mặc định ra rồi mới sửa
            DICHVU _dvu = db.DICHVUs.FirstOrDefault(x => x.IDDichVu == dvu.IDDichVu);
            //Lấy bản ghi ra đc thì gắn và sửa nó
            _dvu.TenDichVu = dvu.TenDichVu;
            _dvu.DonGia = dvu.DonGia;
            _dvu.Disabled = dvu.Disabled;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trông quá trình xử lý dữ liệu!!!!! " + ex.Message);
            }
        }

        public void delete(string idCoSo)
        {
          
            DICHVU _dvu = db.DICHVUs.FirstOrDefault(x => x.IDDichVu == idCoSo);
            _dvu.Disabled = false;
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
