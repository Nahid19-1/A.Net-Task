using BLL.Entities;
using DAL;
using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AdminService
    {
        public static AdminModel Get(int id)
        {
            var st = DataAccessFectory.AdminDataAccess().Get(id);
            var s = new AdminModel()
            {
                Id = st.Id,
                Title = st.Title,
                Description = st.Description,
                CatId= st.CatId,
                Date =st.Date,
                PostBy = st.PostBy
            };
            return s;
        }
        public static List<AdminModel> Get()
        {
            var sts = DataAccessFectory.AdminDataAccess().Get();
            List<AdminModel> data = new List<AdminModel>();
            foreach (var s in sts)
            {
                data.Add(new AdminModel() { Id = s.Id, Title = s.Title, PostBy = s.PostBy, Description = s.Description,Date =s.Date });

            }
            return data;

        }

         public static AdminModel Create(News obj)
         {
             var st = DataAccessFectory.AdminDataAccess().Add(obj);
             var s = new AdminModel()
             {
                 Id = st.Id,
                 Title = st.Title,
                 Description = st.Description,
                 CatId = st.CatId,
                 Date = st.Date,
                 PostBy = st.PostBy
             };
             return s;

         }

        public static AdminModel Remove(int id)
        {
            var st = DataAccessFectory.AdminDataAccess().Delete(id);
            var s = new AdminModel()
            {
                Id = st.Id,
                Title = st.Title,
                Description = st.Description,
                CatId = st.CatId,
                Date = st.Date,
                PostBy = st.PostBy
            };
            return s;
        }

        public static AdminModel Update(News obj)
        {
            var st = DataAccessFectory.AdminDataAccess().Edit(obj);
            var s = new AdminModel()
            {
                Id = st.Id,
                Title = st.Title,
                Description = st.Description,
                CatId = st.CatId,
                Date = st.Date,
                PostBy = st.PostBy
            };
            return s;

        }
    }
}
