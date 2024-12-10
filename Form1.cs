    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registraion_Click(object sender, EventArgs e)
        {
          Form2 form= new Form2();
            form.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form= new Form3();
            form.Show();
        }
    } 
        
}
