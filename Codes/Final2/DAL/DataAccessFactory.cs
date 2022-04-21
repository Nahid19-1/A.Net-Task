using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static AssocEntities db = new AssocEntities();
        public static IRepository<Student, int> StudentDataAccess()
        {
            return new StudentRepo(db);
        }
        public static IRepository<Department, int> DeptDataAccess()
        {
            return new DepartmentRepo(db);
        }
        public static IAuth AuthAccess()
        {
            return new StudentRepo(db);
        }
    }
}
