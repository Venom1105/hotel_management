using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ThietBi
    {
        Entities db;
        public ThietBi()
        {
            db = Entities.CreateEntities();
        }

        public THIETBI getItem(string idthietbi)
        {
            return db.THIETBIs.FirstOrDefault(x => x.IDThietBi == idthietbi);
        }

        public List<THIETBI> getAll()
        {
            return db.THIETBIs.ToList();
        }

        public void add(THIETBI thietbi)
        {
            
            try
            {
                db.THIETBIs.Add(thietbi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
            }
        }

        public void update(THIETBI thietbi)
        {
            THIETBI _thietbi = db.THIETBIs.FirstOrDefault(x => x.IDThietBi == thietbi.IDThietBi);
            _thietbi.TenThietBi = thietbi.TenThietBi;
            _thietbi.DonGia = thietbi.DonGia;
            _thietbi.Disabled = thietbi.Disabled;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
            }
        }

        public void delete(string idthietbi)
        {
            THIETBI _thietbi = db.THIETBIs.FirstOrDefault(x => x.IDThietBi == idthietbi);
            _thietbi.Disabled = false;
            try
            {
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception("Đã xảy ra trong quá trình xử lý dữ liệu " + ex.Message);
            }
        }
    }
}
