using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    internal class DepartmentRepo
    {
        public static Department Get(int id)
        {
            AssocEntities db = new AssocEntities();
            return db.Departments.FirstOrDefault(x => x.Id == id);
        }
    }
}
