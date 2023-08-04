using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPace_Cricket_Academy
{
    public class OneDayTeam : ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public OneDayTeam()
        {
            // Set the capacity property to 11
            oneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            if (oneDayTeam.Count < 11)
            {
                oneDayTeam.Add(player);
                Console.WriteLine("Player added successfully!");
            }
            else
            {
                Console.WriteLine("Team is already full. Cannot add more players.");
            }
        }

        public void Remove(int playerId)
        {
            Player playerToRemove = oneDayTeam.Find(p => p.PlayerId == playerId);
            if (playerToRemove != null)
            {
                oneDayTeam.Remove(playerToRemove);
                Console.WriteLine("Player removed successfully!");
            }
            else
            {
                Console.WriteLine("Player not found in the team. Cannot remove.");
            }
        }

        public Player GetPlayerById(int playerId)
        {
            Player player = oneDayTeam.Find(p => p.PlayerId == playerId);
            return player;
        }

        public Player GetPlayerByName(string playerName)
        {
            Player player = oneDayTeam.Find(p => p.PlayerName == playerName);
            return player;
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }
    }
}
