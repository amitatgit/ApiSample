using System;
using System.Collections.Generic;
using DBLayer;

namespace BusinessLayer
{
    public class User : IUser
    {
        public List<DBLayer.User> GetUsers()
        {
            IUserRepo userRepo = new UserRepo();
            return (userRepo.GetUsers());
        }
    }
}
