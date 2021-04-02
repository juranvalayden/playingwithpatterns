using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DataAccessLayerInterface;

namespace DataAccessLayerEf
{
    public class DataAccessLayerEf<TAnyType> : IRepository<TAnyType> where TAnyType : class
    {
        private DbContext _context;

        public DataAccessLayerEf()
        {
            _context = new EfUow();
        }

        public void Add(TAnyType anyType)
        {
            _context.Set<TAnyType>().Add(anyType);
        }

        public IEnumerable<TAnyType> GetCustomersFromDataBase()
        {
            return _context.Set<TAnyType>().AsQueryable().ToList();
        }

        public IEnumerable<TAnyType> GetCustomersFromInMemory()
        {
            throw new System.NotImplementedException();
        }

        public TAnyType GetCustomersFromInMemory(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TAnyType anyType)
        {
            throw new System.NotImplementedException();
        }

        public void SetUnitOfWork(IUow uow)
        {
            _context = (EfUow) uow;
        }
    }
}
