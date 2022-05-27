using Business.Services.Abstract;
using Business.Services.Concrete;
using Core.Entities;
using DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService : GenericService<User> , IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository) : base (userRepository)
        {
            this.userRepository = userRepository;
        }
    }
}
