namespace CustomerInterface
{
    public interface IDiscount
    {
        decimal Calculate(ICustomer customer);
    }
}