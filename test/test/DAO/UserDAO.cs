using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test.EFS;

namespace Model.DAO
{
    public class UserDAO
    {
        private DBContextWeb db;

        public UserDAO()
        {
            db = new DBContextWeb();
        }

        public int login(string user, string pass)
        {

            var result = db.Accounts.SingleOrDefault(x => x.user.Contains(user) && x.pass.Contains(pass));
            if (result == null)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public List<product> listProduct()
        {
            return db.products.ToList();
        }
        public List<product> listProductB()
        {
            return db.products.ToList();
        }
    }
}
