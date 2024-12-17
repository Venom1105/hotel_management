using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    //Bảng không có khóa ngoại
    public class CoSo
    {
        Entities db;
        public CoSo() 
        {
            db = Entities.CreateEntities();
        }
        //vs mỗi class chức năng như này thì có 4 phương thức cơ bản: Select, Add, Update, Delete
        //Có thể thêm get item để chỉnh sửa

        public COSO getItem(string idCoSo)
        {
            //Lấy 1 bảng để chỉnh sửa
            return db.COSOes.FirstOrDefault(x => x.IDCoSo == idCoSo);
        }

        //Lấy ra 1 danh sách
        public List<COSO> getAll()
        {
            //Lấy tất cả
            return db.COSOes.ToList();
        }

        //Phương thức thêm
        public void addCoSo(COSO coso)
        {
            try
            {
                //tương tác vs CSDL nên dùng try catch để khi không thức hiện được thì roll back ko ảnh hưởng tới CSDL
                db.COSOes.Add(coso);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trông quá trình xử lý dữ liệu!!!!! " +ex.Message);
            }
        }

        //Phương thức Update
        public void updateCoSo(COSO coso)
        {
            //Muốn sửa cái nào thì phải lấy một bản ghi mặc định ra rồi mới sửa
            COSO _coso = db.COSOes.FirstOrDefault(x => x.IDCoSo == coso.IDCoSo);
            //Lấy bản ghi ra đc thì gắn và sửa nó
            _coso.TenCoSo = coso.TenCoSo;
            _coso.DienThoai = coso.DienThoai;
            _coso.Email = coso.Email;
            _coso.DiaChi = coso.DiaChi;
            _coso.Disabled = coso.Disabled;
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra trông quá trình xử lý dữ liệu!!!!! " + ex.Message);
            }
        }

        //Phương thức Delete
        public void deleteCoSo(string idCoSo) 
        {
            //Tình huống trong project qly khách sạn này thôi
            //Vì sao không remove lun
            //nếu dữ liệu mới thì remove đc
            //còn dữ liệu cũ thì sẽ có những chứng từ liên quan nên không thể remove được
            //nên mik chỉ có thể đánh dấu nó là ko dùng nữa
            COSO _coso = db.COSOes.FirstOrDefault(x => x.IDCoSo == idCoSo);
            _coso.Disabled = false;
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
