   M S B A M L   `   `   `  ����B  >Brutu !, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Brutu__.ViewModelsBrutu__.ViewModels  5      !clr-namespace:Brutu__Brutu__  5          Brutu__.EschaScene   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /vm clr-namespace:Brutu__.ViewModels     5      'localclr-namespace:Brutu__     5      -   5          N�Name$  escha��5
       N� Title$ 
EschaScene��6    N� 
Background
 �   �.��5      �  � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   � $��0��6   y�6   �� *ProgressVisibility+.+�5      �� $��	0,25,30,0q�6   $��Center=�6+   $��14(�6H   
�������$	��Top=�6i   ��6�   �� *
Progress+�� 5      $��0,25,0,0q�6   $��Center=�6+   $��14(�6H   
�������$	��Top=�6i   $��/��6�   �� 5      $��	30,25,0,0q�6   $��Center=�6,   $��14(�6I   
�������$	��Top=�6j   ��6�   �� *ProgressMax+� 5      -   5        $��useProgress��5   U   $��Bottom=�6h   $��0,0,0,10q�6�   $	��500��6�   $��40��6�    � Value 6   �� *
Progress+ � Maximum 65   �� *ProgressMax+6�   5      �� 5      $��1��66   $��Disabled=�6C   $	��225��6y   $	��500��6�   $	��Top=�6�   $��Center=�6�   
���   � �� SelectedIndex 6   �� *SelectedIndex+.@�5      �� -   5        $��siltLBI��5      .��5      �� $	��490��6    �� Orientation$ 
Horizontal=�6)   .+�5      �� $��	0,0,250,0q�6   $��24(�6/   $��
Silt Pouch��6=   
�������6O   �� 5      $��Center=�6    $��12(�6;   
���������6I   �� *SiltPouchTotalText+6m   5      5      �� 5      -   5        $��beadsLBI��5      .��5      �� $	��490��6   $ 
Horizontal=�6)   .+�5       �� $��	0,0,230,0q�6    $��24(�63   $��
Bead Pouch��6A   
�������6S   �� 5!      $��Center=�6    $��12(�6;   
���������6I   �� *BeadPouchTotalText+6m   5"      5#      5$      �� 5%   
   -   5        $��eschaStartButton��5%   5   $��
200,0,0,25q�6t   $��Bottom=�6�   $��90��6�   $��40��6�   $��1��6�   $��22(�6�   {�6   �� *ButtonEnabled+��6N   �� *StartClickCommand+��6�   �� *
ButtonText+6�   �� 5&   
   -   5        $��eschaStopButton��5&   7   $��
400,0,0,25q�6t   $��Bottom=�6�   $��90��6�   $��40��6�   $��1��6�   $��Pause��6�   $��22(�6�   y�6   �� *StopVisibility+��6O   �� *StopClickCommand+6�   5(      5)      