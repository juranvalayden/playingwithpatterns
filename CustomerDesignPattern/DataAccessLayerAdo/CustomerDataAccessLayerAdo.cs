 using System;
 using System.Collections.Generic;
 using CustomerInterface;
 using FactoryCustomer;

 namespace DataAccessLayerAdo
{
    public class CustomerDataAccessLayerAdo : TemplateAdo<ICustomer>
    {
        public override void Add(ICustomer anyType)
        {
            anyType.Validate();
            base.Add(anyType);
        }

        protected override void ExecuteCommand(ICustomer customer)
        {
            if (customer.Id == 0)
            {
                Command.CommandText = "insert into tblCustomer(CustomerName, BillAmount, BillDate, PhoneNumber, Address, CustomerType)" +
                                      "values('" +
                                      customer.CustomerName + "'," +
                                      customer.BillAmount + ",'" +
                                      customer.BillDate + "','" +
                                      customer.PhoneNumber + "','" +
                                      customer.Address + "','" +
                                      customer.CustomerType + "')";

                Command.ExecuteNonQuery();
            }
            else
            {
                // Update
            }
        }

        protected override List<ICustomer> ExecuteCommand()
        {
            Command.CommandText = "select * from tblCustomer";
            var sqlDataReader = Command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                var customer = FactoryCustomerLookUp.CreateCustomer("Customer");

                customer.Id = Convert.ToInt32(sqlDataReader["Id"]);
                customer.CustomerType = sqlDataReader["CustomerType"].ToString();
                customer.CustomerName = sqlDataReader["CustomerName"].ToString();
                customer.PhoneNumber = sqlDataReader["PhoneNumber"].ToString();
                customer.BillAmount = Convert.ToDecimal(sqlDataReader["BillAmount"].ToString());
                customer.BillDate = Convert.ToDateTime(sqlDataReader["BillDate"].ToString());
                customer.Address = sqlDataReader["Address"].ToString();

                AnyTypes.Add(customer);
            }

            return AnyTypes;
        }
    }
}