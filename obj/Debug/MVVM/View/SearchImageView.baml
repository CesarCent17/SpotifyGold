   M S B A M L   `   `   `  ????F  BSpotifyGold, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SpotifyGold.MVVM.ViewSpotifyGold.MVVM.View  5      G(clr-namespace:SpotifyGold.MVVM.ViewModelSpotifyGold.MVVM.ViewModel  5      +    %SpotifyGold.MVVM.View.SearchImageView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:SpotifyGold.MVVM.View     5      >	viewModel(clr-namespace:SpotifyGold.MVVM.ViewModel     5        ? DataContext  5      .  (SpotifyGold.MVVM.ViewModel.MainViewModel  5   
   .??5      ?? .+?5   
   ??  ?? CornerRadius$ 10??6   ???#F0F0F0$	??300??5      $??40??5      ._?5      ? .+?5      ?? $??1??6   ?? 5      -   5         ??Name$ 	SearchBox??5      $??5q?5      $??0q?5      
?????? $??Center=?5      ???#7E7E7E5      ?? 5        J? IsHitTestVisible .  $??Search??5!   (   $??Center=?5"   (   $
??Left=?5#   (   $??10,0,0,0q?5$   (   $??11(?5%   (   
?????????5)      ?? 5*       ?? 
TargetType" ??6     ?? Triggers 5+      ?? 5,   "    ?? Binding 6.   ?? *Text+ ?? ElementName$ 	SearchBox?? ?? Value  6^   .a?5-   &   ?? 	 ?? Property	 ? y?
 ?? Value$
 Visible=?6C   5.   #   .?50      ?? 	 ? y?$
 Hidden=?6;   51      53      54      56      ]? 57   
   .+?58      ?  ? ColumnDefinitions 59      ?? 5:      $??8999* ?6'   ?? 5;      $	??14* ?6'    ? RowDefinitions 5>      ?? 5?      $	??625 ?6$   ?? 5@      ?? 5A      $
??auto ?6$   .+?5C      ]? .+?5D      ?? -   5         ??Name$ 
ListArtist??5H      $??0q?5E      $??1??5F      $??10q?5G         ListArtistImageTemplate#??[  5I      $??2??6]   ??5K      ?? 5L       ?? 
StartPoint$	 0,0&?62    ?? EndPoint$	 1,2&?6C   .??5M   "   ?  ? Color$ 	#794cdf  ??6/    ? Offset$	 0.0Q?6A   ? 5N   "   $ 
#2935bb   ??6/   $ 1Q?6B   5O      5Q      5R      5S      5T      5U      5V      