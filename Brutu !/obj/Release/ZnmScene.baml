   M S B A M L   `   `   `  ���� A  =Brutu!, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:Brutu__Brutu__      Brutu__.ZnmScene   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     'localclr-namespace:Brutu__       N� Title$  ZnmScene�� N� 
Background
 �   �.���  � ColumnDefinitions �� $��* ��� $��* �.+��� $��Trapper��$��24(�$��0,10,0,0q�$��Center=�
�������$��0���� $��Choose a trapper to use.��$��18(�$��5,55,0,0q�$
��Left=�
�������$��0���� $��	0,5,0,175q�$��0��$��Disabled=�$��80��$	��295��$��Center=�$
��Left=�
���   � �� SelectedIndex �� *SelectedIndex+.@��� -   $��nqLBI��y��� *NqTrapperFound+.���� $	��290�� �� Orientation$ 
Horizontal=�.+��� $��	0,0,150,0q�$��22(�$��Soultrapper��
��������� -   $��hqLBI��y��� *HqTrapperFound+.���� $	��290��$ 
Horizontal=�.+��� $��	0,0,150,0q�$��22(�$��Soultrapper2000��
��������� $��14(�$��	5,15,0,75q�$��Center=�
�������$+��%Here's how many blank plates I found:���� $��25��$��14(�$��250,15,0,75q�$��Center=�
����������� *BlankSoulPlateCount+�� $
��Left=�$��80��$	��200��$
��Wrap=�$��14(�$��5,75,0,0q�$��Center=�
�������$m��gAssuming you've cornered something, Click Start. I'll try to equip your stuff and start trapping souls.���� $��0��$��0,50,7,0q�$��Center=�$��Right=�$��24(�$��40��$��90������ *TrapperClickCommand+{��� *TrapperButtonEnabled+���� *TrapperButtonText+� -   $��trapProgressGrid��$��0��y��� *TrapperGridVisibilty+.+��� $��	25,0,0,70q�$
��Left=�$��14(�
�������$��Bottom=�$��Working on your plates:���� $��	80,0,0,70q�$��Center=�$��14(�
�������$��Bottom=����� *TrapperProgress+�� $��
110,0,0,70q�$��Center=�$��14(�
�������$��Bottom=�$��/���� $��
140,0,0,70q�$��Center=�$��14(�
�������$��Bottom=����� *TrapperProgressMax+� $��0,0,0,10q�$	��250��$��Bottom=�$��50�� � Value �� *TrapperProgress+ � Maximum �� *TrapperProgressMax+�� 	 �� X1$ 0��	 �� Y1$ 0��		 �� X2$	 0��	
 �� Y2$	
 450��
�������$��10��
�������$��3��$
��Auto��$��0��$��Right=��� $��Trading��$��24(�$��0,10,0,0q�$��Center=�
�������$��1���� $%��Total Soul Plates in inventory:��$��18(�$��5,55,0,0q�$
��Left=�
�������$��1���� $��18(�$��	5,55,25,0q�$��Right=�
�������$��1������ *SoulPlateCount+�� $7��1Make sure your next to Sanraku. Then click Trade.��$
��Wrap=�$��18(�$��	5,100,0,0q�$
��Left=�
�������$��1���� $l��fThis is designed to be used with the windower plugin Enternity. Get it loaded or this won't work well.��$��Center=�$
��Wrap=�$��14(�$��5,30,0,0q�$
��Left=�
�������$��1���� $��
100,0,0,75q�$��Center=�$��Center=�$��24(�$��40��$��90��$��1������ *TradeClickCommand+{��� *TradeButtonEnabled+���� *TradeButtonText+� -   $��tradeProgressGrid��$��1��y��� *TradeGridVisibilty+.+��� $��	25,0,0,70q�$
��Left=�$��14(�
�������$��Bottom=�$��Trading your shit:���� $��	80,0,0,70q�$��Center=�$��14(�
�������$��Bottom=����� *TradeProgress+�� $��
110,0,0,70q�$��Center=�$��14(�
�������$��Bottom=�$��/���� $��
140,0,0,70q�$��Center=�$��14(�
�������$��Bottom=����� *TradeProgressMax+� $��0,0,0,10q�$	��250��$��Bottom=�$��50�� �� *TradeProgress+ �� *TradeProgressMax+