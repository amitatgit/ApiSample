using System;
using System.Collections.Generic;
using System.Text;

namespace DBLayer
{
    public interface IUserRepo
    {
        List<User> GetUsers();
    }
}
