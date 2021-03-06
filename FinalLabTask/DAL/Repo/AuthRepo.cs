using DAL.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class AuthRepo : IRepository<Token, string>, IAuth<Token>
    {
        private FinalNewsEntities db;

        public AuthRepo(FinalNewsEntities db)
        {
            this.db = db;
        }

        public Token Add(Token obj)
        {
            db.Tokens.Add(obj);
            db.SaveChanges();
            return db.Tokens.FirstOrDefault();
        }

        public Token Authenticate(string uname, string pass)
        {
            var data = db.Users.FirstOrDefault(x => x.Username.Equals(uname) && x.Password.Equals(pass));
            if (data != null)
            {
                var token = new Token();
                token.AccessToken = "1A2b3C";//random string
                token.CreatedAt = DateTime.Now;
                token.UserId = data.Id;
                token.ExpiredAt = null;

                db.Tokens.Add(token);
                db.SaveChanges();
                return token;

            }
            return null;
        }

        public Token Delete(string id)
        {
            throw new NotImplementedException();
        }

        public Token Edit(Token obj)
        {
            throw new NotImplementedException();
        }

        public Token Get(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }
    }
}
