using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using CustomerInterface;
using DataAccessLayerInterface;
using FactoryDataAccessLayer;

namespace CustomerWindowsForm
{
    public partial class CustomerWindowsForm : Form
    {
        private ICustomer _customer = null;
        private IRepository<ICustomer> _repository = null;
        private readonly CustomerMediatorUi _customerMediatorUi = new CustomerMediatorUi();

        public CustomerWindowsForm()
        {
            InitializeComponent();
            _customerMediatorUi.Register(_customer);
            _customerMediatorUi.Register(_repository);
            _customerMediatorUi.Register(DgvCustomers);

            foreach (var textBox in Controls.OfType<TextBox>())
            {
                _customerMediatorUi.Register(textBox);
            }

            foreach (var comboBox in Controls.OfType<ComboBox>())
            {
                _customerMediatorUi.Register(comboBox);
            }
        }

        private void CustomerWindowsForm_Load(object sender, EventArgs e)
        {
            _customerMediatorUi.Load();
        }

        private void CbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customerMediatorUi.CbxCustomerTypeSelectedIndexChanged();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _customerMediatorUi.Add();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            _customerMediatorUi.Save();
        }

        private void DataAccessConnection_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customerMediatorUi.DataAccessSelectionChanged();
        }

        private void DgvCustomers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _customerMediatorUi.DataRowClick(e.RowIndex);
        }

        private void BtnUnitOfWork_Click(object sender, EventArgs e)
        {
            var uow = SimpleDataAccessFactory<IUow>.CreateDataAccessComponent("EfUow");

            try
            {
                var customer1 = new CustomerBase
                {
                    CustomerType = "Lead",
                    CustomerName = "Customer 1"
                };

                var repository = SimpleDataAccessFactory<IRepository<CustomerBase>>.CreateDataAccessComponent(CbxDataAccessConnectionType.Text);
                repository.SetUnitOfWork(uow);
                repository.Add(customer1);

                customer1 = new CustomerBase
                {
                    CustomerType = "Lead",
                    CustomerName = "Customer 2",
                    Address = "Some very long string..................................................................................................................................."
                };

                var repository1 = SimpleDataAccessFactory<IRepository<CustomerBase>>.CreateDataAccessComponent(CbxDataAccessConnectionType.Text);
                repository1.SetUnitOfWork(uow);
                repository1.Add(customer1);

                uow.Commit();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                uow.Rollback();
            }
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _customerMediatorUi.Cancel();
        }
    }
}
