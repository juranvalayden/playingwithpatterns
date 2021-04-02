using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using DataAccessLayerCommon;
using DataAccessLayerInterface;

namespace DataAccessLayerAdo
{
    public abstract class TemplateAdo<ICustomer> : Repository<ICustomer>
    {
        protected SqlConnection Connection;
        protected SqlCommand Command;
        protected IUow Uow;

        private void Open()
        {
            if (Connection != null && Connection.State != ConnectionState.Closed) return;

            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            Connection.Open();
            Command = new SqlCommand {Connection = Connection};
        }

        protected abstract void ExecuteCommand(ICustomer anyType);

        protected abstract List<ICustomer> ExecuteCommand();

        private void Close()
        {
            if (Uow == null)
            {
                Connection.Close();
            }
        }

        protected void Execute(ICustomer anyType)
        {
            Open();
            ExecuteCommand(anyType);
            Close();
        }

        protected List<ICustomer> Execute()
        {
            Open();
            var anyTypes = ExecuteCommand();
            Close();

            return anyTypes;
        }

        public override void Save()
        {
            foreach (var anyType in AnyTypes)
            {
                Execute(anyType);
            }
        }

        public override IEnumerable<ICustomer> GetCustomersFromDataBase()
        {
            return Execute();
        }

        public override void SetUnitOfWork(IUow uow)
        {
            Uow = uow;

            Connection = ((AdoUow) uow).Connection;
            
            Command = new SqlCommand
            {
                Connection = Connection, 
                Transaction = ((AdoUow) uow).Transaction
            };
        }
    }
}
