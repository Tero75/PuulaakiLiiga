using System;
namespace TeamManagerClassLibrary
{
    public class Player
    {
        public int teamID;
        private int PlayerID;
        public string name;
        public int PlayerNumber;
        public string position;

        public int playerID
        {
            get { return PlayerID; }
            set { PlayerID = value; }
        }

        public Player()
        {
        }
    }
}
