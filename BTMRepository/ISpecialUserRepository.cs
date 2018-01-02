using BTMEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMRepository
{
    public interface ISpecialUserRepository:IRepository<SpecialUser>
    {
        List<SpecialUser> Validate(string username, string password);
    }
}
