    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string username = textBox1.Text;
            string password = textBox2.Text;
          

            string username2 = textBox1.Text;
            string password2 = textBox2.Text;
            if(username!=username2|| password2!=password)
            {
                MessageBox.Show("Invalid!");
            }
            if (username == username2 && password2 == password)
            {
                MessageBox.Show("Log in Successful");
                Form4 form4 = new Form4();
                form4.Show();
                form4.AddItemToListBox(username);

            }
           
        }
    }
}
