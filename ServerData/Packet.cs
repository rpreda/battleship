using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;

namespace ServerData
{
    [Serializable]
    public class Packet 
    {
        
        public List<string> Gdata;
        public int packetInt;
        public bool packetBool;
        public string senderID;
        public PacketType packetType;

        public Packet(PacketType type, string senderID)
        {
            this.packetType = type;
            this.senderID = senderID;
            Gdata = new List<string>();
        }
        public Packet(byte[] array)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(array);
            Packet p = (Packet)bf.Deserialize(ms); //If editing fields in packet add them to the deserialize method :D
            ms.Close();
            this.Gdata = p.Gdata;
            this.packetBool = p.packetBool;
            this.packetInt = p.packetInt;
            this.packetType = p.packetType;
            this.senderID = p.senderID;
        }
        public byte[] ToBytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, this);
            byte[] ret_val = ms.ToArray();
            ms.Close();
            return (ret_val);
        }

        public static string getIP4Address()
        {
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress i in ips)
            {
                if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    return (i.ToString());
            }
            return ("127.0.0.1");
        }
    }

    public enum PacketType
    {
        NameSet,//Sets the name for the client data
        RoomList,//Returns the room list
        GetRooms,//Requests for the rooms
        Registration,//Tells tells the client the ID that he was assigned
        Message,//Sends a chat message to the server
        Sync//Broadcast chat message to all the clients
    }
}
