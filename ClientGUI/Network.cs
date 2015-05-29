using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using ServerData;

namespace ClientGUI
{
    class Network
    {
        public string ip;
        public string id;
        public string name;
        public Window main_window;
        public static Socket master;

        public Network(string ip, string name, Window main)
        {
            this.ip = ip;
            this.name = name;
            this.main_window = main;
            IPEndPoint end = null;
            master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                end = new IPEndPoint(IPAddress.Parse(ip), 4242);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Invalid ip address");
                Environment.Exit(1);
            }

            try
            {
                master.Connect(end);
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Failed to connect, will exit");
                Environment.Exit(2);
            }
            Thread input_thread = new Thread(DATA_IN);
            input_thread.IsBackground = true;
            input_thread.Start();
        }
        private void DATA_IN()
        {
            byte[] buffer;
            int readBytes;
            while (true)
            {
                buffer = new byte[master.SendBufferSize];
                readBytes = master.Receive(buffer);
                if (readBytes > 0)
                {
                    DataManager(new Packet(buffer));
                }
            }
        }
        private void DataManager(Packet p)//function that handles the recieved packets from the server
        {
            string output;
            switch (p.packetType)
            {
                case PacketType.Registration:
                    output = "Registered on server" + p.senderID;
                    main_window.Invoke(main_window.myDelegate, new Object[] {output});//Console.WriteLine("Registered on server" + p.senderID);//Output
                    id = p.senderID;
                    Packet set_name = new Packet(PacketType.NameSet, id);
                    set_name.Gdata.Add(this.name);
                    master.Send(set_name.ToBytes());
                    break;
                case PacketType.Sync:
                    output = p.Gdata[0];//Output
                    main_window.Invoke(main_window.myDelegate, new Object[] { output });
                    break;
                case PacketType.RoomList:
                    UpdateListView clear = new UpdateListView(true);
                    main_window.Invoke(main_window.listDelegate, new Object[] { clear });
                    foreach (string i in p.Gdata)
                    {
                        string[] res = i.Split(new char[] {'~'});
                        UpdateListView add_item = new UpdateListView(false);
                        add_item.room_id = res[0];
                        add_item.max_players = res[1];
                        add_item.owner_name = res[2];
                        main_window.Invoke(main_window.listDelegate, new Object[] { add_item });
                    }
                    //output = p.Gdata[0];//temporary test code ->WORKS
                    //main_window.Invoke(main_window.myDelegate, new Object[] { output });//temporary test code
                    //Needs to update the listbox with the recieved information (delegate)
                    break;
            }
        }
        public void SendData(Packet p)
        {
            master.Send(p.ToBytes());
        }
    }
}
