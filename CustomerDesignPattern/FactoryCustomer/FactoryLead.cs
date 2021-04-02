using CustomerInterface;
using Discount;
using ExtraCharge;
using Validation;

namespace FactoryCustomer
{
    public class FactoryLead : FactoryCustomerBase
    {
        // Factory Method
        public FactoryLead()
        {
            CustomerType = "Lead";
        }

        public override IValidation<ICustomer> CreateValidation()
        {
            return new CustomerBillAmountZeroValidation(new PhoneValidation(new CustomerNameValidation()));
        }

        public override IDiscount CreateDiscount()
        {
            return new DiscountNull();
        }

        public override IExtraCharge CreateExtraCharge()
        {
            return new ExtraChargeNull();
        }
    }
}