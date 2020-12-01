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
        public IEnumerable<Tile> MyTiles { get; set; } = null;

        public Player()
        {
            MyTiles = TileList.Instance.GetRandomTiles(13);
        }
    }
}
