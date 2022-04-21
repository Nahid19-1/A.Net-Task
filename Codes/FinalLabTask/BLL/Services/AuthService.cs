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
    public class AuthService
    {
        public static TokenModel Authenticate(string uname, string pass)
        {
            var token = DataAccessFectory.AuthDataAccess().Authenticate(uname, pass);
            //create tokenModel and map to token model
            if (token != null)
            {

                return new TokenModel() { AccessToken = token.AccessToken, CreatedAt = token.CreatedAt, ExpiredAt = token.ExpiredAt };
            }
            return null;
        }
        public static bool ValidateToken(string key)
        {
            var token = DataAccessFectory.TokenDataAccess().Get(key);
            if (token != null && token.ExpiredAt == null)
            {
                return true;
            }
            return false;
        }
    }
}
