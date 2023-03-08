namespace Game1
{
    public class TeamA
    {
        private string TeamName;
        private int deaths;
        private int kills;




        public static TeamA GetDetails(string nume, int deaths, int kills)
        {
            TeamA echipa = new TeamA();
            echipa.TeamName = nume;
            echipa.deaths = deaths;
            echipa.kills = kills;
            return echipa;
        }

        public void PrintDetails()
        {
            Console.WriteLine("TeamName: "+TeamName);
            Console.WriteLine("Deaths: "+deaths);
            Console.WriteLine("Kills: "+kills);
            Console.WriteLine("\n");
        }
    }
}

namespace Game2
{
    public class TeamA
    {
        private string TeamName;
        private int deaths;
        private int kills;


        public static TeamA GetDetails(string nume, int deaths, int kills)
        {
            TeamA echipa = new TeamA();
            echipa.TeamName = nume;
            echipa.deaths = deaths;
            echipa.kills = kills;
            return echipa;
        }

        public void PrintDetails()
        {
            Console.WriteLine("TeamName: "+TeamName);
            Console.WriteLine("Deaths: "+deaths);
            Console.WriteLine("Kills: "+kills);
            Console.WriteLine("\n");
        }
    }
}
