using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class Func
    {
        Entities db;
        public Func()
        {
            //Khởi tạo
            db = Entities.CreateEntities();
        }

        //Lấy các menu là group trong bảng Func
        public List<FUNC> getParent() 
        {
            return db.FUNCs.Where(x => x.IsGroup == true && x.Menu == true).OrderBy(s => s.Sort).ToList();
        }

        public List<FUNC> getChild(string parent)
        {
            return db.FUNCs.Where(x => x.IsGroup == false && x.Menu == true && x.Parent == parent).OrderBy(s => s.Sort).ToList();
        }
    }
}
