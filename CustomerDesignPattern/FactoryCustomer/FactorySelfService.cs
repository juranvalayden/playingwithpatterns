using CustomerInterface;
using ExtraCharge;

namespace FactoryCustomer
{
    public class FactorySelfService : FactoryCustomerBase
    {
        public FactorySelfService()
        {
            CustomerType = "SelfService";
        }

        public override IExtraCharge CreateExtraCharge()
        {
            return new ExtraChargeNull();
        }
    }
}