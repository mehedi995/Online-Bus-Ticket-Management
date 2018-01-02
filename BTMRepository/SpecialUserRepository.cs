using BTMEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMRepository
{
    public class SpecialUserRepository:Repository<SpecialUser>, ISpecialUserRepository
    {
        DataContext context = new DataContext();

        public List<SpecialUser> Validate(string username, string password)
        {
            var data = this.context.SpecialUsers.ToList();
            data = data.Where(m => m.UserName == username).ToList();
            data = data.Where(m => m.Password == password).ToList();
            return data;

        }
    }
}
