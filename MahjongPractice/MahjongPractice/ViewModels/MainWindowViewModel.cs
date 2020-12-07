using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Media.Imaging;

namespace MahjongPractice.ViewModels
{
    using Models;

    class MainWindowViewModel : BindableBase
    {
        readonly Player player;

        int count = 0;
        public int Count
        {
            get => count;
            set
            {
                count = value;
                if (count == 18)
                    Finished = true;
            }
        }

        public bool Finished { get; set; } = false;


        public DelegateCommand TsumoCommand { get; private set; }


        //private MyTileList myTileList = null;

        //public MyTileList MyTileList
        //{
        //    get => myTileList;
        //    set
        //    {
        //        // new して新しいオブジェクトを割り当てると大量のバインディングエラーが発生する
        //        // なんとかしてCollectionChangedEventでやりたい
        //        // ていうか、EventHandler<> で追加もしくは削除したTile をもらって渡せばいいような気がする。。。
        //        MyTileImages = value?.Select(tile => GetBitmapImage(tile));
        //    }
        //}

        //ObservableCollection<Tile> MyTileImages { get; } = new ObservableCollection<Tile>();

        IEnumerable<BitmapImage> myTileImages = null;
        public IEnumerable<BitmapImage> MyTileImages
        {
            get => myTileImages;
            set => SetProperty(ref myTileImages, value);
        }

        public ObservableCollection<BitmapImage> PutTileImages { get; set; } = new ObservableCollection<BitmapImage>();

        public MainWindowViewModel()
        {
            player = new Player();
            player.MyTileList.PropertyChanged += (_, e) => OnUpdate();
            myTileImages = player.MyTileList?.Select(tile => GetBitmapImage(tile));
        }

        void OnUpdate() => MyTileImages = player.MyTileList?.Select(tile => GetBitmapImage(tile));

        public void Put(int index)
        {
            Count++;
            PutTileImages.Add(GetBitmapImage(player.MyTileList[index]));
            player.PutTile(index);
            player.GetTile();
        }

        BitmapImage GetBitmapImage(Tile tile)
        {
            var imageSource = $"/Resources/{tile.TileType}{tile.Number}.gif";
            var bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imageSource, UriKind.Relative);
            bitmap.EndInit();
            return bitmap;
        }
    }
}
