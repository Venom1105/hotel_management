using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    //Bảng có 1 hoặc nhiều khóa ngoại
    public class DonVi
    {
        Entities db;
        public DonVi() 
        {
            db = Entities.CreateEntities();
        }

        //Phương thức lấy 1 đơn vị ra
        public DONVI getItem(string iddonvi)
        {
            return db.DONVIs.FirstOrDefault(x => x.IDDonVi == iddonvi);
        }

        public List<DONVI> getAll()
        {
            return db.DONVIs.ToList();
        }

        //Lấy theo id
        public List<DONVI> getAll(string idcoso) 
        { 
            return db.DONVIs.Where(x => x.IDCoSo == idcoso).ToList();
        }

        //Phương thức thêm
        public void addDonVi(DONVI donvi) 
        {
            try
            {
                db.DONVIs.Add(donvi);
                db.SaveChanges();
            }
            catch (Exception ex) 
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" +ex.Message);
            }
        }

        //Phương thức update
        public void updateDonVi(DONVI donvi)
        {
            DONVI _donvi = db.DONVIs.FirstOrDefault(x => x.IDDonVi == donvi.IDDonVi);
            _donvi.IDDonVi = donvi.IDDonVi;
            _donvi.TenDonVi = donvi.TenDonVi;
            _donvi.DienThoai = donvi.DienThoai;
            _donvi.Email = donvi.Email;
            _donvi.DiaChi = donvi.DiaChi;
            try
            {
                db.DONVIs.Add(donvi);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trong quá trình xử lý dữ liệu" + ex.Message);
            }
        }
        public void deleteDonVi(string iddonvi)
        {
            DONVI _donvi = db.DONVIs.FirstOrDefault(x => x.IDDonVi == iddonvi);
            _donvi.Disabled = false;
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
