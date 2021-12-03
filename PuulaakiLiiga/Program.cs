using System;
using TeamManagerClassLibrary;
namespace PuulaakiLiiga
{
    class Program
    {
        static void Main(string[] args)
        {

            DataManager dataManager = new DataManager();

            ManagerMenu managerMenu = new ManagerMenu(dataManager);

            bool showMenu = true;
            while(showMenu)
            {
                showMenu = managerMenu.MainMenu();
            }

            Console.WriteLine("Kiitos ohjelman käytöstä. ");
            
        }
    }
}
