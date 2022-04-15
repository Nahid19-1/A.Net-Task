using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class UserRepo : IRepository<User, int>
    {
        private FinalNewsEntities db;

        public UserRepo(FinalNewsEntities db)
        {
            this.db = db;
        }
        public User Add(User obj)
        {
            throw new NotImplementedException();
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Edit(User obj)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            return db.Users.FirstOrDefault(x => x.Id == id);
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }
    }
}
