   M S B A M L   `   `   `  ���� A  =Brutu!, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Brutu__.ViewModelsBrutu__.ViewModels  !clr-namespace:Brutu__Brutu__      Brutu__.EschaScene   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /vm clr-namespace:Brutu__.ViewModels     'localclr-namespace:Brutu__     -     N�Name$  escha�� N� Title$ 
EschaScene�� N� 
Background
 �   �.���  � RowDefinitions �� $	��100 ��� $��* �.+�� $��0��y��� *ProgressVisibility+.+��� $��	0,25,30,0q�$��Center=�$��14(�
�������$	��Top=����� *
Progress+�� $��0,25,0,0q�$��Center=�$��14(�
�������$	��Top=�$��/���� $��	30,25,0,0q�$��Center=�$��14(�
�������$	��Top=����� *ProgressMax+� -   $��useProgress��$��Bottom=�$��0,0,0,10q�$	��500��$��40�� � Value �� *
Progress+ � Maximum �� *ProgressMax+�� $��1��$��Disabled=�$	��225��$	��500��$	��Top=�$��Center=�
���   � �� SelectedIndex �� *SelectedIndex+.@��� -   $��siltLBI��.���� $	��490�� �� Orientation$ 
Horizontal=�.+��� $��	0,0,250,0q�$��24(�$��
Silt Pouch��
��������� $��Center=�$��12(�
����������� *SiltPouchTotalText+�� -   $��beadsLBI��.���� $	��490��$ 
Horizontal=�.+��� $��	0,0,230,0q�$��24(�$��
Bead Pouch��
��������� $��Center=�$��12(�
����������� *BeadPouchTotalText+�� -   $��eschaStartButton��$��
200,0,0,25q�$��Bottom=�$��90��$��40��$��1��$��22(�{��� *ButtonEnabled+���� *StartClickCommand+���� *
ButtonText+�� -   $��eschaStopButton��$��
400,0,0,25q�$��Bottom=�$��90��$��40��$��1��$��Pause��$��22(�y��� *StopVisibility+���� *StopClickCommand+