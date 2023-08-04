using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPace_Cricket_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OneDayTeam team = new OneDayTeam();
            int choice;
            do
            {
                Console.WriteLine("Enter 1: To Add Player");
                Console.WriteLine("Enter 2: To Remove Player by Id");
                Console.WriteLine("Enter 3: Get Player By Id");
                Console.WriteLine("Enter 4: Get Player by Name");
                Console.WriteLine("Enter 5: Get All Players");
                Console.WriteLine("Enter 0: Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Player Id: ");
                        int playerId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Player Name: ");
                        string playerName = Console.ReadLine();
                        Console.WriteLine("Enter Player Age: ");
                        int playerAge = Convert.ToInt32(Console.ReadLine());
                        Player playerToAdd = new Player { PlayerId = playerId, PlayerName = playerName, PlayerAge = playerAge };
                        team.Add(playerToAdd);
                        break;
                    case 2:
                        Console.WriteLine("Enter Player Id to remove: ");
                        int playerIdToRemove = Convert.ToInt32(Console.ReadLine());
                        team.Remove(playerIdToRemove);
                        break;
                    case 3:
                        Console.WriteLine("Enter Player Id: ");
                        int playerIdToGet = Convert.ToInt32(Console.ReadLine());
                        Player playerById = team.GetPlayerById(playerIdToGet);
                        if (playerById != null)
                        {
                            Console.WriteLine("Player Id: " + playerById.PlayerId);
                            Console.WriteLine("Player Name: " + playerById.PlayerName);
                            Console.WriteLine("Player Age: " + playerById.PlayerAge);
                        }
                        else
                        {
                            Console.WriteLine("Player not found with the given Id.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter Player Name: ");
                        string playerNameToGet = Console.ReadLine();
                        Player playerByName = team.GetPlayerByName(playerNameToGet);
                        if (playerByName != null)
                        {
                            Console.WriteLine("Player Id: " + playerByName.PlayerId);
                            Console.WriteLine("Player Name: " + playerByName.PlayerName);
                            Console.WriteLine("Player Age: " + playerByName.PlayerAge);
                        }
                        else
                        {
                            Console.WriteLine("Player not found with the given Name.");
                        }
                        break;
                    case 5:
                        List<Player> allPlayers = team.GetAllPlayers();
                        Console.WriteLine("All Players in the team: ");
                        foreach (Player player in allPlayers)
                        {
                            Console.WriteLine("Player Id: " + player.PlayerId);
                            Console.WriteLine("Player Name: " + player.PlayerName);
                            Console.WriteLine("Player Age: " + player.PlayerAge);
                            
                        }
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid input! Please try again.");
                        break;
                }

                Console.WriteLine("Do you want to continue? (yes/no)");
                string continueChoice = Console.ReadLine();
                if (continueChoice.ToLower() != "yes")
                {
                    break;
                }

            } while (true);
        }
    }
}
    

        
    

