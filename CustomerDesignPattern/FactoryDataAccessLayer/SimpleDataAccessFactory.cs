using CustomerInterface;
using DataAccessLayerAdo;
using DataAccessLayerEf;
using DataAccessLayerInterface;
using Unity;

namespace FactoryDataAccessLayer
{
    public static class SimpleDataAccessFactory<TAnyType>
    {
        private static UnityContainer _unityContainer;

        public static TAnyType CreateDataAccessComponent(string anyType)
        {
            if (_unityContainer != null) return _unityContainer.Resolve<TAnyType>(anyType);

            _unityContainer = new UnityContainer();

            _unityContainer.RegisterType<IRepository<ICustomer>, CustomerDataAccessLayerAdo>("ADO");
            _unityContainer.RegisterType<IRepository<ICustomer>, CustomerDataAccessLayerEf>("EF");

            _unityContainer.RegisterType<IUow, AdoUow>("AdoUow");
            _unityContainer.RegisterType<IUow, EfUow>("EfUow");

            return _unityContainer.Resolve<TAnyType>(anyType);
        }
    }
}
