namespace WinFormsApp1
{
    public partial class login_page : Form
    {
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            // Create an instance of the Register form
            Register registerForm = new Register();

            // Show the Register form as a new window
            registerForm.Show();

            //this hides the login form
            this.Hide();
        }
        public login_page()
        {
            InitializeComponent();
            // Add event handler for the Register button
            button2.Click += new EventHandler(RegisterButton_Click);
        }


        private void loginpage_load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}

