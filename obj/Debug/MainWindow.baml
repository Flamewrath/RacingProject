   M S B A M L   `   `   `  ����E  ARacingTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RacingTest
RacingTest  5   	       RacingTest.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:RacingTest     5   	   -   5          �Name$  MainForm��5   	    � Title$ 
Гонки��5   	   $��586.139��6   $��514.837��6(   .��5	      � $	��557��6   $	��Top=�6   $��0,0,0,-2q�60    � RowDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ ButtonStart��5      $��Начать гонку��6&   {�. $
��Left=�6N   $��	10,0,0,71q�6i   $��Bottom=�6|   $	��487��6�   $��20��6�   �� 5   
   -   5        $ 
ButtonStop��5      $��Окончить круг��6%   {�.  $
��Left=�6O   $��	10,0,0,54q�6j   $��Bottom=�6}   $	��487��6�   $��17��6�   6�   �� 5   
   -   5         ��Name$ 	GroupCars��5      $��Машины��6&   $
��Left=�66   $	��130��6Q   $��	0,0,0,384q�6^   $��Bottom=�6q   $	��507��6�   .��5      �� -   5         ��Name$ CarTextBlock��5      $��Stretch=�6.   $��	0,0,-2,-3q�6L   $
��Wrap=�6_   $�� ��6s   $��Stretch=�6{   $	��497��6�   5      �� 5   
   -   5        $ 
GroupBikes��5      $��Мотоциклы��6'   $
��Left=�6:   $	��130��6U   $��	0,0,0,125q�6b   $��Bottom=�6u   $	��507��6�   .��5      �� -   5        $ BikeTextBlock��5      $��Stretch=�6/   $&�� 0,0                        ,-2,3q�6M   $
��Wrap=�5      $�� ��63   $��Stretch=�6;   $	��497��6W   5      �� 5   
   -   5        $ 
TrucksCars��5      $��Грузовики��6'   $
��Left=�6:   $	��130��6U   $��	0,0,0,255q�6b   $��Bottom=�6u   $	��507��6�   .��5      �� -	   5        $ TruckTextBlock��5      $��Stretch=�60   $��0,0,0,0q�6N   $
��Wrap=�6_   $�� ��6s   $��Stretch=�6{   $	��497��6�   5      �� 5   
   -
   5        $ ButtonCreateJson��5      $��Создать Json��6+   $y�Hidden=�6B   {�. $
��Left=�6g   $��
382,0,0,29q�6�   $��Bottom=�6�   $	��115��6�   $��20��6�   �� 5   
   -   5         ��Name$ LabelDistance��5      $��Длина круга:��6'   $
��Left=�6>   $��	41,10,0,0q�6Y   $	��Top=�6l   �� 5   
   -   5        $ LabelLap��5      $��Номер круга:��6"   $
��Left=�69   $��
337,10,0,0q�6T   $	��Top=�6h   5      5      