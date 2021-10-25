using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace ProjectPostmail
{
    public partial class AdministrationForm : Form
    {
        string password = "admin";
        double employer_id = default;
        double employee_id = default;
        int employer_postoffice_number = default;
        int employee_postoffice_number = default;
        bool check_list = false;

        List<Employer> employers = new List<Employer>();
        List<Employee> employees = new List<Employee>();

        AutoCompleteStringCollection auto_postoffice_number = new AutoCompleteStringCollection();

        IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };

        private void AutoComplete(TextBox name, AutoCompleteStringCollection collection)
        {
            name.AutoCompleteCustomSource = collection;
            name.AutoCompleteMode = AutoCompleteMode.Suggest;
            name.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public AdministrationForm()
        {
            InitializeComponent();
        }

        private void AdministrationForm_Load(object sender, EventArgs e)
        {

        }

        private void FormAccess_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PasswordBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (PasswordTextBox.Text == password)
                {
                    FormAccess.Visible = false;
                    //PasswordTextBox.Visible = false;
                    PasswordBox.Visible = false;
                }
            }
        }

        private void PostofficeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void PostofficeNumberBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PostofficeNumberBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (int.TryParse(EmployerDepartmentBox.Text, out int postofficenumber))
                {
                    DepartmentEmployerGroupBox.Text = "Відділення №" + postofficenumber.ToString();
                }
                else
                {
                    DepartmentEmployerGroupBox.Text = "Відділення № 0";
                }
            }
        }
        private void DepartmentEmployerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void EmployerDepartmentBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(EmployerDepartmentBox.Text, out employer_postoffice_number))
            {
                MessageBox.Show("Mistake with data");
            }

            AutoComplete(EmployerDepartmentBox, auto_postoffice_number);
        }

        private void EmployerGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void EmployerNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployerSurnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployerIDBox_TextChanged(object sender, EventArgs e)
        {
            bool check = double.TryParse(EmployerIDBox.Text, NumberStyles.Currency, formatter, out employer_id);

            if (!check)
            {
                MessageBox.Show("Mistake with data");
            }
        }

        private void EmployerButton_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Employer emp in employers)
                {
                    if (emp.Postoffice_Number == employer_postoffice_number)
                    {
                        check_list = true;
                        break;
                    }
                }
                if (check_list != true)
                {
                    employers.Add(new Employer(EmployerData.Value, EmployerNameBox.Text, EmployerSurnameBox.Text, employer_id, employer_postoffice_number, 0));
                }
            }
            catch (WorkersAmmountException exp)
            {
                MessageBox.Show($"{exp.Message}, Value: {exp.Value}");
            }
        }

        private void EmployerInfo_Click(object sender, EventArgs e)
        {

        }

        private void EmployerData_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DepartmentEmployeeGroupBox_Enter(object sender, EventArgs e)
        {
           
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {

        }

        private void EmployeeDepartmentBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(EmployeeDepartmentBox.Text, out employee_postoffice_number))
            {
                MessageBox.Show("Mistake with data");
            }

            AutoComplete(EmployeeDepartmentBox, auto_postoffice_number);
        }

        private void EmployeeGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void EmployeeNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeSurnameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeIDBox_TextChanged(object sender, EventArgs e)
        {
            bool check = double.TryParse(EmployeeIDBox.Text, NumberStyles.Currency, formatter, out employee_id);

            if (!check)
            {
                MessageBox.Show("Mistake with data");
            }
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Postoffice_Number == employee_postoffice_number)
                {
                    check_list = true;
                    break;
                }
            }
            if (check_list != true)
            {
                employees.Add(new Employee(EmployeeData.Value, EmployeeNameBox.Text, EmployeeSurnameBox.Text, employee_id, employee_postoffice_number));
            }
        }

        private void EmployeeInfo_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeData_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
