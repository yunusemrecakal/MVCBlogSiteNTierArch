using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Article : BaseEntity
    {
        public Article()
        {
            Topics = new HashSet<Topic>();
            LikedUsers = new HashSet<User>();

        }
        public string ArticleHeading { get; set; }
        public string ArticleContent { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public string ArticlePhoto { get; set; }
        public ICollection<Topic> Topics { get; set; }
        public ICollection<User> LikedUsers { get; set; }
    }
}
