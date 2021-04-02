using System.Collections.Generic;

namespace DataAccessLayerInterface
{
    public interface IRepository<ICustomer>
    {
        void Add(ICustomer customer);
        void Update(ICustomer customer);
        IEnumerable<ICustomer> GetCustomersFromDataBase();
        IEnumerable<ICustomer> GetCustomersFromInMemory();
        ICustomer GetCustomersFromInMemory(int id);

        void Save();
        void SetUnitOfWork(IUow uow);
    }
}
