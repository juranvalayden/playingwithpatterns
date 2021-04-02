
namespace CustomerWindowsForm
{
    partial class CustomerWindowsForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CbxCustomerType = new System.Windows.Forms.ComboBox();
            this.TxtCustomerName = new System.Windows.Forms.TextBox();
            this.TxtBillDate = new System.Windows.Forms.TextBox();
            this.TxtBillAmount = new System.Windows.Forms.TextBox();
            this.TxtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.DgvCustomers = new System.Windows.Forms.DataGridView();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.CbxDataAccessConnectionType = new System.Windows.Forms.ComboBox();
            this.BtnUnitOfWork = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxCustomerType
            // 
            this.CbxCustomerType.FormattingEnabled = true;
            this.CbxCustomerType.Items.AddRange(new object[] {
            "Lead",
            "Customer",
            "SelfService",
            "HomeDelivery"});
            this.CbxCustomerType.Location = new System.Drawing.Point(128, 23);
            this.CbxCustomerType.Name = "CbxCustomerType";
            this.CbxCustomerType.Size = new System.Drawing.Size(121, 23);
            this.CbxCustomerType.TabIndex = 0;
            this.CbxCustomerType.SelectedIndexChanged += new System.EventHandler(this.CbxCustomerType_SelectedIndexChanged);
            // 
            // TxtCustomerName
            // 
            this.TxtCustomerName.Location = new System.Drawing.Point(128, 68);
            this.TxtCustomerName.Name = "TxtCustomerName";
            this.TxtCustomerName.Size = new System.Drawing.Size(121, 23);
            this.TxtCustomerName.TabIndex = 2;
            // 
            // TxtBillDate
            // 
            this.TxtBillDate.Location = new System.Drawing.Point(440, 68);
            this.TxtBillDate.Name = "TxtBillDate";
            this.TxtBillDate.Size = new System.Drawing.Size(121, 23);
            this.TxtBillDate.TabIndex = 3;
            this.TxtBillDate.Text = "1/1/1980";
            // 
            // TxtBillAmount
            // 
            this.TxtBillAmount.Location = new System.Drawing.Point(440, 23);
            this.TxtBillAmount.Name = "TxtBillAmount";
            this.TxtBillAmount.Size = new System.Drawing.Size(121, 23);
            this.TxtBillAmount.TabIndex = 4;
            this.TxtBillAmount.Text = "0";
            // 
            // TxtPhoneNumber
            // 
            this.TxtPhoneNumber.Location = new System.Drawing.Point(128, 110);
            this.TxtPhoneNumber.Name = "TxtPhoneNumber";
            this.TxtPhoneNumber.Size = new System.Drawing.Size(121, 23);
            this.TxtPhoneNumber.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Bill Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Bill Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address";
            // 
            // TxtAddress
            // 
            this.TxtAddress.Location = new System.Drawing.Point(440, 114);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(121, 23);
            this.TxtAddress.TabIndex = 13;
            // 
            // DgvCustomers
            // 
            this.DgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCustomers.Location = new System.Drawing.Point(30, 202);
            this.DgvCustomers.Name = "DgvCustomers";
            this.DgvCustomers.RowTemplate.Height = 25;
            this.DgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvCustomers.Size = new System.Drawing.Size(808, 150);
            this.DgvCustomers.TabIndex = 14;
            this.DgvCustomers.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCustomers_RowEnter);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(440, 156);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(75, 23);
            this.BtnAdd.TabIndex = 15;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // CbxDataAccessConnectionType
            // 
            this.CbxDataAccessConnectionType.FormattingEnabled = true;
            this.CbxDataAccessConnectionType.Location = new System.Drawing.Point(645, 23);
            this.CbxDataAccessConnectionType.Name = "CbxDataAccessConnectionType";
            this.CbxDataAccessConnectionType.Size = new System.Drawing.Size(193, 23);
            this.CbxDataAccessConnectionType.TabIndex = 16;
            this.CbxDataAccessConnectionType.SelectedIndexChanged += new System.EventHandler(this.DataAccessConnection_SelectedIndexChanged);
            // 
            // BtnUnitOfWork
            // 
            this.BtnUnitOfWork.Location = new System.Drawing.Point(763, 63);
            this.BtnUnitOfWork.Name = "BtnUnitOfWork";
            this.BtnUnitOfWork.Size = new System.Drawing.Size(75, 23);
            this.BtnUnitOfWork.TabIndex = 17;
            this.BtnUnitOfWork.Text = "UOW";
            this.BtnUnitOfWork.UseVisualStyleBackColor = true;
            this.BtnUnitOfWork.Click += new System.EventHandler(this.BtnUnitOfWork_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(521, 156);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 23);
            this.BtnSave.TabIndex = 18;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(602, 156);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 19;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // CustomerWindowsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 380);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnUnitOfWork);
            this.Controls.Add(this.CbxDataAccessConnectionType);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.DgvCustomers);
            this.Controls.Add(this.TxtAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtPhoneNumber);
            this.Controls.Add(this.TxtBillAmount);
            this.Controls.Add(this.TxtBillDate);
            this.Controls.Add(this.TxtCustomerName);
            this.Controls.Add(this.CbxCustomerType);
            this.Name = "CustomerWindowsForm";
            this.Text = "Customer Interaction Form";
            this.Load += new System.EventHandler(this.CustomerWindowsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CbxCustomerType;
        private System.Windows.Forms.TextBox TxtCustomerName;
        private System.Windows.Forms.TextBox TxtBillDate;
        private System.Windows.Forms.TextBox TxtBillAmount;
        private System.Windows.Forms.TextBox TxtPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.DataGridView DgvCustomers;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CbxDataAccessConnectionType;
        private System.Windows.Forms.Button BtnUnitOfWork;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnCancel;
    }
}

