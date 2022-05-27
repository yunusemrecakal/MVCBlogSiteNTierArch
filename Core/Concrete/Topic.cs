using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Topic : BaseEntity
    {
        public Topic()
        {
            Users = new HashSet<User>();
            Articles = new HashSet<Article>();
        }
        public string TopicName { get; set; }
        public string TopicDefinition { get; set; }

        public ICollection<User> Users { get; set; }
        public ICollection<Article> Articles { get; set; }
        public string TopicPhoto { get; set; }
    }
}
