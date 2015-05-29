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

namespace Server
{

    class ClientData//This class represents a user that connected to the server
    {
        public Socket clientSocket;
        public Thread clientThread;
        public string id;
        public string name;
        public ClientData(Socket socket)
        {
            this.clientSocket = socket;
            id = Guid.NewGuid().ToString();
            clientThread = new Thread(Server.Data_IN);
            clientThread.Start(this.clientSocket);
            SendRegistrationPacket();
        }
        public void SendRegistrationPacket()
        {
            Packet p = new Packet(PacketType.Registration, id);
            Console.WriteLine("Client with ID " + id + " successfully connected!");
            clientSocket.Send(p.ToBytes());
        }
    }

    class Server
    {

        static Socket listenerSocket;
        static List<ClientData> _clients;
        static List<GameRoom> _rooms;

        static void Main(string[] args)
        {
            Console.WriteLine("Starting server on " + Packet.getIP4Address());
            listenerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream ,ProtocolType.Tcp);
            _clients = new List<ClientData>();
            _rooms = new List<GameRoom>();
            IPEndPoint end = new IPEndPoint(IPAddress.Parse(Packet.getIP4Address()), 4242);
            listenerSocket.Bind(end);
            Thread listenThread = new Thread(ListenThread);
            listenThread.Start();
            Thread commands = new Thread(CommandsThread);
            commands.Start();
        }
        static void CommandsThread()//Handles the commnads from the console :D
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "/exit")
                    Environment.Exit(0);
            }
        }
        static void ListenThread()
        {
            while (true)
            {
                listenerSocket.Listen(10);
                _clients.Add(new ClientData(listenerSocket.Accept()));
            }
        
        }
        public static void Data_IN(object cSocket)//Listener function (in separated thread for each client :)
        {
            Socket clientSocket = (Socket)cSocket;
            byte[] buffer;
            int readBytes;
            while (true)
            {
                buffer = new byte[clientSocket.SendBufferSize];
                try
                {
                    readBytes = clientSocket.Receive(buffer);
                    if (readBytes > 0)
                    {
                        Packet p = new Packet(buffer);
                        DataManager(p);//Function that handles data recieved from a client
                    }
                }
                catch// code in case of disconnect WORKS!! NUMBER 71
                {
                    ClientData client = null;
                    Thread current_thread;
                    foreach (ClientData i in _clients)
                    {
                        if (i.clientSocket == cSocket)
                        { 
                            foreach (GameRoom room in _rooms)
                            {
                                if (room.owner == i)
                                {
                                    _rooms.Remove(room);
                                    break;
                                }
                            }
                            Console.WriteLine("Client with ID " + i.id + " lost connection, unloading...");
                            client = i;
                            break;
                        }
                    }
                    if (client != null)
                    {
                        current_thread = client.clientThread;
                        _clients.Remove(client);
                        current_thread.Abort();
                    }
                }
            }
        }
        public static ClientData findClientById(string id)
        {
            foreach (ClientData i in _clients)
                if (i.id == id)
                    return (i);
            return (null);
        }
        public static void DataManager(Packet p)
        {
            switch (p.packetType)
            {
                case PacketType.NameSet://sets the name for the client data
                    foreach (ClientData i in _clients)
                    {
                        if (p.senderID == i.id)
                        {
                            i.name = p.Gdata[0];
                            Console.WriteLine("User with ID " + p.senderID + " has now the name " + i.name);
                            break;
                        }
                    }
                    break;


                case PacketType.Message://When a user sends a message print it in the console and broadcast it to all OTHER users
                    Console.WriteLine("User " + p.Gdata[0] + " with ID " + p.Gdata[2] + " said: " + p.Gdata[1]);
                    Packet sync = new Packet(PacketType.Sync, "Server");
                    sync.Gdata.Add(p.Gdata[0] + ":> " + p.Gdata[1]);
                    foreach (ClientData i in _clients)
                    {
                        if (i.id != p.Gdata[2])
                            i.clientSocket.Send(sync.ToBytes());
                    }
                    break;


                case PacketType.GetRooms://When the user requests the rooms the server will send them back
                    Console.WriteLine("User with ID " + p.senderID + " requested the room list");
                    Packet response = new Packet(PacketType.RoomList, "server");//Constructs a room list to send back to the client
                    //response.Gdata.Add("All good ^^");//TEMPORARY code ->works
                    foreach (GameRoom i in _rooms)
                    {
                        if (!i.gameOn)//checks if the game is not already running
                            response.Gdata.Add(i.owner.id + "~" + i.members.Count + "~" + i.owner.name);
                    }
                    ClientData client = findClientById(p.senderID);
                    if (client != null)
                        client.clientSocket.Send(response.ToBytes());//sends the room list back to the client
                    break;


                case PacketType.NewRoom://handles the creation of rooms probably saving the room that the user is part of in the user variable is necesary (probably!!!)
                    bool create = true;
                    Console.WriteLine("User with id " + p.senderID + " created a new room");
                    GameRoom new_room = new GameRoom(findClientById(p.senderID));
                    foreach (GameRoom i in _rooms)//checks if the user isn't already an owner
                    {
                        if (i.owner.id == p.senderID)
                        {
                            create = false;
                            break;
                        }
                    }
                    if (create)
                        _rooms.Add(new_room);
                    break;


                case PacketType.DelRoom://deletes the room
                    Console.WriteLine("User with id " + p.senderID + " deleted the room he owned");
                    ClientData userDel = findClientById(p.senderID);
                    GameRoom toDelete = null;
                    foreach (GameRoom i in _rooms)
                    {
                        if (i.owner == userDel)
                        {
                            toDelete = i;
                            break;
                        }
                    }
                    if (toDelete != null)
                       _rooms.Remove(toDelete);
                    break;

                //implement the join room function
            }
        }
    }
}
