 public partial class Registraion : Form
 {
     public Registraion()
     {
         InitializeComponent();
     }
     private Dictionary<string, string> users = new Dictionary<string, string>
     {
         { "user1", "password1" },
         { "user2", "password2" },
         { "user3", "password3" }
     };

     private void button1_Click(object sender, EventArgs e)
     {
         string username = textBox1.Text;
         string password = textBox2.Text;
         string Repeatpassword = textBox3.Text;
         comboBox1.Items.Add(username);

     }
 }
