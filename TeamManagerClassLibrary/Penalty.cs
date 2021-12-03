using System;
namespace TeamManagerClassLibrary
{
    public class Penalty
    {
        private int PenaltyID;
        public int playerID;
        public string Reason;

        public int penaltyID
        {
            get { return PenaltyID; }
            set { PenaltyID = value; }
        }

        public Penalty()
        {
        }
    }
}
