    public partial class Form2 : Form
    {

        List<Patient> patients = new List<Patient>();



        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username=textBox1.Text;
            string password=textBox2.Text;
            string repeatpassword=textBox3.Text;

            comboBox1.Items.Add(username);
            if (password != repeatpassword)
            {
                MessageBox.Show("Password doesn't match! Give proper text");
            }
            if (password == repeatpassword)
            {
                MessageBox.Show("Registraation Successful.");
                Form3 form3 = new Form3();
                form3.Show();
            }
        }
    }
}
