   M S B A M L   `   `   `  ����H  DSchoolProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SchoolProjectSchoolProject  5   	   A%clr-namespace:SchoolProject.ViewModelSchoolProject.ViewModel  5   	       SchoolProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SchoolProject     5   	   4vm%clr-namespace:SchoolProject.ViewModel     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $	��550��5
   	   $
��1100��5   	     � WindowState$  Normal=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � DataContext 5      1   +SchoolProject.ViewModel.MainWindowViewModel  5   
   6#   .��5      �  � RowDefinitions 5   
   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   6-   �� 5      6!   .+�5   
   �� $��0��6   5      #  MaterialDesignThemes.Wpf.Card  5   
   $��1��5       $��0��5!      ���#1A008B.  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$
 Dp16=�5#      .��5$      ��  �� Orientation$ Vertical=�5%      $	��Top=�5&      $��0,50,0,0q�5'      $	 Dp2=�5(      .+�5*      �� -   5         ��Name$ 	BtnRecord��5,      $��
Add record��5*      $��0,0,0,20q�5+      ���#F5F5F5$	��120��5.      
���   ���50      �� *NavigateToPage1Command+51      �� 52      -   5        $ 	BtnSearch��57      $��Search��52      $��0,0,0,20q�53      ���#F5F5F5$	��120��55      
���   ���58      �� *NavigateToPage2Command+6F   �� 59      -   5        $ BtnUserControl��5>      $��User control��59      ���#F5F5F5$	��120��5;      
���   ���5?      �� *NavigateToPage3Command+6F   5A      5B       � 5D   
   -   5        $��FrmPages��5G      $��1��5E      $��1��5F      	  � NavigationUIVisibility$	 Hidden=�5H      
 �� 	KeepAlive
 .  5L      5Q      5R      