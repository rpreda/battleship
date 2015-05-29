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
        public delegate void UpdateList(UpdateListView data);
        public AddMessage myDelegate;
        public UpdateList listDelegate;
        private Network net;

        public Window()
        {
            InitializeComponent();
            myDelegate = new AddMessage(addMessage);
            listDelegate = new UpdateList(upListView);
        }

        public void upListView(UpdateListView data)//Delegate function for updating the list view
        {
            if (data.clear)
                listView1.Items.Clear();
            else
            {
                string[] row = { data.owner_name, data.room_id, data.max_players };
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        public void addMessage(string message)//Delegate function for updating the chat
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

        private void room_request_Click(object sender, EventArgs e)//refresh room list
        {
            Packet request_rooms = new Packet(PacketType.GetRooms, net.id);
            net.SendData(request_rooms);//The request system works at the moment but the list update isn't implemented yet
        }

        private void button3_Click(object sender, EventArgs e)//create room
        {
            Packet create_room = new Packet(PacketType.NewRoom, net.id);
            net.SendData(create_room);
        }

        private void button4_Click(object sender, EventArgs e)//delete room
        {
            Packet delete_room = new Packet(PacketType.DelRoom, net.id);
            net.SendData(delete_room);
        }

        private void button6_Click(object sender, EventArgs e)//Function for joining a room
        {
            Packet join_room = new Packet(PacketType.JoinRoom, net.id);

        }
    }
    public class UpdateListView
    {
        public string owner_name;
        public string room_id;
        public string max_players;
        public bool clear;

        public UpdateListView(bool clear)
        {
            this.clear = clear;
        }
    }
}
