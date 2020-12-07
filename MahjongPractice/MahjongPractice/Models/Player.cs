using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahjongPractice.Models
{
    class Player : BindableBase
    {
        readonly TileList tileList = TileList.Instance;
        public MyTileList MyTileList { get; set; } = null;


        public Player()
        {
            var tiles = tileList.GetRandomTiles(14);
            MyTileList = new MyTileList(tiles);
        }

        /// <summary>
        /// ツモのこと
        /// </summary>
        public void GetTile()
        {
            var tile = tileList.GetTile();
            MyTileList?.Add(tile);
        }

        /// <summary>
        /// 捨てること
        /// </summary>
        public void PutTile(int index)
        {
            MyTileList?.Remove(index);
        }

     
        
    }
}
