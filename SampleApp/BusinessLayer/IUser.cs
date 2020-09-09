using System;
using System.Collections.Generic;
using System.Text;
using DBLayer;

namespace BusinessLayer
{
    interface IUser
    {
        List<DBLayer.User> GetUsers();
    }
}
