   M S B A M L   `   `   `  ����A  =Brutu!, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Brutu__Brutu__  5          Brutu__.ZnmScene   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Brutu__     5        N� Title$  ZnmScene��5	       N� 
Background
 �   �.��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Trapper��6   $��24(�6#   $��0,10,0,0q�61   $��Center=�6C   
�������$��0��6s   �� 5   
   $��Choose a trapper to use.��6   $��18(�64   $��5,55,0,0q�6B   $
��Left=�6T   
�������$��0��6�   �� 5   
   $��	0,5,0,175q�6   $��0��6M   $��Disabled=�6]   $��80��6�   $	��295��6�   $��Center=�6�   $
��Left=�6�   
���   � �� SelectedIndex 6%   �� *SelectedIndex+.@�5      �� -   5        $��nqLBI��5      y�6'   �� *NqTrapperFound+.��5      �� $	��290��6    �� Orientation$ 
Horizontal=�6)   .+�5      �� $��	0,0,150,0q�6    $��22(�63   $��Soultrapper��6A   
�������6T   5      5      �� 5      -   5        $��hqLBI��5      y�6'   �� *HqTrapperFound+.��5      �� $	��290��6   $ 
Horizontal=�6)   .+�5      �� $��	0,0,150,0q�6    $��22(�63   $��Soultrapper2000��6A   
�������6X   5      5      5      �� 5   
   $��14(�6   $��	5,15,0,75q�6"   $��Center=�65   
�������$+��%Here's how many blank plates I found:��6c   �� 5   
   $��25��6   $��14(�6   $��250,15,0,75q�6-   $��Center=�6B   
���������6p   �� *BlankSoulPlateCount+�� 5    
   $
��Left=�6   $��80��6/   $	��200��6;   $
��Wrap=�6G   $��14(�6[   $��5,75,0,0q�6i   $��Center=�6{   
�������$m��gAssuming you've cornered something, Click Start. I'll try to equip your stuff and start trapping souls.��6�   �� 5!   
   $��0��6d   $��0,50,7,0q�6t   $��Center=�6�   $��Right=�6�   $��24(�6�   $��40��6�   $��90��6�   ��6   �� *TrapperClickCommand+{�69   �� *TrapperButtonEnabled+��6�   �� *TrapperButtonText+6�   � 5"   
   -   5        $��trapProgressGrid��5"   ;   $��0��6S   y�6   �� *TrapperGridVisibilty+.+�5#      �� $��	25,0,0,70q�6   $
��Left=�6+   $��14(�6F   
�������$��Bottom=�6g   $��Working on your plates:��6�   �� 5$      $��	80,0,0,70q�6   $��Center=�6+   $��14(�6H   
�������$��Bottom=�6i   ��6�   �� *TrapperProgress+�� 5%      $��
110,0,0,70q�6   $��Center=�6,   $��14(�6I   
�������$��Bottom=�6j   $��/��6�   �� 5&      $��
140,0,0,70q�6   $��Center=�6,   $��14(�6I   
�������$��Bottom=�6j   ��6�   �� *TrapperProgressMax+� 5'      $��0,0,0,10q�6c   $	��250��6u   $��Bottom=�6�   $��50��6�    � Value 6   �� *TrapperProgress+ � Maximum 6<   �� *TrapperProgressMax+6�   5(      �� 5)   
   	 �� X1$ 0��6   	 �� Y1$ 0��6   		 �� X2$	 0��6   	
 �� Y2$	
 450��6$   
�������$��10��6:   
�������$��3��6^   $
��Auto��6h   $��0��6v   $��Right=�6�   �� 5*   
   $��Trading��6   $��24(�6#   $��0,10,0,0q�61   $��Center=�6C   
�������$��1��6t   �� 5+   
   $%��Total Soul Plates in inventory:��6   $��18(�6;   $��5,55,0,0q�6I   $
��Left=�6[   
�������$��1��6�   �� 5,   
   $��18(�64   $��	5,55,25,0q�6B   $��Right=�6U   
�������$��1��6�   ��6   �� *SoulPlateCount+6�   �� 5-   
   $7��1Make sure your next to Sanraku. Then click Trade.��6   $
��Wrap=�6M   $��18(�6a   $��	5,100,0,0q�6o   $
��Left=�6�   
�������$��1��6�   �� 5.   
   $l��fThis is designed to be used with the windower plugin Enternity. Get it loaded or this won't work well.��6   $��Center=�6�   $
��Wrap=�6�   $��14(�6�   $��5,30,0,0q�6�   $
��Left=�6�   
�������$��1��6�   �� 5/   
   $��
100,0,0,75q�6`   $��Center=�6t   $��Center=�6�   $��24(�6�   $��40��6�   $��90��6�   $��1��6�   ��6   �� *TradeClickCommand+{�67   �� *TradeButtonEnabled+��6�   �� *TradeButtonText+6�   � 50   
   -   5        $��tradeProgressGrid��50   9   $��1��6R   y�6   �� *TradeGridVisibilty+.+�51      �� $��	25,0,0,70q�6   $
��Left=�6+   $��14(�6F   
�������$��Bottom=�6g   $��Trading your shit:��6�   �� 52      $��	80,0,0,70q�6   $��Center=�6+   $��14(�6H   
�������$��Bottom=�6i   ��6�   �� *TradeProgress+�� 53      $��
110,0,0,70q�6   $��Center=�6,   $��14(�6I   
�������$��Bottom=�6j   $��/��6�   �� 54      $��
140,0,0,70q�6   $��Center=�6,   $��14(�6I   
�������$��Bottom=�6j   ��6�   �� *TradeProgressMax+� 55      $��0,0,0,10q�6_   $	��250��6q   $��Bottom=�6}   $��50��6�    6   �� *TradeProgress+ 6:   �� *TradeProgressMax+6�   56      57      58      