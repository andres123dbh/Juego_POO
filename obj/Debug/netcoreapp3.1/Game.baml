   M S B A M L   `   `   `  ����D  @Juego_POO, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Juego_POO	Juego_POO  5          Juego_POO.Game   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      )localclr-namespace:Juego_POO     5        N� Title$
  Game��5	       N� 
Background �	#FF00A007.��5      �  � ColumnDefinitions 5   
   �� 5      $
��171* �6   �� 5      $	��29* �6   .+�5   
   �� -   5        $��btnHit��5      $	��Hit��6   $
��Left=�6-   $��327,298,0,0q�6H   $	��Top=�6]   $��50��6u   
���   �
�������$��Cooper Black)�6�   $��Normal"�6�   $��22��6�   $y�Hidden=�6�   �� 5   
   -   5        $��btnStant��5      $��Stant��6!   $
��Left=�61   $��419,298,0,0q�6L   $	��Top=�6a   $��50��6y   
�������
���   �$��Cooper Black)�6�   $��22��6�   $y�Hidden=�6�   �� 5   
   -   5        $��btnStart��5      $��Start��6!   $
��Left=�61   $��375,298,0,0q�6L   $	��Top=�6a   $��50��6y   
�������
���   �$��Cooper Black)�6�   $��22��6�   6�   �� 5   
   -   5        $��txtHandPlayer��5      $
��Left=�6)   $	��156��6D   $��298,121,0,0q�6Q   $�� ��6f   $
��Wrap=�6n   $	��Top=�6�   $��54��6�   $��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -   5        $��txtHandDealer��5      $
��Left=�6)   $	��156��6D   $��444,121,0,0q�6Q   $�� ��6f   $
��Wrap=�6n   $	��Top=�6�   $��54��6�   $��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -   5        $��lblHandPlayer��5      $��Hand Player :��6%   $
��Left=�6=   $��293,102,0,0q�6X   $	��Top=�6m   $��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -   5        $��lblHandDealer��5      $��Hand Dealer :��6%   $
��Left=�6=   $��439,102,0,0q�6X   $	��Top=�6m   
���   �$��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -   5        $��lblHandPlayerValue��5      $��Hand Value :��6*   $
��Left=�6A   $��292,257,0,0q�6\   $	��Top=�6q   $��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -	   5        $��txtHandPlayerValue��5      $
��Left=�6.   $��13��6I   $��366,263,0,0q�6U   $�� ��6j   $
��Wrap=�6r   $	��Top=�6�   $��22��6�   $��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -
   5        $��btnPlayAgain��5      $��
Play Again��6%   $
��Left=�6:   $��360,298,0,0q�6U   $	��Top=�6j   $��80��6�   
�������
���   �$��Cooper Black)�6�   $��22��6�   $y�Hidden=�6�   �� 5   
   -   5        $��lblGamesWin��5      $��Games Win :��6#   $
��Left=�69   $��
36,164,0,0q�6T   $	��Top=�6h   $�� Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -   5        $��lblGamesLose��5      $��Games Lose :��6$   $
��Left=�6;   $��
36,190,0,0q�6V   $	��Top=�6j   $��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -   5        $��txtGamesWin��5      $
��Left=�6'   $��13��6B   $��108,170,0,0q�6N   $�� ��6c   $
��Wrap=�6k   $	��Top=�6   $��64��6�   $��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -   5        $��txtGamesLose��5      $
��Left=�6(   $��12��6C   $��115,196,0,0q�6O   $�� ��6d   $
��Wrap=�6l   $	��Top=�6�   $��66��6�   $��Bahnschrift)�6�   $y�Hidden=�6�   �� 5   
   -   5        $��imgGame��5      $K��EC:\Users\USUARIO\source\repos\Juego_POO\Resources\Chapter7_Image2.png��6   $
��Left=�6n   $	��184��6�   $��	205,0,0,0q�6�   $��Center=�6�   $	��390��6�    J� RenderTransformOrigin$ 
0.506,0.55&�6�   5"      5#      