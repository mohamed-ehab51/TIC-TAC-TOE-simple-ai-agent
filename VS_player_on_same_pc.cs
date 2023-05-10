using Complete_tic_tac_toe;

namespace TIC_TAC_TOE
{
    public partial class VS_player_on_same_pc : Form
    {
        public VS_player_on_same_pc()
        {
            InitializeComponent();
            label1.Text = Names.player_1_name + " -> X";
        }
        int counter = 0;
        string click()
        {
            if (counter % 2 == 0)
            {
                counter++;
                label1.Text = Names.player_2_name + " -> O";
                return "X";
            }
            else
            {
                counter++;
                label1.Text = Names.player_1_name + " -> X";
                return "O";
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ForeColor != Color.Red)
            {
                button2.ForeColor = Color.Red;
                button2.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.ForeColor != Color.Red)
            {
                button3.ForeColor = Color.Red;
                button3.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.ForeColor != Color.Red)
            {
                button4.ForeColor = Color.Red;
                button4.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.ForeColor != Color.Red)
            {
                button5.ForeColor = Color.Red;
                button5.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.ForeColor != Color.Red)
            {
                button6.ForeColor = Color.Red;
                button6.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.ForeColor != Color.Red)
            {
                button7.ForeColor = Color.Red;
                button7.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.ForeColor != Color.Red)
            {
                button8.ForeColor = Color.Red;
                button8.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.ForeColor != Color.Red)
            {
                button9.ForeColor = Color.Red;
                button9.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.ForeColor != Color.Red)
            {
                button10.ForeColor = Color.Red;
                button10.Text = click();
                if (counter >= 5)
                {
                    check();
                }
            }
        }
        void check()
        {
            string Winner = "";
            if (counter % 2 == 0)
            {
                Winner = Names.player_2_name;
            }
            else
            {
                Winner = Names.player_1_name;
            }
            if (counter == 9)
            {
                DialogResult = MessageBox.Show("Draw\ndo you want to play again ?", "", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    VS_player_on_same_pc v = new();
                    v.Show();
                    this.Dispose();
                }
                else
                {
                    Application.Exit();
                }
            }
            Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };

            for (int i = 0; i < 9; i += 3) //rows loop
            {
                if ((arr[i].Text == arr[i + 1].Text) && (arr[i + 1].Text == arr[i + 2].Text) && arr[i].Text != "")
                {

                    DialogResult = MessageBox.Show(Winner + " won\ndo you want to play again ?", "", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        VS_player_on_same_pc v = new();
                        v.Show();
                        this.Dispose();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            for (int i = 0; i < 3; i++) //columns loop
            {
                if ((arr[i].Text == arr[i + 3].Text) && (arr[i + 3].Text == arr[i + 6].Text) && arr[i].Text != "")
                {
                    DialogResult = MessageBox.Show(Winner + " won\ndo you want to play again ?", "", MessageBoxButtons.YesNo);
                    if (DialogResult == DialogResult.Yes)
                    {
                        VS_player_on_same_pc v = new();
                        v.Show();
                        this.Dispose();
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            //diagonals test
            if ((arr[0].Text == arr[4].Text) && (arr[4].Text == arr[8].Text) && arr[0].Text != "")
            {
                DialogResult = MessageBox.Show(Winner + " won\ndo you want to play again ?", "", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    VS_player_on_same_pc v = new();
                    v.Show();
                    this.Dispose();
                }
                else
                {
                    Application.Exit();
                }
            }
            if ((arr[2].Text == arr[4].Text) && (arr[4].Text == arr[6].Text) && arr[2].Text != "")
            {
                DialogResult = MessageBox.Show(Winner + " won\ndo you want to play again ?", "", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    VS_player_on_same_pc v = new();
                    v.Show();
                    this.Dispose();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Names n = new();
            n.Show();
            this.Dispose();
        }
    }
}
