using BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repo;


namespace BLL.Service
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
