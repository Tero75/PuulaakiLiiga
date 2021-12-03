using System;
namespace TeamManagerClassLibrary
{
    public class Coach
    {
        public int teamID;
        private int CoachID;
        public string name;

        public int coachID
        {
            get { return CoachID; }
            set { CoachID = value; }
        }

        public Coach()
        {
        }
    }
}
