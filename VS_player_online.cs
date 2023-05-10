using System.Text;

namespace Complete_tic_tac_toe
{
    public partial class VS_player_online : Form
    {
        bool MY_Turn;
        int counter = 0;
        Thread t;
        public VS_player_online()
        {
            InitializeComponent();
            if (Online_Setup.host)
            {
                MY_Turn = true;
                label1.Text = Online_Setup.my_name + " -> X";
            }
            else
            {
                MY_Turn = false;
                label1.Text = Online_Setup.op_name + " -> X";
            }
            t = new(() => ReceiveMoves());
            t.Start();
        }
        void ReceiveMoves()
        {
            while (counter <= 9)
            {
                if (MY_Turn == false)
                {
                    byte[] dara = new byte[1024];
                    int bytesRead = Online_Setup.stream.Read(dara, 0, dara.Length);
                    if (bytesRead > 0)
                    {
                        string message = Encoding.UTF8.GetString(dara, 0, bytesRead);
                        Update_GUI(message);
                        if (counter >= 5)
                        {
                            check();
                        }
                        MY_Turn = true;
                    }
                }
            }
        }
        void check()
        {
            string Winner = "";
            if (Online_Setup.host)
            {

                if (counter % 2 == 0)
                {
                    Winner = Online_Setup.op_name;
                }
                else
                {
                    Winner = Online_Setup.my_name;
                }
            }
            else
            {
                if (counter % 2 == 0)
                {
                    Winner = Online_Setup.my_name;
                }
                else
                {
                    Winner = Online_Setup.op_name;
                }
            }
            if (counter == 9)
            {
                DialogResult = MessageBox.Show("Draw\ndo you want to play again ?", "", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    Application.Restart();
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
                        VS_player_online v = new();
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
                        Application.Restart();
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
                    Application.Restart();
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
                    Application.Restart();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
        string click()
        {
            if (Online_Setup.host)
            {

                if (counter % 2 == 0)
                {
                    counter++;
                    label1.Text = Online_Setup.op_name + " -> O";
                    return "X";
                }
                else
                {
                    counter++;
                    label1.Text = Online_Setup.my_name + " -> X";
                    return "O";
                }
            }
            else
            {
                if (counter % 2 == 0)
                {
                    counter++;
                    label1.Text = Online_Setup.my_name + " -> O";
                    return "X";
                }
                else
                {
                    counter++;
                    label1.Text = Online_Setup.op_name + " -> X";
                    return "O";
                }
            }
        }
        void Update_GUI(String M)
        {
            switch (M)
            {
                case "1":
                    button2.Invoke((MethodInvoker)delegate
                    {
                        button2.ForeColor = Color.Red;
                        button2.Text = click();
                    });
                    break;
                case "2":
                    button3.Invoke((MethodInvoker)delegate
                    {
                        button3.ForeColor = Color.Red;
                        button3.Text = click();
                    });
                    break;
                case "3":
                    button4.Invoke((MethodInvoker)delegate
                    {
                        button4.ForeColor = Color.Red;
                        button4.Text = click();
                    });
                    break;
                case "4":
                    button5.Invoke((MethodInvoker)delegate
                    {
                        button5.ForeColor = Color.Red;
                        button5.Text = click();
                    });
                    break;
                case "5":
                    button6.Invoke((MethodInvoker)delegate
                    {
                        button6.ForeColor = Color.Red;
                        button6.Text = click();
                    });
                    break;
                case "6":
                    button7.Invoke((MethodInvoker)delegate
                    {
                        button7.ForeColor = Color.Red;
                        button7.Text = click();
                    });
                    break;
                case "7":
                    button8.Invoke((MethodInvoker)delegate
                    {
                        button8.ForeColor = Color.Red;
                        button8.Text = click();
                    });
                    break;
                case "8":
                    button9.Invoke((MethodInvoker)delegate
                    {
                        button9.ForeColor = Color.Red;
                        button9.Text = click();
                    });
                    break;
                case "9":
                    button10.Invoke((MethodInvoker)delegate
                    {
                        button10.ForeColor = Color.Red;
                        button10.Text = click();
                    });
                    break;
                default:
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button2.ForeColor = Color.Red;
                button2.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("1");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button3.ForeColor = Color.Red;
                button3.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("2");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button4.ForeColor = Color.Red;
                button4.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("3");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button5.ForeColor = Color.Red;
                button5.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("4");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button6.ForeColor = Color.Red;
                button6.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("5");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button7.ForeColor = Color.Red;
                button7.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("6");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button8.ForeColor = Color.Red;
                button8.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("7");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button9.ForeColor = Color.Red;
                button9.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("8");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.ForeColor != Color.Red && MY_Turn == true)
            {
                MY_Turn = false;
                button10.ForeColor = Color.Red;
                button10.Text = click();
                byte[] data = Encoding.UTF8.GetBytes("9");
                Online_Setup.stream.Write(data, 0, data.Length);
                if (counter >= 5)
                {
                    check();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Online_Setup O = new();
            O.Show();
            this.Dispose();
        }

        private void VS_player_online_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
