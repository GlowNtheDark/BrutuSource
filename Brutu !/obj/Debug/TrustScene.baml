   M S B A M L   `   `   `  ����A  =Brutu!, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Brutu__.ViewModelsBrutu__.ViewModels  5          Brutu__.TrustScene   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      )vm clr-namespace:Brutu__.ViewModels  5        N� Title$  
TrustScene��5
       N� 
Background
 �   �.��5      � .+�5   
   �� -   5        $��
OpenButton��5      $��	24,53,0,0q�6H   $
��Left=�6[   $	��Top=�6v   $
��Open��6�   $��25��6�   $��50��6�   ��6#   �� *OpenClickCommand+6�   �� 5   
   -   5        $��
SaveButton��5   9   $��	96,53,0,0q�6K   $
��Left=�6^   $	��Top=�6y   $
��Save��6�   $��25��6�   $��50��6�   {�6   �� *SaveButtonEnabled+6�   �� 5   
   -   5        $��FileStatusText��5      $��	10,20,0,0q�6*   $��20(�6=   
�������$
��Left=�6w   $	��Top=�6�   ��6^   �� *	TopText+6�   �� 5   
   -   5        $��SavedListsLB��5      $��
24,95,0,55q�6o   $��Center=�6�   $
��Left=�6�   $��24(�6�   
�������
���   �$	��275��6�   $	��200��6�    �� SelectedIndex 6&   �� *	ListIndex+��6J   �� *TulViewModel+.  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5         	EventName$ MouseDoubleClick��6!   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction     Command 6,   �� *ItemClickCommand+5      ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��22(�6:   
���������6$   �� *Name+6H   5      5      5      �� 5   
   -   5        $��SavedTrustsLB��5      $��
0,95,51,55q�6q   $��Center=�6�   $��Right=�6�   $��24(�6�   
�������
���   �$	��275��6�   $	��200��6�    6'   �� *
TrustIndex+��6L   �� *TilViewModel+��5      �� 5       .R�5!      �� $ 
Horizontal=�6!   .+�5"      �� $��22(�6:   
���������6$   �� *Name+6H   5#      5$      5&      �� 5'   
   -   5        $��ListAddButton��5'      $��	69,0,0,10q�6&   $
��Left=�69   $��Bottom=�6T   $	��Add��6o   $��25��6}   $��50��6�   �� 5(   
   -   5        $��ListRemoveButton��5(   ?   $��
149,0,0,10q�6W   $
��Left=�6k   $��Bottom=�6�   $��Remove��6�   $��25��6�   $��50��6�   {�6   �� *ListRemoveButtonEnabled+6�   �� 5)   
   -   5        $��TrustAddButton��5)      $��
389,0,0,10q�6'   $
��Left=�6;   $��Bottom=�6V   $	��Add��6q   $��25��6   $��50��6�   �� 5*   
   -	   5        $��TrustRemoveButton��5*   @   $��
469,0,0,10q�6Y   $
��Left=�6m   $��Bottom=�6�   $��Remove��6�   $��25��6�   $��50��6�   {�6   �� *TrustRemoveButtonEnabled+6�   �� 5+   
   -
   5        $��	ArrowText��5+      $��36(�6%   $
��Left=�63   $��267,200,0,0q�6N   
�������$
��Wrap=�6v   $��->��6�   $	��Top=�6�   $��53��6�   $��42��6�   �� 5,   
   -   5        $��TrustLBText��5,      $��20(�6'   $
��Left=�65   $��
349,63,0,0q�6P   $
��Wrap=�6d   $��Trusts in list:��6x   
�������$	��Top=�6�   �� 5-   
   -   5        $��SummonButton��5-   ;   $��
494,61,0,0q�6O   $
��Left=�6c   $	��Top=�6~   $��Summon��6�   $��25��6�   $��55��6�   {�6   �� *SummonButtonEnabled+6�   5.      5/      