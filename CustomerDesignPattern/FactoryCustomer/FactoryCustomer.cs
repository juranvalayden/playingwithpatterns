using CustomerInterface;
using Validation;

namespace FactoryCustomer
{
    public class FactoryCustomer : FactoryCustomerBase
    {
        public FactoryCustomer()
        {
            CustomerType = "Customer";
        }
        public override IValidation<ICustomer> CreateValidation()
        {
            return new AddressValidation(new PhoneValidation(new BillValidation(new CustomerNameValidation())));
        }
    }
}