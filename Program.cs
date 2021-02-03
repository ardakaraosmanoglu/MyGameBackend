using System;

namespace MyGameBackend
{
    class Program
    {
        public static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerData());

            foreach (var player in playerManager.GetAll())
            {
                Console.WriteLine(player.PlayerNickname);
            }

            Console.WriteLine("===============================");

            PlayerManager playerCheck = new PlayerManager(new PlayerCheckService());
            playerCheck.Add(new Player { PlayerId = 1, PlayerName = "Beyza", PlayerSurname = "Beyaz", PlayerNickname = "Hyper", BirthYear = 2001 });
        }

    }
}
