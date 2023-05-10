using TIC_TAC_TOE;

namespace Complete_tic_tac_toe
{
    public partial class Start_form : Form
    {
        public Start_form()
        {
            InitializeComponent();
        }

        private void Start_button_Click(object sender, EventArgs e)
        {
            if (VS_computer_RB.Checked)
            {
                Name vS_Computer_name = new();
                this.Hide();
                vS_Computer_name.Show();
            }
            else if (VS_friend_online_RB.Checked)
            {
                Online_Setup vS_Player_Online = new();
                this.Hide();
                vS_Player_Online.Show();
            }
            else
            {
                Names NAme = new();
                this.Hide();
                NAme.Show();
            }
        }
    }
}
