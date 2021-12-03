using System;
using System.Collections.Generic;

namespace TeamManagerClassLibrary
{
    public class Team
    {
        private int TeamID;
        public string TeamName;
        public int coachID;
        public  List<int> playerID;
        public int contactID;

        public int teamID
        {
            get { return TeamID; }
            set { TeamID = value; }
        }

        public Team()
        {
        }
    }
}
