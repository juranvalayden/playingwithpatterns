using System;
using CustomerInterface;

namespace Discount
{
    public class DiscountWeekend : IDiscount
    {
        public decimal Calculate(ICustomer customer)
        {
            if (customer.BillDate.DayOfWeek == DayOfWeek.Saturday || customer.BillDate.DayOfWeek == DayOfWeek.Saturday)
            {
                return customer.BillAmount * 0.01m;
            }

            return customer.BillAmount * 0.005m;
        }
    }
}