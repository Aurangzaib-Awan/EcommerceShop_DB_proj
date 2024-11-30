using System.Runtime.InteropServices.Marshalling;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace WinFormsApp1
{
    public class Connection
    {
        public static string connectionString = "User id=shop;Password=1234;Data Source=localhost:1521/xe;";

        public void WriteUserToDB(string name, string password, string role, string phone, string address)
        {
            using (OracleConnection con = new OracleConnection(connectionString))
            {
                try
                {
                    con.Open();
                    using (OracleCommand cmd = new OracleCommand("INSERT INTO USER_INFO (NAME, PASSWORD, ROLE, PHONE, ADDRESS) VALUES (:NAME, :PASSWORD, :ROLE, :PHONE, :ADDRESS)", con))
                    {
                        // Adding parameters to prevent SQL injection
                        cmd.Parameters.Add(new OracleParameter("NAME", OracleDbType.Varchar2)).Value = name;
                        cmd.Parameters.Add(new OracleParameter("PASSWORD", OracleDbType.Varchar2)).Value = password;
                        cmd.Parameters.Add(new OracleParameter("ROLE", OracleDbType.Varchar2)).Value = role;
                        cmd.Parameters.Add(new OracleParameter("PHONE", OracleDbType.Varchar2)).Value = phone;
                        cmd.Parameters.Add(new OracleParameter("ADDRESS", OracleDbType.Varchar2)).Value = address;

                        // Execute the query
                        int rowsEffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("User successfully registered! Rows inserted: " + rowsEffected);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }


    }
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new login_page());
        }
    }
}
