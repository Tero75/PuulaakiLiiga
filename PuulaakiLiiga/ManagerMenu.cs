using System;
using TeamManagerClassLibrary;

namespace PuulaakiLiiga
{
    public class ManagerMenu
    {
        private DataManager dataManager;

        public DataManager DataManager
        {
            get { return dataManager; }
            
        }

        public ManagerMenu(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add player");
            Console.WriteLine("2. Add team");
            Console.WriteLine("3. Add coach");
            Console.WriteLine("4. Add new contact");
            Console.WriteLine("5. Add penalty");
            Console.WriteLine("6. Add game");
            Console.WriteLine("7. EXIT");


            bool succes = Int32.TryParse(Console.ReadLine(), out int result);

            if (succes)
            {
                  switch(result)
                  {
                    case 1:
                        dataManager.CreatePlayer();
                        Console.ReadKey();
                        return true;
                    case 2:
                         dataManager.createTeam();
                         Console.ReadKey();
                         return true;
                    case 3:
                         dataManager.CreateCoach();
                         Console.ReadKey();
                         return true;
                    case 4:
                         dataManager.CreateContactInfo();
                         Console.ReadKey();
                         return true;
                    case 5:
                         dataManager.CreatePenalty();
                         Console.ReadKey();
                         return true;
                    case 6:
                         dataManager.CreateGame();
                         Console.ReadKey();
                         return true;
                    case 7:
                         Console.ReadKey();
                         return false;
                    default:
                         return true;
                }
            }
            else
            {
                Console.WriteLine("Invalid key! Please try again!");
                Console.ReadKey();
                return true;

            }

        }

        public ManagerMenu()
        {
        }
    }
}
