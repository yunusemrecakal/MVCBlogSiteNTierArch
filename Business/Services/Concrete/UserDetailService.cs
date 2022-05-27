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
    public class UserDetailService : GenericService<UserDetail>,IUserDetailService
    {
        private readonly IUserDetailRepository userDetailRepository;

        public UserDetailService(IUserDetailRepository userDetailRepository) : base(userDetailRepository)
        {
            this.userDetailRepository = userDetailRepository;
        }
    }
}
