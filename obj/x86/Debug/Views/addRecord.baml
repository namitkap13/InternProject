   M S B A M L   `   `   `  ����H  DSchoolProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:SchoolProjectSchoolProject  5      A%clr-namespace:SchoolProject.ViewModelSchoolProject.ViewModel  5      =#clr-namespace:SchoolProject.HelpersSchoolProject.Helpers  5          SchoolProject.addRecord   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:SchoolProject     5      4vm%clr-namespace:SchoolProject.ViewModel     5      2hs#clr-namespace:SchoolProject.Helpers     5        N� 
Background
  ����� � DataContext 5      0   *SchoolProject.ViewModel.AddRecordViewModel  5   
   6"    � 	Resources 5      *   $SchoolProject.Helpers.RadioConverter   radioConverter��%   &	          5   
   6   5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5       6    � ColumnDefinitions 5#   
   �� 5$      6!   �� 5%      6!   �� 5&      6!   �� 5'      6!   �� 5(      6!   �� 5)      6!   �� 5*      6!   �� 5+      6!   �� 5,      6!   �� 5-      6!   �� 5.      6!   �� 5/      6!   .+�52   
   �� $��1��53      $��1��54       �� Orientation$ 
Horizontal=�55      $��Center=�56      $
��Left=�57      $��6��58      .+�5:      �� $��
First name��6    �� TextAlignment$ Center=�5;      $��Center=�5<      �� 5=      -   5         ��Name$ TxtFirstName��5?      $��Center=�5>      $	��300��5@      $��10,0,0,0q�5A      ��5B      �� *	FirstName+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�5D      �� 5E   
   $��2��5F      $��1��5G      $ 
Horizontal=�5H      $��Center=�5I      $
��Left=�5J      $��6��5K      .+�5M      �� $��	Last name��6   $ Center=�5N      $��Center=�5O      �� 5P      -   5        $ TxtLastName��5R      $��Center=�5Q      $	��300��5S      $��10,0,0,0q�5T      ��5U      �� *
LastName+$ TwoWay=�$	 PropertyChanged=�5W      �� 5X   
   $��3��5Y      $��2��5Z      $��1��5[      $ 
Horizontal=�5\      $��Center=�5]      $
��Left=�5^      $��6��5_      .+�5a      �� $��Date of birth��6   $ Center=�5b      $��Center=�5c      (  "System.Windows.Controls.DatePicker  5d      -   5        
  Name$
 DPDate��5f      $��40,0,0,0q�5e      $	��120��5g         SelectedDate 5h      �� *DOB+$ TwoWay=�$	 PropertyChanged=�5k      5l      �� 5m   
   $��6��5n      $��2��5o      $��1��5p      $ 
Horizontal=�5q      $��Center=�5r      $
��Left=�5s      $��6��5t      .+�5v      �� $��Email��6   $ Center=�5w      $��Center=�5x      �� 5y      $��10,0,0,0q�5z      $	��250��5{      ��5|      �� *Email+$ TwoWay=�$	 PropertyChanged=�6\   5}      �� 5~   
   $��5��5      $��1��5�      $ 
Horizontal=�5�      $��Center=�5�      $
��Left=�5�      $��6��5�      .+�5�      �� $��Gender��6   $ Center=�5�      $��Center=�5�      	� 5�      -   5         	�Name$ RBMale��5�      $��15,0,0,0q�5�      $
��Male��5�      
 � Tag$ 0��5�       	� 	GroupName$ RBGender��5�       d� 	IsChecked 5�      ��  �� Path$ Gender� �� 	Converter# [   �� ConverterParameter$ 0��5�      	� 5�      -   5        $ RBFemale��5�      $��15,0,0,0q�5�      $��Female��5�      $ RBGender��5�      $ 1��5�       5�      �� $ Gender�# [  $ 1��5�      5�      �� 5�   
   -   5         ��Name$ BtnAdd��5�      $��8��5�      $��2��5�      $��2��5�      $��Add patient��5�      $��Center=�5�      $��Center=�5�      $��25��5�      $	��120��5�        MaterialDesignBodyLight#��[ 5�      ��5�      �� *AddRecordCommand+5�      5�      5�      