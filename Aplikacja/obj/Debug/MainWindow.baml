   M S B A M L   `   `   `  ����D  @Aplikacja, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Aplikacja	Aplikacja  5   	       Aplikacja.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Aplikacja     5   	     � Title$  Przegląd danych��5      $	��450��6   $	��800��6,   
���  ��.��5	      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgTable��5         AutoGenerateColumns .    CanUserAddRows .  $	��219��6o   $��49,151,49,0q�6|   $	��Top=�6�   ��6$   �� 6�   �� 5   
   -   5         ��Name$ cbTable��5      $��20(�6$   $
��Left=�62   $��
172,93,0,0q�6M   $	��Top=�6a   $	��435��6y   $��53��6�   .@�5      �� -   5         ��Name$ item001��5      $��20(�6,    �� 
IsSelected .  .��6M   	AUTORZY6V   �� 5      -   5        $ item002��5      $��20(�6,    .  .��6M   	TYTUŁY6U   �� 5      -   5        $ item003��5      $��20(�6,    .  .��6M   	KSIĄŻKI6V   �� 5      -   5        $ item004��5      $��20(�6,    .  .��6M   
CZYTELNICY6Y   �� 5      -   5        $ item005��5      $��20(�6,    .  .��6M   WYPOŻYCZENIA6[   �� 5      -   5        $ item006��5      $��20(�6,    .  .��6M   	KATEGORIE6X   5      c� 5   
   $
��Left=�6   $��67��6-   $	��Top=�69   $	��782��6Q   .@�5      �� -	   5        $��68��5      $��Dodaj Książkę��6!   
���/���$	��180��6R   $
��0,-3q�6^   6l   �� 5      -
   5        $��68��5      $��Wypożyczenie��6!   
��� ���$	��180��6L   $
��0,-3q�6X   6f   �� 5      -   5        $��68��5      $��Usuń��6!   
��� E��$	��180��6G   $
��0,-3q�6S   6a   �� 5      -   5        $��Popraw Dane��5      
����  �$	��180��6=   $
��0,-3q�6`   $��Stretch=�6n   5      5      5      