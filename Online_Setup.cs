using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Complete_tic_tac_toe
{
    public partial class Online_Setup : Form
    {
        public Online_Setup()
        {
            InitializeComponent();
            string hostName = Dns.GetHostName();
            IPHostEntry hostEntry = Dns.GetHostEntry(hostName);
            IPAddress[] ipAddresses = hostEntry.AddressList;
            string message = "Your IP address(es):\n";
            foreach (IPAddress ipAddress in ipAddresses)
            {
                message += ipAddress.ToString() + "\n";
            }
            Clipboard.SetText(message);
            label3.Text = message + "\n these data are copied to your clipboard";
        }
        public static NetworkStream stream;
        public static bool host;
        public static string op_name;
        public static string my_name;
        private void button1_Click(object sender, EventArgs e)
        {
            my_name = your_name.Text;
            if (radioButton1.Checked)
            {
                radioButton2.Enabled = false;
                Thread t;
                t = new(() => {host = true;
                TcpListener listener = new TcpListener(IPAddress.Any, 12345);
                listener.Start();
                MessageBox.Show("Waiting", "Wait");
                TcpClient client = listener.AcceptTcpClient();
                stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(your_name.Text);
                Online_Setup.stream.Write(data, 0, data.Length);
                byte[] dara = new byte[1024];
                int bytesRead = Online_Setup.stream.Read(dara, 0, dara.Length);
                if (bytesRead > 0)
                {
                    string message = Encoding.UTF8.GetString(dara, 0, bytesRead);
                    MessageBox.Show("Your opponent name is : " + message, "opponent");
                    op_name = message;
                }
                VS_player_online o = new();
                o.Show();
                this.Hide(); });
                t.Start();
            }
            else
            {
                Thread t;
                t = new(() => { 
                host = false;
                string hostAddress = Host_IP.Text;
                TcpClient client = new TcpClient();
                client.Connect(hostAddress, 12345);
                stream = client.GetStream();
                byte[] data = Encoding.UTF8.GetBytes(your_name.Text);
                Online_Setup.stream.Write(data, 0, data.Length);
                byte[] dara = new byte[1024];
                int bytesRead = Online_Setup.stream.Read(dara, 0, dara.Length);
                if (bytesRead > 0)
                {
                    string message = Encoding.UTF8.GetString(dara, 0, bytesRead);
                    MessageBox.Show("Your opponent name is : " + message, "opponent");
                    op_name = message;
                }
                VS_player_online o = new();
                o.Show();
                this.Hide();
                });
                t.Start();
            }
        }

        private void Online_Setup_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Start_form s = new();
            s.Show();
            this.Dispose();
        }

        private void Online_Setup_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}
