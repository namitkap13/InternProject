   M S B A M L   `   `   `  ����H  DSchoolProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SchoolProjectSchoolProject  5   	   A%clr-namespace:SchoolProject.ViewModelSchoolProject.ViewModel  5   	   =#clr-namespace:SchoolProject.HelpersSchoolProject.Helpers  5   	       SchoolProject.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SchoolProject     5   	   4vm%clr-namespace:SchoolProject.ViewModel     5   	   6Helper#clr-namespace:SchoolProject.Helpers     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   $	��500��5   	   $	��850��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$ SingleBorderWindow=�5   	    � WindowState$ Normal=�5   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency .  
������� � Title$ LOG IN��5   	    � DataContext 5      ,  &SchoolProject.ViewModel.LoginViewModel  5   
   6   .��5      �  � RowDefinitions 5   
   �� 5      $	��120 �6   6+   �� 5      $��70 �6   6*   �� 5      $��30 �6   6*   �� 5      $��70 �6   6*   �� 5      $��30 �6   6*   �� 5       $	��130 �6   6+    � ColumnDefinitions 5#   
   �� 5$      6!   .+�5'   
   �� $��0��5(      	 K� ZIndex$	 3��5)      $��\Resources\ZeissLogo.png��5*      $	��200��5+      $	��120��5,      $��Center=�5-      �� 50   
   $��1��51      $��Center=�52      $��Center=�53      
 �� Orientation$
 Vertical=�54      .+�57      �� $��Username��58      $
��Bold"�59      
�������$��5,0,0,0q�5;      $
��Left=�5<      $��Center=�5=      $��20(�5>      �� 5A      $
 
Horizontal=�5B      .+�5C      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 User=�6*   
�������$��Center=�5E   *   $��30��5F   *   $��30��5G   *   5H      �� 5K      -   5         ��Name$ TxtUserName��5O      $��0,0,0,0q�5L      $	��200��5M      $��16(�5N      ��5P      �� *
Username+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5R      5S      �� 5U   
   $��3��5V      $��Center=�5W      $��Center=�5X      $
 Vertical=�5Y      .+�5[      �� $��Password��5\      
�������$
��Bold"�5^      $��5,0,0,0q�5_      $
��Left=�5`      $��Center=�5a      $��20(�5b      �� 5d      $
 
Horizontal=�5e      .+�5f        $	 Key=�6*   
�������$��30��5h   *   $��30��5i   *   G� 5j      -   5        $��0,0,0,0q�5k      $	��200��5l      $��16(�5m      5n      5q      5r      �� 5t   
   $��4��5u      $��Center=�5v      $��Center=�5w      $%��Username or password incorrect!��5x      
���  ��$��15(�5z      y�5{      �� *	IsVisible+$ TwoWay=�$ PropertyChanged=��� 5}   
   $
 Vertical=�5~      $��5��5      $��Center=�5�      $��Center=�5�      .+�5�   
   �� $��LOG IN��5�      
�������$	��140��5�      $��40��5�      ���#23128C � Cursor$
 Hand��5�         RoundButton#��[  5�      ��5�      �� *LoginCommand+5�      �� 5�      $
 
Horizontal=�6   $��Center=�5�      .+�5�      �� $��Forgot password?��5�      
�������5�   )   �� 5�      
������  �� TextAlignment$ Center=�5�      $��Reset��5�      $��Center=�5�      $��Center=�5�      $��9(�5�      $��12��5�      
���iii�$��5,0,0,0q�5�      5�      5�      5�      5�      5�      