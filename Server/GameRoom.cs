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
    class GameRoom//The actual game instances
    {
        public ClientData owner;
        public List<ClientData> members;
        private const int maxPlayers = 1;
        public bool gameOn;
        //2 in total with the owner, here is the max player number
        //should save here somwehre the game state, if it started, where is the shit on the map etc.... here the game logic will rest

        public GameRoom(ClientData owner)
        {
            this.owner = owner;
            gameOn = false;//Means game didn't start yet so the room should be returned when the room list is requested
            members = new List<ClientData>();
        }
        public void addMember(ClientData member)
        {
            if (members.Count < maxPlayers && !members.Contains(member))//checks if the member isn't already in and if the max player number is okay
                members.Add(member);
        }
        public void removeMember(ClientData member)
        {
            members.Remove(member);
        }
    }
}
