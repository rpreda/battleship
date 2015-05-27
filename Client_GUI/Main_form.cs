using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_GUI
{
    public partial class Main_form : Form
    {
        public static string ip;
        public static string username;
        public Main_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server_dialog connection_info = new Server_dialog();
            connection_info.Show();
            this.button1.Hide();
        }

        private void debug_Click(object sender, EventArgs e)
        {
        }
    }
}
