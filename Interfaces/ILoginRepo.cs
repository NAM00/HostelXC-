﻿using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ILoginRepo
    {
        bool InsertUser(Login l);
        bool DeleteUser(Login l);
        bool UpdateUser(Login l);
        Login GetUser(string id, string password);
    }
}
