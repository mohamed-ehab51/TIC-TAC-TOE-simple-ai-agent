using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TIC_TAC_TOE;

namespace Complete_tic_tac_toe
{
    
    public partial class Names : Form
    {
        public static string player_1_name = "";
        public static string player_2_name = "";
        public Names()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""|| textBox2.Text=="")
            {
                MessageBox.Show("Please enter your names");
            }
            else
            {
                player_1_name = textBox1.Text;
                player_2_name = textBox2.Text;
                VS_player_on_same_pc vS_Player_On_Same_Pc = new();
                this.Hide();
                vS_Player_On_Same_Pc.Show();
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
