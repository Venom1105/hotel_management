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
        public List<DONVI> getAll(string iddonvi) 
        { 
            return db.DONVIs.Where(x => x.IDDonVi == iddonvi).ToList();
        }

        //Phương thức thêm
        public void addDonVi(DONVI donvi) 
        { 
        }

    }
}
