using System;
using System.Collections.Generic;

namespace MyGameBackend
{
    public interface IPlayerService
    {
        List<Player> GetAll();
    }
}
