using CustomerInterface;
using Unity;

namespace FactoryCustomer
{
    public static class FactoryCustomerLookUp
    {
        private static UnityContainer _unityContainer;

        public static ICustomer CreateCustomer(string customerType)
        {
            if (_unityContainer != null)
            {
                return _unityContainer
                    .Resolve<FactoryCustomerBase>(customerType)
                    .CreateCustomer();
            }

            _unityContainer = new UnityContainer();

            _unityContainer.RegisterType<FactoryCustomerBase, FactoryLead>("Lead");
            _unityContainer.RegisterType<FactoryCustomerBase, FactorySelfService>("SelfService");
            _unityContainer.RegisterType<FactoryCustomerBase, FactoryHomeDelivery>("HomeDelivery");
            _unityContainer.RegisterType<FactoryCustomerBase, FactoryCustomer>("Customer");

            return _unityContainer
                .Resolve<FactoryCustomerBase>(customerType)
                .CreateCustomer();

        }
    }
}
