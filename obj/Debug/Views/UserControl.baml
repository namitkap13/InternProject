   M S B A M L   `   `   `  ����H  DSchoolProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SchoolProjectSchoolProject  5      A%clr-namespace:SchoolProject.ViewModelSchoolProject.ViewModel  5      =#clr-namespace:SchoolProject.HelpersSchoolProject.Helpers  5	          SchoolProject.UserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:SchoolProject     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .vm%clr-namespace:SchoolProject.ViewModel  5      ,hs#clr-namespace:SchoolProject.Helpers  5	        N� 
Background
  ����� � 	Resources 5      *   $SchoolProject.Helpers.RadioConverter   radioConverter��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5"   
   �� 5#      6!   �� 5$      6!   �� 5%      6!   �� 5&      6!   �� 5'      6!   �� 5(      6!   �� 5)      6!   �� 5*      6!   �� 5+      6!   �� 5,      6!   �� 5-      6!   �� 5.      6!   .+�50   
   �� $��1��51      $��1��52       �� Orientation$ 
Horizontal=�53      $��Center=�54      $
��Left=�55      $��6��56      $��1,0,0,0q�6!   .+�58      �� $��UserName��6    �� TextAlignment$ Center=�59      $��Center=�5:      �� 5;      -   5         ��Name$ TxtUserName��5=      $��Center=�5<      $	��300��5>      $��10,0,0,0q�5?      {�5@      �� *EnabledUser+ �� Mode$ OneWay=� �� UpdateSourceTrigger$ PropertyChanged=���5A      �� *
UserName+$ TwoWay=�$ PropertyChanged=�5C      �� 5D   
   $��2��5E      $��1��5F      $ 
Horizontal=�5G      $��Center=�5H      $
��Left=�5I      $��8��5J      .+�5L      �� $��Password��6   $ Center=�5M      $��Center=�5N      G� 5O      -   5        	 G�Name$	 
PbPassword��5Q      $��15,0,0,0q�5P      $	��300��5R      {�5T      �� *EnabledUser+$ OneWay=�$ PropertyChanged=�5V      5W      �� 5X   
   $��3��5Y      $��1��5Z      $ 
Horizontal=�5[      $��Center=�5\      $
��Left=�5]      $��8��5^      .+�5`      �� $��
First name��6   $ Center=�5a      $��Center=�5b      �� 5c      -   5        $ TxtFirstName��5e      $��Center=�5d      $	��300��5f      $��10,0,0,0q�5g      {�5h      �� *EnabledUser+$ OneWay=�$ PropertyChanged=���5i      �� *	FirstName+$ TwoWay=�$ PropertyChanged=�5k      �� 5l   
   $��4��5m      $��1��5n      $ 
Horizontal=�5o      $��Center=�5p      $
��Left=�5q      $��8��5r      .+�5t      �� $��	Last name��6   $ Center=�5u      $��Center=�5v      �� 5w      -   5        $ TxtLastName��5y      $��Center=�5x      $	��300��5z      $��10,0,0,0q�5{      {�5|      �� *EnabledUser+$ OneWay=�$ PropertyChanged=���5}      �� *
LastName+$ TwoWay=�$ PropertyChanged=�5      �� 5�   
   $��5��5�      $��1��5�      $ 
Horizontal=�5�      $��Center=�5�      $
��Left=�5�      $��8��5�      .+�5�      �� $��Email��6   $ Center=�5�      $��Center=�5�      �� 5�      -   5        $ TxtEmail��5�      $��35,0,0,0q�5�      $	��300��5�      {�5�      �� *EnabledUser+$ OneWay=�$ PropertyChanged=���5�      �� *Email+$ TwoWay=�$ PropertyChanged=�5�      5�      �� 5�   
   $��6��5�      $��1��5�      $ 
Horizontal=�5�      $��Center=�5�      $
��Left=�5�      $��10��5�      .+�5�      �� $��
User group��6   $ Center=�5�      $��Center=�5�      �� 5�      -   5        
 ��Name$
 	TxtAltura��5�      $��10,0,0,0q�5�      $	��100��5�       �� SelectedIndex$ 0��5�       �� DisplayMemberPath$
 Role��5�       �� SelectedValuePath$ Id��5�      {�5�      �� *EnabledUser+$ OneWay=�$ PropertyChanged=� �� SelectedItem 5�      �� *SelectedRole+$ TwoWay=�$ PropertyChanged=���5�      �� *	ListRoles+$ TwoWay=�$ PropertyChanged=�5�      �� 5�      $��Gender��5�      $��30,0,0,0q�5�      	� 5�      $��5,0,0,0q�5�      $
��Male��5�       	� 	GroupName$ GenderGroup��5�      
 � Tag$ 0��5�      {�5�      �� *EnabledUser+$ OneWay=�$ PropertyChanged=� d� 	IsChecked 5�      ��  �� Path$ Gender� �� 	Converter# [   �� ConverterParameter$ 0��	� 5�      $��5,0,0,0q�5�      $��Female��5�      $ 1��5�      $ GenderGroup��5�      {�5�      �� *EnabledUser+$ OneWay=�$ PropertyChanged=� 5�      �� $ Gender�# [  $ 1��5�      �� 5�   
   $��7��5�      $��1��5�      $��1��5�      $ 
Horizontal=�5�      $��Center=�5�      $
��Left=�5�      $��8��5�      .+�5�      �� $��Date of birth��6   $ Center=�5�      $��Center=�5�      (  "System.Windows.Controls.DatePicker  5�      -   5          Name$ DPDate��5�      $��30,0,0,0q�5�      $	��120��5�      {�5�      �� *EnabledUser+$ OneWay=�$ PropertyChanged=�   SelectedDate 5�      �� *DOB+$ TwoWay=�$ PropertyChanged=�5�      5�      �� 5�   
   -   5         ��Name$ BtnAdd��5�      $��8��5�      $��3��5�      $��2��5�      $��Add user��5�      $��Center=�5�      $��Center=�5�      $��25��5�      $	��120��5�        MaterialDesignBodyLight#��[ 5�      ��5�      �� *UserCommand+5�      �� 5�   
   $��9��5�      $��1��5�      $��4��5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5�      �� $��Current user:��5�      �� 5�      -	   5         ��Name$ TxbCurrentUser��5�      $��5,0,0,0q�5�      ��5�      �� *CurrentUser+$ TwoWay=�$ PropertyChanged=�5�      �� 5�   
   $��10��5�      $��1��5�      $��4��5�      $��Center=�5�      $ 
Horizontal=�5�      .+�5�      �� $��User group:��5�      �� 5�      -
   5        $ TxbUserGroup��5�      $��5,0,0,0q�5�      ��5�      �� *CurrentGroup+$ TwoWay=�$ PropertyChanged=�5�      5     5     5     