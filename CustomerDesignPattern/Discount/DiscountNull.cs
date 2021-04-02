using CustomerInterface;

namespace Discount
{
    public class DiscountNull : IDiscount
    {
        public decimal Calculate(ICustomer customer)
        {
            return 0;
        }
    }
}