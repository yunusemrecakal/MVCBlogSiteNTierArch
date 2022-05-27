using Core.Entities;
using DataAccess.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete
{
    public class UserRepository : GenericRepository<User> , IUserRepository
    {
        private readonly ApplicationDBContext db;

        public UserRepository(ApplicationDBContext db) : base(db)
        {
            this.db = db;
        }

    }
}
