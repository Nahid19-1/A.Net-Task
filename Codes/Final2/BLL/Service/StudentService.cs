using BLL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class StudentService
    {
        public static bool AuthenticateStudent(string uname, string pass)
        {
            var rt = DataAccessFactory.AuthAccess().Authenticate(uname, pass);
            return rt;
        }
        public static StudentModel Get(int id)
        {
            var st = DataAccessFactory.StudentDataAccess().Get(id);
            var s = new StudentModel()
            {
                Id = st.Id,
                Name = st.Name,
                DeptId = st.DeptId
            };
            return s;
        }
        public static List<StudentModel> Get()
        {
            var sts = DataAccessFactory.StudentDataAccess().Get();
            List<StudentModel> data = new List<StudentModel>();
            foreach (var s in sts)
            {
                data.Add(new StudentModel() { Id = s.Id, Name = s.Name, DeptId = s.DeptId });

            }
            return data;

        }
    }
}
