using CustomerInterface;
using Discount;
using ExtraCharge;
using MiddleLayer.Models;
using Validation;

namespace FactoryCustomer
{
    public class FactoryCustomerBase
    {
        // Complex customer creation factory
        // Customer = Validation + Discount + ExtraCharges
        protected string CustomerType = string.Empty;

        public virtual IValidation<ICustomer> CreateValidation()
        {
            return new CustomerNameValidation();
        }

        public virtual IDiscount CreateDiscount()
        {
            return new DiscountBillAmount();
        }

        public virtual IExtraCharge CreateExtraCharge()
        {
            return new ExtraChargesWeekend();
        }

        public ICustomer CreateCustomer()
        {
            return new Customer(CreateValidation(), CreateDiscount(), CreateExtraCharge(), CustomerType);
        }
    }
}