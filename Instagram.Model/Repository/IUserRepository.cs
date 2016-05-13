﻿using Instagram.Model.EDM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instagram.Model.Repository
{
    public interface IUserRepository : IRepository<User>
    {

        IEnumerable<User> SearchUser(string searchTerm);
    }
}