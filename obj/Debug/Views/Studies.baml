   M S B A M L   `   `   `  ����H  DSchoolProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SchoolProject.ViewsSchoolProject.Views  5      !    SchoolProject.Views.Studies   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:SchoolProject.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:MD1http://materialdesigninxaml.net/winfx/xaml/themes  5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6D     N� 
Background
  �����.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      $	��300 �6   6+   �� 5      $��80 �6   6*    � ColumnDefinitions 5   
   �� 5      6"   �� 5      6"   .+�5   
   ��  �� Orientation$ 
Horizontal=�5      $��0��5      $��0��5      $��Center=�5      $��Center=�5      .+�5       �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Name of study��5!      $	��150��5"      $
��Left=�5#      ��5$      �� *	StudyName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6^   5%      �� 5&      $��+ Add Study��5'      $��20,0,0,0q�5(      $
��Left=�5)      ���#141E8C
���������5,      �� *AddStudyCommand+5-      �� 5.   
   $ 
Horizontal=�5/      $��0��50      $��1��51      $��Center=�52      $��Center=�53      .+�55      �� $ Name of series��56      $	��150��57      $
��Left=�58      ��59      �� *
SeriesName+$ TwoWay=�$ PropertyChanged=�.��6_   5:      �� 5;      $��+ Add Series��5<      $��20,0,0,0q�5=      ���#141E8C
�������$
��Left=�5@      ��5A      �� *AddSeriesCommand+5B      �� 5D   
   $��1��5E      $��0��5F      $��10q�5G      ��5H      �� *	StudyList+$ TwoWay=�$ PropertyChanged=� �� View 5K      �� 5L      .P�5M      �� $�� ��6%    �� Width$	 400��6/   	 �� DisplayMemberBinding	 6;   �� *Name+5N      5P      �� 5R   
   $��1��6   $��1��5S      $ Vertical=�5T      $��0,10,0,0q�5U      $��Stretch=�5V      .+�5W      �� $ 
Horizontal=�6   $	��Top=�5X      $��Center=�5Y      .+�5\      �� $"��Select study to add series: ��5]      $��Center=�5^      $
��Left=�5_      �� 5`      $��10,0,0,0q�5a      $	��180��5b      
 �� DisplayMemberPath$

 Name��5e       �� SelectedValuePath$ Id��5f      ��5c      �� *	StudyList+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 5d      �� *SelectedStudy+$ TwoWay=�$ PropertyChanged=�*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5h      +  %Microsoft.Xaml.Behaviors.EventTrigger  5i         	EventName$ SelectionChanged��6)   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5j      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 64   �� *SelectionChanged+5k      5m      5n      �� 5o      $��10q�5p      $	��244��5q      ��5r      �� *
SeriesList+$ TwoWay=�$ PropertyChanged=� 5s      �� *SelectedSeries+$ TwoWay=�$ PropertyChanged=� 5u      �� 5v      .P�5w      �� $�� ��6)   	 63   �� *Name+$ TwoWay=�$ PropertyChanged=�6�   5x      5z      5{      �� 5|   
   
�������$��Add Data��5~      $��2��5      $��1��5�      $	��Top=�5�      $��Right=�5�      $��0,0,20,0q�5�      ��5�      �� *ChangeViewCommand+5�      5�      