using System;
using System.Collections.Generic;

namespace TeamManagerClassLibrary
{
    public class Game
    {
        private int GameID;
        public string DateTime;
        public int HomeTeam;
        public int VisitorTeam;
        public string EndResult;
        public string FieldPlayed;
        public List<int> penaltyIDs;
        public string OtherMatter;

        public int gameID
        {
            get { return GameID; }
            set { GameID = value; }
        }

        public Game()
        {
        }
    }
}
