using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahjongPractice.Models
{
    using Helper;
    class TileList : IEnumerable<Tile>
    {
        static TileList tileList = new TileList();
        public static TileList Instance => tileList;

        List<Tile> tiles = new List<Tile>();

        IEnumerable<int> numbers = Enumerable.Range(0, 136).Select(value => value);

        TileList() 
        {
            InitTiles();
        }    

        void InitTiles()
        {
            // すべての牌を作成
            var manzuTiles = Enumerable.Range(1, 36)
                                       .Select(value => new Tile { 
                                            TileType = TileTypes.Manzu, 
                                            Number = value % 9 == 0 ? 9 : value % 9
                                        });
            
            var pinzuTiles = Enumerable.Range(1, 36)
                                       .Select(value => new Tile {
                                           TileType = TileTypes.Pinzu,
                                           Number = value % 9 == 0 ? 9 : value % 9
                                       });
            var sounuTiles = Enumerable.Range(1, 36)
                                       .Select(value => new Tile {
                                           TileType = TileTypes.Souzu,
                                           Number = value % 9 == 0 ? 9 : value % 9
                                       });
            var jihaiTiles = Enumerable.Range(1, 28)
                                       .Select(value => new Tile {
                                           TileType = TileTypes.Jihai,
                                           Number = value % 7 == 0 ? 7 : value % 7
                                       });
            tiles.AddRange(manzuTiles);
            tiles.AddRange(pinzuTiles);
            tiles.AddRange(sounuTiles);
            tiles.AddRange(jihaiTiles);
        }

        public IEnumerable<Tile> GetRandomTiles(int count)
        {
            numbers = numbers.Shuffle();
            return numbers.Take(count).Select(index => GetTile(index));
        }

        public Tile this[int index] => GetTile(index);

        public void newInstance() => tileList = new TileList();

        Tile GetTile(int index)
        {
            return tiles[index];
        }

        public IEnumerator<Tile> GetEnumerator() => tiles.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
