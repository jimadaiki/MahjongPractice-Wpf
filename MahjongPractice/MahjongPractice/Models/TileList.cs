using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahjongPractice.Models
{
    class TileList : IEnumerable<Tile>
    {
        List<Tile> tiles;

        public TileList()
        {
            // とりあえずダミー
            tiles = Enumerable.Range(1, 13).Select(value => new Tile { Number = value }).ToList();
        }

        public IEnumerator<Tile> GetEnumerator() => tiles.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
