﻿using BTMEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTMService
{
    public interface ISpecialUserService : IService<SpecialUser>
    {
        List<SpecialUser> Validate(string username, string password);
    }
}
