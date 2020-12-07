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

        int index = 0;

        TileList() 
        {
            InitTiles();
        }    

        /// <summary>
        /// 牌の初期化を行うメソッド
        /// </summary>
        void InitTiles()
        {
            // 数牌一種類の枚数
            const int suhaiCount = 36;
            // 字牌の枚数
            const int jihaiCount = 28;
            // 数牌の最大数字
            const int suhaiMaxNumber = 9;
            // 字牌の最大数字
            const int jihaiMaxNumber = 7;

            int GetSuhaiNumber(int value) => value % suhaiMaxNumber == 0 ? suhaiMaxNumber : value % suhaiMaxNumber;
            int GetJihaiNumber(int value) => value % jihaiMaxNumber == 0 ? jihaiMaxNumber : value % jihaiMaxNumber;

            // すべての牌を作成
            var manzuTiles = Enumerable.Range(1, suhaiCount)
                                       .Select(value => new Tile {
                                           TileType = TileTypes.Manzu,
                                           Number = GetSuhaiNumber(value)
                                       });
            
            var pinzuTiles = Enumerable.Range(1, suhaiCount)
                                       .Select(value => new Tile {
                                           TileType = TileTypes.Pinzu,
                                           Number = GetSuhaiNumber(value)
                                       });
            var sounuTiles = Enumerable.Range(1, suhaiCount)
                                       .Select(value => new Tile {
                                           TileType = TileTypes.Souzu,
                                           Number = GetSuhaiNumber(value)
                                       });
            var jihaiTiles = Enumerable.Range(1, jihaiCount)
                                       .Select(value => new Tile {
                                           TileType = TileTypes.Jihai,
                                           Number = GetJihaiNumber(value)
                                       });
            tiles.AddRange(manzuTiles);
            tiles.AddRange(pinzuTiles);
            tiles.AddRange(sounuTiles);
            tiles.AddRange(jihaiTiles);
        }

        public IEnumerable<Tile> GetRandomTiles(int count)
        {
            numbers = numbers.Shuffle();
            this.index += count;
            return numbers.Take(count).Select(index => tiles[index]);
        }

        public Tile this[int index] => tiles[index];

        public void newInstance() => tileList = new TileList();

        public Tile GetTile()
        {
            var tileIndex = numbers.ElementAt(index++);
            return tiles[tileIndex];
        }

        public IEnumerator<Tile> GetEnumerator() => tiles.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
