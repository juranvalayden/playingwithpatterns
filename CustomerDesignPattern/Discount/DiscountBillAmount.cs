using CustomerInterface;

namespace Discount
{
    public class DiscountBillAmount : IDiscount
    {
        public decimal Calculate(ICustomer customer)
        {
            if (customer.BillAmount > 10000) 
                return customer.BillAmount * 0.02m;

            return customer.BillAmount * 0.01m;
        }
    }
}
