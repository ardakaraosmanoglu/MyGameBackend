using System.Collections.Generic;

namespace MyGameBackend
{
    public interface IPlayerDal
    {
        List<Player> GetAll();

        void Add(Player player);
        void Remove(Player player);
        void Update(Player player);

    }
}
