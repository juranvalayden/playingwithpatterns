using CustomerInterface;

namespace MiddleLayer.Models
{
    public class Customer : CustomerBase
    {
        public Customer(IValidation<ICustomer> validation, IDiscount discount, IExtraCharge extraCharge, string customerType) : base(validation, discount, extraCharge)
        {
            CustomerType = customerType;
        }
    }
}
