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
    public class TopicServices : GenericService<Topic>, ITopicService
    {
        private readonly ITopicRepository topicRepository;

        public TopicServices(ITopicRepository topicRepository) : base(topicRepository)
        {
            this.topicRepository = topicRepository;
        }
    }
}
