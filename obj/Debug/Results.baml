   M S B A M L   `   `   `  ����E  ARacingTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RacingTest
RacingTest  5   	       RacingTest.Results   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:RacingTest     5   	   -   5          �Name$  ResultsForm��5   	    � Title$% Результаты круга��5   	   $��461.327��6"   $��632.151��63    � 	Resources 5	         ItemCollectionViewSource �� CollectionViewType��%"   &	        �� 5
   
   " ��6@   5      .��5      � $��0,0,2,0q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6%    � DataContext# [  65      AutoGenerateColumns .     
IsReadOnly . 	   CanUserAddRows	 .  
   SelectionMode$
 Extended=�6�   $��Stretch=�6�   $��0,0,0,32q�6  $��Stretch=�6  ��6m   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Название��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *Name+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$ Center=�6D   5      5        5      $! Итоговое время��6%    6=   �� *
TimeString+ 5      �� 5      " ��6    .�5      ��  � ��$ Center=�6D   5      5        5      $ Дистанция��6%    68   �� *
Distance+ 5      �� 5      " ��6    .�5       ��  � ��$ Center=�6D   5!      5#        5$      $ Параметры��6%    68   �� *
Parameters+ 5%      �� 5&      " ��6    .�5'      ��  � ��$ Center=�6D   5(      5*      5,      �� 5-   
   -   5         ��Name$ NextLap��5-      $!��Следующий круг��6"   $��Stretch=�6;   $��
62,0,330,0q�6Y   $��Bottom=�6m   6�   �� 5.   
   -   5        $ CloseWindow��5.      $��Закрыть��6&   $��Stretch=�68   $��
332,0,57,0q�6V   $��Bottom=�6j   6�   5/      50      