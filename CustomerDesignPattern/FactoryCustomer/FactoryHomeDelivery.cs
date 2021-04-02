using CustomerInterface;
using Validation;

namespace FactoryCustomer
{
    public class FactoryHomeDelivery : FactoryCustomerBase
    {
        public FactoryHomeDelivery()
        {
            CustomerType = "HomeDelivery";
        }

        public override IValidation<ICustomer> CreateValidation()
        {
            return new AddressValidation(new CustomerNameValidation());
        }
    }
}