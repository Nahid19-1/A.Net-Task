using BLL.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static UserModel Get(int id)
        {
            var st = DataAccessFectory.UserDataAccess().Get(id);
            var s = new UserModel()
            {
                Id = st.Id,
                Name =st.Name,
                Username = st.Username
                

            };
            return s;
        }
        public static List<UserModel> Get()
        {
            var sts = DataAccessFectory.UserDataAccess().Get();
            List<UserModel> data = new List<UserModel>();
            foreach (var s in sts)
            {
                data.Add(new UserModel() { Id = s.Id, Name = s.Name, Username = s.Username });

            }
            return data;

        }

       
    }
}
