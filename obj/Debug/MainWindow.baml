   M S B A M L   `   `   `  ????F  BSpotifyGold, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SpotifyGoldSpotifyGold  5   	   G(clr-namespace:SpotifyGold.MVVM.ViewModelSpotifyGold.MVVM.ViewModel  5   	       SpotifyGold.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SpotifyGold     5   	   >	viewModel(clr-namespace:SpotifyGold.MVVM.ViewModel     5   	     ? WindowStyle$
  None=?5   	   
??????  ? 
ResizeMode$ NoResize=?5
   	    ? AllowsTransparency .  ? WindowState$ 	Maximized=?5   	    ? Title$ SpotifyGold??5   	   $	??600??6   $	??950??6*    ? DataContext 5      .  (SpotifyGold.MVVM.ViewModel.MainViewModel  5   
   .??5      ??  ?? CornerRadius$ 20??5      ??5   
   ?? 5       ?? 
StartPoint$	 0,0&?6"    ?? EndPoint$	 1,2&?63   .??5      ? 	 ? Color$	 #5115ee??6   
 ? Offset$	
 0.0Q?6/   ? 5      $	 #a385d0 ??6   $
 1Q?60   5      ._?5   
   ??  ?? Orientation$ Vertical=?6   .+?5      ?? $(??"/Images/Spotify_Logo_RGB_White.png??6   $	??200??6@   $	??100??6L   $??10q?6Y   ? 5        ? ColumnDefinitions 5!      ?? 5"      $	??200 ?6'   ?? 5#       ? RowDefinitions 5%      ?? 5&      $??75 ?6$   ?? 5'      $	??405 ?6$   .+?5,      ?? $??2??6!   $??1??5-      $??10q?5.      ??5/      ?? *CurrentView+?? 51      $??0??6   $??2??52      $ Vertical=?53      .+?54      	? $
??Home??6"   $??50??55      
???????$??14(?57         MenuButtonTheme#??[  58       d? 	IsChecked$
 TrueY?59      ??5:      ?? *HomeViewCommand+	? 5<      $??Search Artist??6"   $??50??5=      
???????$??14(?5?      #??[  5@      ??5A      ?? *SearchArtistViewCommand+	? 5B      $??Search Image??6"   $??50??5C      
???????$??14(?5E      #??[  5F      ??5G      ?? *SearchImageViewCommand+	? 5H      $??Search Details??6"   $??50??5I      
???????$??14(?5K      #??[  5L      ??5M      ?? *SearchDetailsViewCommand+	? 5N      $??Leave??6"   $??50??5O      
???????$??14(?5Q      #??[  5R      ??5S      ?? *LeaveViewCommand+5U      5V      5W      5Y      5Z      