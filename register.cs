using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Register : Form
    {
        // Connection string to connect to the Oracle database
        OracleConnection conn = new OracleConnection(@"User Id=QWERTY;Password=1234;");

        public Register()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Get user input values from textboxes and combobox
                string name = nameBox.Text;
                string password = passwordBox.Text;
                string phone = phoneBox.Text;
                string address = addressBox.Text;
                string role = roleBox.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) ||string.IsNullOrWhiteSpace(role))
                {
                    MessageBox.Show("Name, Password, and Role are required fields.");
                    return;
                }

                Connection cn = new Connection();
                cn.WriteUserToDB(name, password, role, phone, address);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            // This can be used to initialize any logic needed when the form loads
        }
    }
}
