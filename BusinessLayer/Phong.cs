using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public List<PHONG> getByTang(string idTang)
        {
            return db.PHONGs.Where(x => x.IDTang == idTang).ToList();
        }
    }
}
