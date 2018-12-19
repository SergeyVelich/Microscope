using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SaveImage
{
    class AuthentificationManager
    {
        public User ActiveUser { get; set; }

        public AuthentificationManager()
        {

        }

        public void OnAuthRequest(AuthRequestInfo info)
        {
            using (DBContext dbContext = new DBContext())
            {
                try
                {
                    ActiveUser = dbContext.Users.Where(u => u.Login == info.Login && u.Password == info.Password).Single();
                }
                catch
                {
                    throw new Exception("Неверно указан логин или пароль.");
                }
            }
        }

        public List<string> GetLoginsList()
        {
            List<string> LoginsList = new List<string>();

            using (DBContext dbContext = new DBContext())
            {
                LoginsList = dbContext.Users.Select(c => c.Login).ToList();
            }
            return LoginsList;
        }
    }
}
