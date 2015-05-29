using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServerData;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;

namespace Client
{
    class Client
    {
        public static Socket master;
        public static string name;
        public static string ID;
        static void Main(string[] args)
        {
            ID = Guid.NewGuid().ToString();
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
            Console.WriteLine("Enter host IP");
            string ip = Console.ReadLine();
            master = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint end = new IPEndPoint(IPAddress.Parse(ip), 4242);
            try
            {
                master.Connect(end);
            }
            catch
            {
                Console.WriteLine("Unable to connect to server");
            }
            Thread input_thread = new Thread(DATA_IN);
            input_thread.Start();
            Console.WriteLine("Listener thread started...");
            while (true)
            {
                Console.Write(">");
                string input = Console.ReadLine();
                if (input == "/exit")
                {
                    input_thread.Abort();
                    master.Close();
                    Environment.Exit(0);
                }
                Packet p = new Packet(PacketType.Message, ID);
                p.Gdata.Add(name);
                p.Gdata.Add(input);
                p.Gdata.Add(ID);
                master.Send(p.ToBytes());
            }
        }
        static void DATA_IN()
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
        static void DataManager(Packet p)
        {
            switch(p.packetType)
            {
                case PacketType.Registration:
                    Console.WriteLine("Registered on server" + p.senderID);
                    ID = p.senderID;
                    break;
                case PacketType.Sync:
                    Console.WriteLine(p.Gdata[0]);
                    break;
            }
        }
    }
}
