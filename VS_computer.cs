using Complete_tic_tac_toe;
using System.Timers;
using Timer = System.Timers.Timer;

namespace TIC_TAC_TOE
{
    public partial class VS_computer : Form
    {
        public VS_computer()
        {
            InitializeComponent();
            label1.Text = Complete_tic_tac_toe.Name.player_name + " -> X";
        }
        int counter = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.ForeColor != Color.Red)
            {
                button2.ForeColor = Color.Red;
                button2.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.ForeColor != Color.Red)
            {
                button3.ForeColor = Color.Red;
                button3.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.ForeColor != Color.Red)
            {
                button4.ForeColor = Color.Red;
                button4.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();

            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.ForeColor != Color.Red)
            {
                button5.ForeColor = Color.Red;
                button5.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.ForeColor != Color.Red)
            {
                button6.ForeColor = Color.Red;
                button6.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();

            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.ForeColor != Color.Red)
            {
                button7.ForeColor = Color.Red;
                button7.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();

            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.ForeColor != Color.Red)
            {
                button8.ForeColor = Color.Red;
                button8.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();

            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.ForeColor != Color.Red)
            {
                button9.ForeColor = Color.Red;
                button9.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.ForeColor != Color.Red)
            {
                button10.ForeColor = Color.Red;
                button10.Text = "X";
                counter++;
                if (counter >= 5)
                {
                    check();
                }
                Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
                foreach (Button item in arr)
                {
                    if (item.ForeColor != Color.Red)
                    {
                        item.Enabled = false;
                    }
                }
                Timer timer = new Timer();
                timer.Interval = 1000; // 1 second delay
                timer.Elapsed += OnTimedEvent;
                timer.AutoReset = false;
                timer.Start();
            }
        }
        void check(string Winner = "You")
        {
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
                        Application.Restart();
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
        void Computer()
        {
            Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
            if (counter == 1)
            {
                Random random = new Random();
                int random_number = random.Next(0, 8);
                while (arr[random_number].Text != "")
                {
                    random_number = random.Next(0, 8);
                }
                arr[random_number].Invoke((MethodInvoker)delegate
                {
                    arr[random_number].ForeColor = Color.Red;
                    arr[random_number].Text = "O";
                });
                counter++;
                return;
            }
            else
            {
                for (int i = 0; i < 9; i += 3) //rows loop to win
                {
                    if ((arr[i].Text == arr[i + 1].Text) && arr[i].Text == "O" && arr[i + 2].Text == "")
                    {
                        arr[i + 2].Invoke((MethodInvoker)delegate
                        {
                            arr[i + 2].ForeColor = Color.Red;
                            arr[i + 2].Text = "O";
                        });
                        counter++;
                        return;
                    }
                    if ((arr[i + 1].Text == arr[i + 2].Text) && arr[i + 1].Text == "O" && arr[i].Text == "")
                    {
                        arr[i].Invoke((MethodInvoker)delegate
                        {
                            arr[i].ForeColor = Color.Red;
                            arr[i].Text = "O";
                        });
                        counter++;




                        return;
                    }
                    if ((arr[i].Text == arr[i + 2].Text) && arr[i].Text == "O" && arr[i + 1].Text == "")
                    {
                        arr[i + 1].Invoke((MethodInvoker)delegate
                        {
                            arr[i + 1].ForeColor = Color.Red;
                            arr[i + 1].Text = "O";
                        });
                        counter++;



                        return;
                    }
                }
                for (int i = 0; i < 3; i++) //columns loop to win
                {
                    if ((arr[i].Text == arr[i + 3].Text) && arr[i].Text == "O" && arr[i + 6].Text == "")
                    {
                        arr[i + 6].Invoke((MethodInvoker)delegate
                        {
                            arr[i + 6].ForeColor = Color.Red;
                            arr[i + 6].Text = "O";
                        });
                        counter++;



                        return;
                    }
                    if ((arr[i].Text == arr[i + 6].Text) && arr[i].Text == "O" && arr[i + 3].Text == "")
                    {
                        arr[i + 3].Invoke((MethodInvoker)delegate
                        {
                            arr[i + 3].ForeColor = Color.Red;
                            arr[i + 3].Text = "O";
                        });
                        counter++;



                        return;
                    }
                    if ((arr[i + 3].Text == arr[i + 6].Text) && arr[i + 3].Text == "O" && arr[i].Text == "")
                    {
                        arr[i].Invoke((MethodInvoker)delegate
                        {
                            arr[i].ForeColor = Color.Red;
                            arr[i].Text = "O";
                        });
                        counter++;



                        return;
                    }
                }
                if ((arr[0].Text == arr[4].Text) && arr[0].Text == "O" && arr[8].Text == "")
                {
                    arr[8].Invoke((MethodInvoker)delegate
                    {
                        arr[8].ForeColor = Color.Red;
                        arr[8].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[4].Text == arr[8].Text) && arr[4].Text == "O" && arr[0].Text == "")
                {
                    arr[0].Invoke((MethodInvoker)delegate
                    {
                        arr[0].ForeColor = Color.Red;
                        arr[0].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[0].Text == arr[8].Text) && arr[0].Text == "O" && arr[4].Text == "")
                {
                    arr[4].Invoke((MethodInvoker)delegate
                    {
                        arr[4].ForeColor = Color.Red;
                        arr[4].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[2].Text == arr[4].Text) && arr[2].Text == "O" && arr[6].Text == "")
                {
                    arr[6].Invoke((MethodInvoker)delegate
                    {
                        arr[6].ForeColor = Color.Red;
                        arr[6].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[4].Text == arr[6].Text) && arr[4].Text == "O" && arr[2].Text == "")
                {
                    arr[2].Invoke((MethodInvoker)delegate
                        {
                            arr[2].ForeColor = Color.Red;
                            arr[2].Text = "O";
                        });
                    counter++;



                    return;
                }
                if ((arr[2].Text == arr[6].Text) && arr[2].Text == "O" && arr[4].Text == "")
                {
                    arr[4].Invoke((MethodInvoker)delegate
                    {
                        arr[4].ForeColor = Color.Red;
                        arr[4].Text = "O";
                    });
                    counter++;



                    return;
                }
                /**********************************************************************************************************************/
                for (int i = 0; i < 9; i += 3) //rows loop to play
                {
                    if ((arr[i].Text == arr[i + 1].Text) && arr[i].Text == "X" && arr[i + 2].Text == "")
                    {
                        arr[i + 2].Invoke((MethodInvoker)delegate
                        {
                            arr[i + 2].ForeColor = Color.Red;
                            arr[i + 2].Text = "O";
                        });
                        counter++;



                        return;
                    }
                    if ((arr[i + 1].Text == arr[i + 2].Text) && arr[i + 1].Text == "X" && arr[i].Text == "")
                    {
                        arr[i].Invoke((MethodInvoker)delegate
                        {
                            arr[i].ForeColor = Color.Red;
                            arr[i].Text = "O";
                        });
                        counter++;




                        return;
                    }
                    if ((arr[i].Text == arr[i + 2].Text) && arr[i].Text == "X" && arr[i + 1].Text == "")
                    {
                        arr[i + 1].Invoke((MethodInvoker)delegate
                        {
                            arr[i + 1].ForeColor = Color.Red;
                            arr[i + 1].Text = "O";
                        });
                        counter++;



                        return;
                    }
                }
                for (int i = 0; i < 3; i++) //columns loop to play
                {
                    if ((arr[i].Text == arr[i + 3].Text) && arr[i].Text == "X" && arr[i + 6].Text == "")
                    {
                        arr[i + 6].Invoke((MethodInvoker)delegate
                        {
                            arr[i + 6].ForeColor = Color.Red;
                            arr[i + 6].Text = "O";
                        });
                        counter++;



                        return;
                    }
                    if ((arr[i].Text == arr[i + 6].Text) && arr[i].Text == "X" && arr[i + 3].Text == "")
                    {
                        arr[i + 3].Invoke((MethodInvoker)delegate
                        {
                            arr[i + 3].ForeColor = Color.Red;
                            arr[i + 3].Text = "O";
                        });
                        counter++;



                        return;
                    }
                    if ((arr[i + 3].Text == arr[i + 6].Text) && arr[i + 3].Text == "X" && arr[i].Text == "")
                    {
                        arr[i].Invoke((MethodInvoker)delegate
                        {
                            arr[i].ForeColor = Color.Red;
                            arr[i].Text = "O";
                        });
                        counter++;



                        return;
                    }
                }
                if ((arr[0].Text == arr[4].Text) && arr[0].Text == "X" && arr[8].Text == "")
                {
                    arr[8].Invoke((MethodInvoker)delegate
                    {
                        arr[8].ForeColor = Color.Red;
                        arr[8].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[4].Text == arr[8].Text) && arr[4].Text == "X" && arr[0].Text == "")
                {
                    arr[0].Invoke((MethodInvoker)delegate
                    {
                        arr[0].ForeColor = Color.Red;
                        arr[0].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[0].Text == arr[8].Text) && arr[0].Text == "X" && arr[4].Text == "")
                {
                    arr[4].Invoke((MethodInvoker)delegate
                    {
                        arr[4].ForeColor = Color.Red;
                        arr[4].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[2].Text == arr[4].Text) && arr[2].Text == "X" && arr[6].Text == "")
                {
                    arr[6].Invoke((MethodInvoker)delegate
                    {
                        arr[6].ForeColor = Color.Red;
                        arr[6].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[4].Text == arr[6].Text) && arr[4].Text == "X" && arr[2].Text == "")
                {
                    arr[2].Invoke((MethodInvoker)delegate
                    {
                        arr[2].ForeColor = Color.Red;
                        arr[2].Text = "O";
                    });
                    counter++;



                    return;
                }
                if ((arr[2].Text == arr[6].Text) && arr[2].Text == "X" && arr[4].Text == "")
                {
                    arr[4].Invoke((MethodInvoker)delegate
                    {
                        arr[4].ForeColor = Color.Red;
                        arr[4].Text = "O";
                    });
                    counter++;
                    return;
                }
                Random random = new Random();
                int random_number = random.Next(0, 8);
                while (arr[random_number].Text != "")
                {
                    random_number = random.Next(0, 8);
                }
                arr[random_number].Invoke((MethodInvoker)delegate
                {
                    arr[random_number].ForeColor = Color.Red;
                    arr[random_number].Text = "O";
                });
                counter++;



                return;
            }
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            // Computer makes its move
            Computer();
            //release the buttons
            Button[] arr = { button2, button3, button4, button5, button6, button7, button8, button9, button10 };
            foreach (Button item in arr)
            {
                if (item.Enabled == false)
                {
                    item.Invoke((MethodInvoker)delegate
                    {
                        item.Enabled = true;
                    });
                }
            }
            // Check the board
            check("The computer");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Name n = new();
            n.Show();
            this.Dispose();
        }
    }
}
