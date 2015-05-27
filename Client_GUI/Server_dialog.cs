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
    public partial class Server_dialog : Form
    {
        public Server_dialog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ip_connect.Text != "" && username_connect.Text != "")
            {
                Main_form.username = username_connect.Text;
                Main_form.ip = ip_connect.Text;
                this.Close();
            }
        }
    }
}
