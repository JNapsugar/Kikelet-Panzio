   M S B A M L   `   `   `  ����J  FKikelet_Panzió, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Kikelet_PanzióKikelet_Panzió  5   	   #    Kikelet_Panzió.Szobafoglalas   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Kikelet_Panzió     5   	     � Title$  Szobafoglalas��5   	   $	��450��6   $	��700��6,    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   6E   �� 5       � ��$ 20(�6)   66   �� 5       � ��$
 left=�64   6C   �� 5       � ��$	 0,5q�6'   65   5      5      .��5      � 
����İ� � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��55 �6   6*   �� 5      6   .+�5   
   �� $&�� Kikelet Panzió - Szobafoglalás��6   $��35(�6:   $��Vivaldi)�6H   $��2��6]   $��0,5,0,5q�6q   $	��525��6�   6�   �� 5   
   -   5        $��	btnVissza��5      $��Vissza��6"   
�������$��Times New Roman)�6L   $��1��6i   $��30��6y   $��60��6�   $��Right=�6�   $
��15,0q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dgrSzobak��5      $��1��6$   
�������6t   �� 5   
   $��1��6   $��1��6%   $
��30,0q�62   $��Center=�6@   .+�5      ]� .+�5       �� $��Hány főre:��6   6/   �� 5!      -   5        $��cmbFerohelyek��5!      $	��120��60   $��Right=�6<   $��30��6X   6�   5"      ]� 5#      .+�5$      �� $��Ettől:��6   $��Center=�6)   6F   �� 5%      -   5        $��txbEttol��5%      $	��120��6*   $��Right=�66   $��30��6R   $��Center=�6�   6�   5&      ]� 5'      .+�5(      �� $��Eddig:��6   $��Center=�6*   6G   �� 5)      -   5        $��txbEddig��5)      $	��120��6*   $��Right=�66   $��30��6R   $��Center=�6�   6�   5*      ]� 5+      .+�5,      �� $��Fizetendő összeg��6   $��Center=�64   6Q   �� 5-      -   5        $��lblFizetendo��5-   @   $�� ��6   $��Right=�6$   6V   5.      ]� 5/      $��Center=�6   .+�50      �� -   5        $��Kereses��50      $��Keresés��6(   
�������$��30��6S   $	��100��6_   $��10,20q�6k   6�   �� 51      -   5        $��Foglalas��51      $��	Foglalás��6)   
�������$��30��6U   $	��100��6a   $��10,20q�6m   6�   52      56      57      58      