using System.Collections.Generic;
using DataAccessLayerInterface;

namespace DataAccessLayerCommon
{
    public abstract class Repository<TAnyType> : IRepository<TAnyType>
    {
        protected readonly List<TAnyType> AnyTypes = new List<TAnyType>();

        public virtual void Add(TAnyType anyType)
        {
            foreach (var type in AnyTypes)
            {
                if (type.Equals(anyType))
                {
                    return;
                }
            }

            AnyTypes.Add(anyType);
        }

        public virtual IEnumerable<TAnyType> GetCustomersFromDataBase()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TAnyType> GetCustomersFromInMemory()
        {
            return AnyTypes;
        }

        public TAnyType GetCustomersFromInMemory(int id)
        {
            return AnyTypes[id];
        }

        public virtual void Save()
        {
            throw new System.NotImplementedException();
        }

        public virtual void SetUnitOfWork(IUow uow)
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update(TAnyType anyType)
        {
            throw new System.NotImplementedException();
        }
    }
}
