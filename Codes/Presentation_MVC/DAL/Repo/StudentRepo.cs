using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StudentRepo
    {
        public static Student Get(int id)
        {
            AssocEntities db = new AssocEntities();
            /*var st = (from s in db.Students
                      where s.Id == id
                      select s).FirstOrDefault();
            return st;*/
            return db.Students.FirstOrDefault(x => x.Id == id);

        }

        public static List<Student> Get()
        {
            AssocEntities db = new AssocEntities();
            return db.Students.ToList();
        }
        public static bool Add(Student st)
        {
            AssocEntities db = new AssocEntities();
            db.Students.Add(st);
            if (db.SaveChanges() != 0) return true;
            return false;

        }
    }
}
