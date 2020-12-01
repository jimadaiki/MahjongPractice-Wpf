using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahjongPractice.Models
{
    public enum TileTypes
    {
        Manzu = 0,
        Pinzu = 1,
        Souzu = 2,
        Jihai = 3
    }

    /// <summary>
    /// 麻雀牌を表すクラス
    /// </summary>
    class Tile
    {
        public TileTypes TileType { get; set; } = TileTypes.Manzu;

        public int Number { get; set; } = 0;

    }
}
