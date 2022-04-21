using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class DepartmentRepo : IRepository<Department, int>
    {
        private AssocEntities db;
        public DepartmentRepo(AssocEntities db)
        {
            this.db = db;
        }
        public bool Add(Department obj)
        {
            db.Departments.Add(obj);
            if (db.SaveChanges() != 0) return true;
            return false;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool Edit(Department obj)
        {
            throw new NotImplementedException();
        }

        public Department Get(int id)
        {
            return db.Departments.FirstOrDefault(x => x.Id == id);
        }

        public List<Department> Get()
        {
            return db.Departments.ToList();
        }
    }
}
