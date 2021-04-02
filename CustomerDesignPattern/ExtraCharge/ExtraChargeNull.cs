using CustomerInterface;

namespace ExtraCharge
{
    public class ExtraChargeNull : IExtraCharge
    {
        public decimal Calculate(ICustomer customer)
        {
            return 0;
        }
    }
}