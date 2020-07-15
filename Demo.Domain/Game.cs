using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Domain
{
    public class Game
    {
        public Game()
        {
            gamePlayers = new List<GamePlayer>();
        }
        public int Id { get; set; }
        public int Round { get; set; }
        public DateTimeOffset? StartTime { get; set; }
        public List<GamePlayer> gamePlayers { get; set; }

    }
}
