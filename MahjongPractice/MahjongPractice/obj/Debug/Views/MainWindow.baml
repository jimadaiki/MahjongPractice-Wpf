   M S B A M L   `   `   `  ����J  FMahjongPractice, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:MahjongPractice.ViewsMahjongPractice.Views  5   	   G(clr-namespace:MahjongPractice.ViewModelsMahjongPractice.ViewModels  5   	   G(clr-namespace:MahjongPractice.ConvertersMahjongPractice.Converters  5   	   &     MahjongPractice.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5views#clr-namespace:MahjongPractice.Views     5   	   ?
viewModels(clr-namespace:MahjongPractice.ViewModels     5   	   ?
converters(clr-namespace:MahjongPractice.Converters     5   	     � Title$  
MainWindow��5
   	   $	��450��6   $	��800��6)      MahjongMatColor#��[  65    � 	Resources 5      4  .MahjongPractice.ViewModels.MainWindowViewModel  	ViewModelI  CMahjongPractice.Converters.TileTypesAndNumberToImageSourceConverter , (TileTypesAndNumberToImageSourceConverter  TileImageStyle �� 
TargetType �� Property �� Value  ListBoxItemStyle �� 
TargetType �� Triggers P� Property P� Value��%�  &	       &	      &	 &     &	 �       5   
   6)     5   
   6>   �� 5   
   " ��6'   .�5      ��  � ��$ 60��6'   �� 5       � ��$ 60��6&   5      �� 5   
   " ��6)   .�5      ��  � ��$
 Left=�64   �� 5       � ��$ Center=�62   �� 5       � ��$
 Left=�6;   �� 5       � ��$ Center=�69   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   ._�5      �� 5       5      P� 5       �@J�IsMouseOver . . �5   "   ��  � ��$ 0,0,0,16q�6;   �� 5    "    � ��$ 0q�6D   �� 5!   "    � ��
 ���� 6@   5"      P� 5#       �@J�IsMouseOver .  . �5$   "   ��  � ��$ 0q�6D   5%      P� 5&       �@��
IsSelected . . �5'   "   ��  � ��$ 0,0,0,16q�6;   �� 5(   "    � ��$ 0q�6D   5)      5+      5-      5.      5/      	 � DataContext	 51      �� 52   
   
 �� ResourceKey$
 	ViewModel��6   .��54      �  � RowDefinitions 55   
   �� 56      $��2* �6   �� 57      $��5* �6   �� 58      $��3* �6   .+�5:   
   � $��1��6    � ColumnDefinitions 5;      �� 5<      $��3* �6#   �� 5=      $��5* �6#   �� 5>      $��3* �6#   .+�5@      �� $��1��6   ��6+   �� *PutTileImages+��5A      �� 5B      .R�5C      � 5D      ��5F      �� 5G      .R�5H      �� #��[ 6    $��0,8,0,0q�6[   ��6H   �� 6[   5I      5K      5L      �� 5N   
   -   5         ��Name$ listBox��5N      $��2��6#   #��[  5O      $��0q�6@    �� AlternationCount$ 15��5P      ��5N   0   �� *MyTileImages+��5Q      �� 5R      " ��6    �� BasedOn# [ 6:    �� Triggers 5S      P� 5T       �@��AlternationIndex$ 13��6K   . �5U      ��  � ��$ 16,0,0,0q�67   5V      ]� 5W       ]� 
Conditions 5X      �� 5Y   "    �� Property �@��AlternationIndex �� Value$ 13��6U   �� 5Z   "    �@J�IsMouseOver . 6C   ./�5\      ��  � ��$ 	16,0,0,16q�67   5]      5_      ��5b      �� 5c      .R�5d      ��  �� Orientation$ 
Horizontal=�6!   5e      ��5h      �� 5i      .R�5j      �� #��[ 6   ��6D   �� 5k      5m      �� 5n   
   -   5         ��Name$ nextGameButtonClicked��5o   %   $��次のゲームへ��5n      $
��Left=�6"   $��
364,32,0,0q�6=   $	��Top=�6Q   $��74��6i   $y�Hidden=�5o      6%   5q      5r      