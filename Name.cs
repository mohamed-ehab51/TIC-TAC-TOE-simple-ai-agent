using TIC_TAC_TOE;

namespace Complete_tic_tac_toe
{

    public partial class Name : Form
    {
        public static string player_name = "";
        public Name()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter your name");
            }
            else
            {
                player_name = textBox1.Text;
                VS_computer vS_com = new();
                this.Hide();
                vS_com.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start_form s = new();
            s.Show();
            this.Dispose();
        }
    }
}
