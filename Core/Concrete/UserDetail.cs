using Microsoft.AspNetCore.Http;
using System;

namespace Core.Entities
{
    public class UserDetail : BaseEntity
    {
        public User User { get; set; }
        public string UserFirstName { get; set; }
        public string UserSurname { get; set; }
        public DateTime UserBirthDate { get; set; }
        public bool UserGender { get; set; }
        public string UserJob { get; set; }
        public string AboutUser { get; set; }
        public string UserPhotoPath { get; set; }
        public IFormFile UserPhoto { get; set; }
        public bool UserState { get; set; }
    }
}
