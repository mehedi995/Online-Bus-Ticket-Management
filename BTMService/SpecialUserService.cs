using BTMEntity;
using BTMRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMService
{
    public class SpecialUserService : Service<SpecialUser>, ISpecialUserService
    {
        ISpecialUserRepository serv = new SpecialUserRepository();
        public List<SpecialUser> Validate(string username, string password)
        {
            return serv.Validate(username,password);
        }
    }
}
