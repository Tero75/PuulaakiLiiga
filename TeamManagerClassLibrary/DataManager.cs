using System;
using System.Collections.Generic;
using Dapper;

namespace TeamManagerClassLibrary
{
    public class DataManager
    {
        

        static private int getID()
        {
            int counter = 0;
            counter++;
            return counter;
        }

        public Player CreatePlayer()
        {
            Player player = new Player();
            Console.WriteLine("Players teamnumber");
            player.teamID = Convert.ToInt32(Console.ReadLine());
            player.playerID = getID();
            Console.WriteLine("Players name: ");
            player.name = Console.ReadLine();
            Console.WriteLine("Player a playernumber: ");
            player.PlayerNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Players position: ");
            player.position = Console.ReadLine();

            return player;
        }

        public Coach CreateCoach()
        {
            Coach coach = new Coach();
            coach.coachID = getID();
            Console.WriteLine("Give coach teamID: ");
            coach.teamID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            coach.name = Console.ReadLine();
            return coach;
        }

        public Team createTeam()
        {
            Team team = new Team();
            team.teamID = getID();
            Console.WriteLine("Give team a name: ");
            team.TeamName = Console.ReadLine();
            Console.WriteLine("Teams coachID: ");
            team.coachID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teams contacts contactID: ");
            team.contactID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Teams players PlayerIDs: ");
            team.playerID.AddRange(new List<int>{Convert.ToInt32(Console.ReadLine())});
            return team;
        }

        public ContactInfo CreateContactInfo()
        {
            ContactInfo contact = new ContactInfo();
            contact.contactID = getID();
            Console.WriteLine("Give contact a name: ");
            contact.ContactName = Console.ReadLine();
            Console.WriteLine("Contacts phonenumber: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Contacts E-mail addres: ");
            contact.Email = Console.ReadLine();
            return contact;
        }

        public Game CreateGame()
        {
            Game game = new Game();
            game.gameID = getID();
            Console.WriteLine("Give game a date: ");
            game.DateTime = Console.ReadLine();
            Console.WriteLine("Hometeam ID: ");
            game.HomeTeam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Visitorteam ID:");
            game.VisitorTeam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Game endresult: ");
            game.EndResult = Console.ReadLine();
            Console.WriteLine("Field game played: ");
            game.FieldPlayed = Console.ReadLine();
            Console.WriteLine("PenaltyIDs");
            game.penaltyIDs.AddRange(new List<int> { Convert.ToInt32(Console.ReadLine()) });
            Console.WriteLine("Other matter: ");
            game.OtherMatter = Console.ReadLine();
            return game;
        }

        public Penalty CreatePenalty()
        {
            Penalty penalty = new Penalty();
            penalty.penaltyID = getID();
            Console.WriteLine("PlayerID penalty given: ");
            penalty.playerID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Penalty given: ");
            penalty.Reason = Console.ReadLine();
            return penalty;
        }






        public DataManager()
        {
        }
    }
}
