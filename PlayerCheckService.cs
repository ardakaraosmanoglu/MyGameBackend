using System;
namespace MyGameBackend
{
    public class PlayerCheckService : IPlayerCheckService
    {
        public bool Verification(Player player)
        {
            if (player.BirthYear >= 2000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
