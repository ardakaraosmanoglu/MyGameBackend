using System;
using System.Collections.Generic;
using System.Linq;

namespace MyGameBackend
{
    public class PlayerData : IPlayerDal
    {
        List<Player> _player;
        public PlayerData()
        {
            _player = new List<Player>
        {
            new Player{PlayerId=1, PlayerName="Arda", PlayerSurname="Karaosmanoglu", PlayerNickname="Raxana", BirthYear=2000},
            new Player{PlayerId=2, PlayerName="Berk", PlayerSurname="Koca", PlayerNickname="Focus", BirthYear=2000},
            new Player{PlayerId=3, PlayerName="Canan", PlayerSurname="Karaman", PlayerNickname="Ank", BirthYear=2000},
            new Player{PlayerId=4, PlayerName="Celal", PlayerSurname="Topak", PlayerNickname="CPT", BirthYear=2000},
            new Player{PlayerId=5, PlayerName="Cemaliye", PlayerSurname="Uzun", PlayerNickname="Cakay", BirthYear=2000 },
        };

        }

        public void Add(Player player)
        {
            _player.Add(player);
        }

        public List<Player> GetAll()
        {
            return _player;
        }

        public void Remove(Player player)
        {
            Player playerToRemove = _player.SingleOrDefault(p => p.PlayerId == player.PlayerId);

            _player.Remove(player);
        }

        public void Update(Player player)
        {
            Player playerToUpdate = _player.SingleOrDefault(p => p.PlayerId == player.PlayerId);
            playerToUpdate.PlayerId = player.PlayerId;
            playerToUpdate.PlayerName = player.PlayerName;
            playerToUpdate.PlayerSurname = player.PlayerSurname;
            playerToUpdate.PlayerNickname = player.PlayerNickname;
        }
    }
}
