   M S B A M L   `   `   `  ����H  DSchoolProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SchoolProject.ViewsSchoolProject.Views  5      !    SchoolProject.Views.Studies   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:SchoolProject.Views     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a:MD1http://materialdesigninxaml.net/winfx/xaml/themes  5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3i+http://schemas.microsoft.com/xaml/behaviors  6D     N� 
Background
  �����.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      $	��300 �6   6+   �� 5      $��80 �6   6*    � ColumnDefinitions 5   
   �� 5      6"   �� 5      6"   .+�5   
   ��  �� Orientation$ 
Horizontal=�5      $��0��5      $��0��5      $��Center=�5      $��Center=�5      .+�5       �� )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Name of study��5!      $	��150��5"      $
��Left=�5#      ��5$      �� *	StudyName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�.��6^   5%      �� 5&      $��+ Add Study��5'      $��20,0,0,0q�5(      $
��Left=�5)      
����  ���5+      �� *AddStudyCommand+5,      �� 5-   
   $ 
Horizontal=�5.      $��0��5/      $��1��50      $��Center=�51      $��Center=�52      .+�54      �� $ Name of series��55      $	��150��56      $
��Left=�57      ��58      �� *
SeriesName+$ TwoWay=�$ PropertyChanged=�.��6_   59      �� 5:      $��+ Add Series��5;      $��20,0,0,0q�5<      
����  �$
��Left=�5>      ��5?      �� *AddSeriesCommand+5@      �� 5B   
   $��1��5C      $��0��5D      $��10q�5E      ��5F      �� *	StudyList+$ TwoWay=�$ PropertyChanged=� �� View 5I      �� 5J      .P�5K      �� $�� ��6%    �� DisplayMemberBinding 6/   �� *Name+5L      5N      �� 5P   
   $��1��6   $��1��5Q      $ Vertical=�5R      $��0,10,0,0q�5S      $��Stretch=�5T      .+�5U      �� $ 
Horizontal=�6   $	��Top=�5V      $��Center=�5W      .+�5Z      �� $"��Select study to add series: ��5[      $��Center=�5\      $
��Left=�5]      �� 5^      $��10,0,0,0q�5_      $	��180��5`      	 �� DisplayMemberPath$
	 Name��5c      
 �� SelectedValuePath$
 Id��5d      ��5a      �� *	StudyList+$ TwoWay=�$ PropertyChanged=� �� SelectedItem 5b      �� *SelectedStudy+$ TwoWay=�$ PropertyChanged=�*  $Microsoft.Xaml.Behaviors.Interaction   Triggers 5f      +  %Microsoft.Xaml.Behaviors.EventTrigger  5g         	EventName$ SelectionChanged��6)   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5h      2  ,Microsoft.Xaml.Behaviors.InvokeCommandAction     Command 64   �� *SelectionChanged+5i      5k      5l      �� 5m      $��10q�5n      $	��244��5o      ��5p      �� *
SeriesList+$ TwoWay=�$ PropertyChanged=� 5q      �� *SelectedSeries+$ TwoWay=�$ PropertyChanged=� 5s      �� 5t      .P�5u      �� $�� ��6)    63   �� *Name+$ TwoWay=�$ PropertyChanged=�6�   5v      5x      5y      �� 5z   
   
�������$��Add Data��5|      $��2��5}      $��1��5~      $	��Top=�5      $��Right=�5�      $��0,0,20,0q�5�      ��5�      �� *ChangeViewCommand+5�      5�      