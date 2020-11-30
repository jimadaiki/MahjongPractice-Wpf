using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahjongPractice.Models
{
    class Player
    {
        /// <summary>
        /// 手配
        /// </summary>
        public TileList MyTiles { get; set; } = new TileList();

        public Player()
        {
            
        }
    }
}
