   M S B A M L   `   `   `  ����H  DSchoolProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SchoolProjectSchoolProject  5   	   A%clr-namespace:SchoolProject.ViewModelSchoolProject.ViewModel  5   	       SchoolProject.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SchoolProject     5   	   4vm%clr-namespace:SchoolProject.ViewModel     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5        $	��550��5
   	   $
��1100��5   	     � WindowState$  	Maximized=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency . 
������  � DataContext 5      1   +SchoolProject.ViewModel.MainWindowViewModel  5   
   6#   .��5      �  � RowDefinitions 5   
   �� 5      6    � ColumnDefinitions 5   
   �� 5      $	��320 �6   6-   �� 5      6!   .+�5!   
   #  MaterialDesignThemes.Wpf.Card  $��1��5"      $��0��5#      ���#000000.  (MaterialDesignThemes.Wpf.ElevationAssist   	Elevation$
 Dp24=�5%      .��5&      �� 	 �� Orientation$	 Vertical=�5'      $	��Top=�5(      $��0,0,0,0q�5)      $	 Dp2=�5*      .+�5,      �� -   5        
 ��Name$
 	BtnRecord��5/      $��Add Patient��5-      $��0,5,0,3q�5.      $
��Left=�50      $��Center=�51      ���#252526
�������$	��316��54      $��70��55      $��20(�56      ��57      �� *NavigateToPage1Command+5:      �� 5<      -   5        $
 	BtnSearch��5E      $��Search��5<      $��0,0,0,3q�5=      $
��Left=�5>      $��Center=�5?      ���#252526
�������$	��316��5B      $��70��5C      $��20(�5D      ��5F      �� *NavigateToPage2Command+6F   �� 5H      -   5        $
 BtnUserControl��5Q      $��User Management��5H      $
��Left=�5I      $��Center=�5J      ���#252526$��0,0,0,3q�5L      
�������$	��316��5N      $��70��5O      $��20(�5P      ��5R      �� *NavigateToPage3Command+6F   �� 5T      $,��&Network Security                    ˅��6   $
��Left=�5U      $��Center=�5V      ���#252526
�������$��0,0,0,3q�5Y      $	��316��5Z      $��70��5[      $��20(�5\      5]      �� 5_      $+��%HW Configuration                   ˅��6   $
��Left=�5`      $��Center=�5a      ���#252526
�������$	��316��5d      $��70��5e      $��20(�5f      6)   5g      5i      �� 5j   
   -   5        $��0��5k      $��0��5l      $��Bottom=�5m      $��Center=�5n      $��Log out��5o      ���#252526
�������$	��316��5r      $��70��5s      $��25(�5t      $��0,0,0,20q�5u      5v       � 5x   
   -   5        $��FrmPages��5{      $��1��5y      $��1��5z        � NavigationUIVisibility$ Hidden=�5|       �� 	KeepAlive .  
�������5�      5�      5�      