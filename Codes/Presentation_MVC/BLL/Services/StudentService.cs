using BLL.Entities;
using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace BLL.Services
{
    public class StudentService
    {
        public static StudentModel Get(int id)
        {
            var st = StudentRepo.Get(id);
            var s = new StudentModel()
            {
                Id = st.Id,
                Name = st.Name,
                DeptId = st.DeptId
            };
            return s;
        }
    }
}
