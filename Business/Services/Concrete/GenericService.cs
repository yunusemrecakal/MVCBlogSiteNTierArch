using Business.Services.Abstract;
using Core.Entities;
using DataAccess.Repositories;
using DataAccess.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Concrete
{
    public class GenericService<T> : IGenericService<T> where T : BaseEntity
    {
        private readonly IRepository<T> genericRepository;

        public GenericService(IRepository<T> genericRepository)
        {
            this.genericRepository = genericRepository;
        }

        public bool Add(T entity)
        {
            if (entity != null)
            {
                return genericRepository.Add(entity);
            }
            return false;
        }

        public bool Delete(T entity)
        {
            if (entity != null)
            {
                return genericRepository.Delete(entity);
            }
            return false;
        }

        public IEnumerable<T> GetAll()
        {
            return genericRepository.GetAll();

        }

        public T GetById(int id)
        {
            if (id >= 0)
            {
                return genericRepository.GetById(id);
            }
            else throw new Exception();
        }

        public bool Update(T entity)
        {
            if (entity != null)
            {
                return genericRepository.Update(entity);
            }
            return false;
        }
    }
}
