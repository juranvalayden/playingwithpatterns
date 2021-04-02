using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using CustomerInterface;
using DataAccessLayerInterface;
using FactoryCustomer;
using FactoryDataAccessLayer;

namespace CustomerWindowsForm
{
    public class CustomerMediatorUi
    {
        private ICustomer _customer;
        private IRepository<ICustomer> _repository;
        private DataGridView _dataGridView;
        private readonly Dictionary<string, Control> _uiControls = new Dictionary<string, Control>();

        public void Register(ICustomer customer)
        {
            _customer = customer;
        }

        public void Register(IRepository<ICustomer> repository)
        {
            _repository = repository;
        }

        public void Register(TextBox textBox)
        {
            _uiControls.Add(textBox.Name, textBox);
        }

        public void Register(ComboBox comboBox)
        {
            _uiControls.Add(comboBox.Name, comboBox);
        }

        public void Register(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
        }

        public void Load()
        {
            var comboBox = (ComboBox) _uiControls["CbxDataAccessConnectionType"];

            comboBox.Items.Add("ADO");
            comboBox.Items.Add("EF");
            comboBox.SelectedIndex = 0;

            _repository = SimpleDataAccessFactory<IRepository<ICustomer>>.CreateDataAccessComponent(comboBox.Text);

            LoadGrid();
            ClearCustomer();
        }

        public void LoadGrid()
        {
            _dataGridView.DataSource = null;
            var customers = _repository.GetCustomersFromDataBase();
            _dataGridView.DataSource = customers;
        }

        private void LoadGridInMemory()
        {
            _dataGridView.DataSource = null;
            var customers = _repository.GetCustomersFromInMemory();
            _dataGridView.DataSource = customers;
        }

        public void DataAccessSelectionChanged()
        {
            var comboBox = (ComboBox)_uiControls["CbxDataAccessConnectionType"];

            _repository = SimpleDataAccessFactory<IRepository<ICustomer>>.CreateDataAccessComponent(comboBox.Text);
            LoadGrid();
        }

        public void CbxCustomerTypeSelectedIndexChanged()
        {
            var comboBox = (ComboBox)_uiControls["CbxCustomerType"];

            _customer = FactoryCustomerLookUp.CreateCustomer(comboBox.Text);
        }

        public void DataRowClick(int rowIndex)
        {
            _customer = _repository.GetCustomersFromInMemory(rowIndex);
            _customer.Clone();

            LoadCustomerToUi();
        }

        public void Add()
        {
            SetCustomer();

            try
            {
                _repository.Add(_customer);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            LoadGridInMemory();
            ClearCustomer();
        }

        public  void Save()
        {
            _repository.Save();
            ClearCustomer();
            LoadGrid();
        }

        public void Cancel()
        {
            ClearCustomer();
            _customer.Revert();
            LoadGridInMemory();
        }

        private void SetCustomer()
        {
            _customer.Id = 0;
            
            _customer.CustomerType =  _uiControls["CbxCustomerType"].Text;
            _customer.CustomerName = _uiControls["TxtCustomerName"].Text;
            _customer.PhoneNumber = _uiControls["TxtPhoneNumber"].Text;
            _customer.BillAmount = Convert.ToDecimal(_uiControls["TxtBillAmount"].Text);
            _customer.BillDate = Convert.ToDateTime(_uiControls["TxtBillDate"].Text);
            _customer.Address = _uiControls["TxtAddress"].Text;
        }

        private void LoadCustomerToUi()
        {
            _uiControls["TxtCustomerName"].Text = _customer.CustomerName;
            _uiControls["TxtPhoneNumber"].Text = _customer.PhoneNumber;
            _uiControls["TxtBillAmount"].Text = _customer.BillAmount.ToString(CultureInfo.InvariantCulture);
            _uiControls["TxtBillDate"].Text = _customer.BillDate.ToString(CultureInfo.InvariantCulture);
            _uiControls["TxtAddress"].Text = _customer.Address;

            var comboBox = (ComboBox)_uiControls["CbxCustomerType"];

            comboBox.SelectedItem = _customer.CustomerType;
        }

        private void ClearCustomer()
        {
            _uiControls["TxtCustomerName"].Text = "";
            _uiControls["TxtPhoneNumber"].Text = "";
            _uiControls["TxtBillDate"].Text = DateTime.Now.Date.ToString(CultureInfo.InvariantCulture);
            _uiControls["TxtBillAmount"].Text = "0";
            _uiControls["TxtAddress"].Text = "";
        }
    }
}