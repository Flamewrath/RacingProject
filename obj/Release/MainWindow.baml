   M S B A M L   `   `   `  ���� E  ARacingTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:RacingTest
RacingTest      RacingTest.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:RacingTest     -     �Name$  MainForm�� � Title$ 
Гонки��$��586.139��$��514.837��.��� $	��557��$	��Top=�$��0,0,0,-2q� � RowDefinitions �� �� $��0* �.+��� -    ��Name$ ButtonStart��$��Начать гонку��{�. $
��Left=�$��	10,0,0,71q�$��Bottom=�$	��487��$��20���� -   $ 
ButtonStop��$��Окончить круг��{�.  $
��Left=�$��	10,0,0,54q�$��Bottom=�$	��487��$��17���� -    ��Name$ 	GroupCars��$��Машины��$
��Left=�$	��130��$��	0,0,0,384q�$��Bottom=�$	��507��.���� -    ��Name$ CarTextBlock��$��Stretch=�$��	0,0,-2,-3q�$
��Wrap=�$�� ��$��Stretch=�$	��497���� -   $ 
GroupBikes��$��Мотоциклы��$
��Left=�$	��130��$��	0,0,0,125q�$��Bottom=�$	��507��.���� -   $ BikeTextBlock��$��Stretch=�$&�� 0,0                        ,-2,3q�$
��Wrap=�$�� ��$��Stretch=�$	��497���� -   $ 
TrucksCars��$��Грузовики��$
��Left=�$	��130��$��	0,0,0,255q�$��Bottom=�$	��507��.���� -	   $ TruckTextBlock��$��Stretch=�$��0,0,0,0q�$
��Wrap=�$�� ��$��Stretch=�$	��497���� -
   $ ButtonCreateJson��$��Создать Json��$y�Hidden=�{�. $
��Left=�$��
382,0,0,29q�$��Bottom=�$	��115��$��20���� -    ��Name$ LabelDistance��$��Длина круга:��$
��Left=�$��	41,10,0,0q�$	��Top=��� -   $ LabelLap��$��Номер круга:��$
��Left=�$��
337,10,0,0q�$	��Top=�