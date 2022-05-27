using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI.Models.ViewModels
{
    public class UserAndDetailVM
    {
        public User User { get; set; }
        public UserDetail UserDetail { get; set; }
    }
}
