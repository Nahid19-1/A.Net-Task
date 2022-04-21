using DAL.Database;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFectory
    {
        static FinalNewsEntities db = new FinalNewsEntities();

        public static IRepository<News, int> AdminDataAccess()
        {
            return new AdminRepo(db);
        }

        public static IRepository<User, int> UserDataAccess()
        {
            return new UserRepo(db);
        }

        public static IAuth<Token> AuthDataAccess()
        {
            return new AuthRepo(db);
        }
        public static IRepository<Token, string> TokenDataAccess()
        {
            return new AuthRepo(db);
        }
    }
}
