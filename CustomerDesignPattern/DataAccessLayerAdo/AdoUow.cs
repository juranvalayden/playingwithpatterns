using System.Configuration;
using System.Data.SqlClient;
using DataAccessLayerInterface;

namespace DataAccessLayerAdo
{
    public class AdoUow : IUow
    {
        public SqlConnection Connection { get; set; }
        public SqlTransaction Transaction { get; set; }

        public AdoUow()
        {
            Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            Transaction = Connection.BeginTransaction();
            Connection.Open();
        }

        public void Commit()
        {
            Transaction.Commit();
            Connection.Close();
        }

        public void Rollback()
        {
            Transaction.Dispose();
            Connection.Close();
        }
    }
}