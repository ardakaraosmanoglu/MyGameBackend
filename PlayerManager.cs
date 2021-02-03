using System;
using System.Collections.Generic;

namespace MyGameBackend
{
    public class PlayerManager
    {
        IPlayerDal _playerDal;
        public PlayerManager (IPlayerDal playerDal)
        {
            _playerDal = playerDal;
        }

        public List<Player> GetAll()
        {
            return _playerDal.GetAll();
        }

        IPlayerCheckService _playerCheckService;
        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            if (_playerCheckService.Verification(player) == true)
            {
                Console.WriteLine("New player '" + player.PlayerNickname + "' aded.");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }

        public void Remove(Player player)
        {
            Console.WriteLine("Player '" + player.PlayerNickname + "' removed.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player '" + player.PlayerNickname + "' updated.");
        }
    }
}
