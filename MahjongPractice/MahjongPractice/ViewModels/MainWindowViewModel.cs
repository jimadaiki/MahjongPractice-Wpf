using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahjongPractice.ViewModels
{
    using Models;
    class MainWindowViewModel : BindableBase
    {
        public Player Player { get; set; } = new Player();

        public IEnumerable<Tile> Tehai { get; set; } = null;

        public TileList Mountain { get; set; } = null;

        public MainWindowViewModel()
        {
            Tehai = Player.MyTiles;
        }
    }
}
