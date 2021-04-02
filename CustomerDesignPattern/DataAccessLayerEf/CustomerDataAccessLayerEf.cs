using CustomerInterface;

namespace DataAccessLayerEf
{
    // We type here to CustomerBase because we aren't allowed to map to an interface :(
    public class CustomerDataAccessLayerEf : DataAccessLayerEf<ICustomer>
    {
    }
}