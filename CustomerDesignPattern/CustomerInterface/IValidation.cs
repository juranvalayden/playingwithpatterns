namespace CustomerInterface
{
    public interface IValidation<in TAnyType>
    {
        void Validate(TAnyType anyType);
    }
}