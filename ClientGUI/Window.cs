using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServerData;

namespace ClientGUI
{
    public partial class Window : Form
    {
        public delegate void AddMessage(string message);
        public AddMessage myDelegate;
        private Network net;
        public Window()
        {
            InitializeComponent();
            myDelegate = new AddMessage(addMessage);
        }

        public void addMessage(string message)
        {
            chat.Text += message + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ip_text.Text != "" && name_text.Text != "")
            {
                net = new Network(ip_text.Text, name_text.Text, this);
                ip_text.ReadOnly = true;
                name_text.ReadOnly = true;
                button1.Enabled = false;
            }
        }

        private void chat_send_Click(object sender, EventArgs e)
        {
            if (chat_message.Text != "")
            {
                Packet toGo = new Packet(PacketType.Message, net.id);
                toGo.Gdata.Add(net.name);
                toGo.Gdata.Add(chat_message.Text);
                toGo.Gdata.Add(toGo.senderID);
                net.SendData(toGo);
                addMessage(net.name + ": " + chat_message.Text);
                chat_message.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)//debug button
        {
            GameWindow win = new GameWindow();
            win.Show();
        }

        private void room_request_Click(object sender, EventArgs e)
        {
            Packet request_rooms = new Packet(PacketType.GetRooms, net.id);
            net.SendData(request_rooms);//The request system works at the moment but the list update isn't implemented yet
        }
    }
}
