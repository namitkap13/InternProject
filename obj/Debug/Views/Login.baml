   M S B A M L   `   `   `  ����H  DSchoolProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SchoolProjectSchoolProject  5   	   A%clr-namespace:SchoolProject.ViewModelSchoolProject.ViewModel  5   	   =#clr-namespace:SchoolProject.HelpersSchoolProject.Helpers  5   	       SchoolProject.Login   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:SchoolProject     5   	   4vm%clr-namespace:SchoolProject.ViewModel     5   	   6Helper#clr-namespace:SchoolProject.Helpers     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   $	��500��5   	   $	��850��5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � WindowState$ 	Maximized=�5   	    � 
ResizeMode$ NoResize=�5   	    � AllowsTransparency .  
������� � DataContext 5      ,  &SchoolProject.ViewModel.LoginViewModel  5   
   6   .��5      �  � RowDefinitions 5   
   �� 5      $	��250 �6   6+   �� 5      $��70 �6   6*   �� 5      $��30 �6   6*   �� 5      $��70 �6   6*   �� 5      $��30 �6   6*   �� 5      $	��130 �6   6+    � ColumnDefinitions 5"   
   �� 5#      6!   .+�5&   
   �� $��0��5'       K� ZIndex$ 3��5(      $��\Resources\ZeissLogo.png��5)      $	��200��5*      $	��120��5+      $��Center=�5,      �� 5/   
   $��1��50      $��Center=�51      $��Center=�52      	 �� Orientation$	 Vertical=�53      .+�56      �� $��Username��57      $
��Bold"�58      
�������$��5,0,0,0q�5:      $
��Left=�5;      $��Center=�5<      $��20(�5=      �� 5@      $	 
Horizontal=�5A      .+�5B      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$

 User=�6*   
�������$��Center=�5D   *   $��30��5E   *   $��30��5F   *   5G      �� 5J      -   5         ��Name$ TxtUserName��5N      $��0,0,0,0q�5K      $	��200��5L      $��16(�5M      ��5O      �� *
Username+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5Q      5R      �� 5T   
   $��3��5U      $��Center=�5V      $��Center=�5W      $	 Vertical=�5X      .+�5Z      �� $��Password��5[      
�������$
��Bold"�5]      $��5,0,0,0q�5^      $
��Left=�5_      $��Center=�5`      $��20(�5a      �� 5c      $	 
Horizontal=�5d      .+�5e        $	
 Key=�6*   
�������$��30��5g   *   $��30��5h   *   G� 5i      -   5        $��0,0,0,0q�5j      $	��200��5k      $��16(�5l      5m      5p      5q      �� 5s   
   $��4��5t      $��Center=�5u      $��Center=�5v      $%��Username or password incorrect!��5w      
���  ��$��15(�5y      y�5z      �� *	IsVisible+$ TwoWay=�$ PropertyChanged=��� 5|   
   $	 Vertical=�5}      $��5��5~      $��Center=�5      $��Center=�5�      .+�5�   
   �� -   5        $��LOG IN��5�      
�������$	��140��5�      $��40��5�      ���#141E8C � Cursor$
 Hand��5�         RoundButton#��[  5�      5�      5�      5�      5�      