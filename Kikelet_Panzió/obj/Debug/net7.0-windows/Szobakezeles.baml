   M S B A M L   `   `   `  ����J  FKikelet_Panzió, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Kikelet_PanzióKikelet_Panzió  5   	   "    Kikelet_Panzió.Szobakezeles   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Kikelet_Panzió     5   	     � Title$  Szobák kezelése��5   	   $	��450��6!   $	��800��6.    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   6E   �� 5       � ��$ 20(�6)   66   �� 5       � ��$
 left=�64   6C   �� 5       � ��$	 0,5q�6'   65   5      5      .��5      � 
����İ� � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!    � RowDefinitions 5   
   �� 5      $��55 �6   6*   �� 5      6   .+�5   
   �� $��Kikelet Panzió - Szobák��6   $��35(�63   $��Vivaldi)�6A   6X   �� 5   
   -   5        $��	btnVissza��5      $��Vissza��6"   
�������$��Times New Roman)�6L   $��1��6i   $��30��6y   $��60��6�   $��Right=�6�   $
��15,0q�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dgrSzobak��5      $��1��6$   
�������6t   �� 5   
   $��1��6   $��1��6%   $
��30,0q�62   .+�5      �� -   5        $��lblSzobaszam��5   )   $��
1-es Szoba��6   $��30(�6=   $��Center=�6K   $��	0,20,0,25q�6h   6}   ]� 5       .+�5!      �� $��Férőhelyek száma:��6   66   �� 5"      -   5        $��cmbFerohelyek��5"      $	��100��60   $��Right=�6<   $��30��6X    �� SelectedValue 6d   �� *
Ferohelyek+ �� Mode$ OneWay=�6�   5#      ]� 5$      .+�5%      �� $"��Aktuális ár 1fő/1éjszaka��6   6=   �� 5&      -   5        $��txbAr��5&      $	��100��6'   $��Right=�63   $��30��6O   $��Center=�6~   ��6[   �� *Ar+$ OneWay=�6�   5'      ]� 5(      $��0,20,0,0q�6   .+�5)      �� $��Foglaltság:��6   60   �� 5*      -   5        $��
cbxFoglalt��5*      $��Center=�6-   $
��Left=�6H   	 d� 	IsChecked	 6c   �� *	Foglalt+$ OneWay=�6�   �� 5+      $��Ettől:��6   $��60,0,0,0q�6)   $��Center=�6;   6X   �� 5,      -   5        $��txbEttol��5,      ${�False��6*   $	��100��6<   $��Right=�6H   $��30��6d   $��Center=�6�   ��6p   �� *Mettol+$ OneWay=�6�   5-      ]� 5.      .+�5/      �� $��Eddig:��6   $��	170,0,0,0q�6)   $��Center=�6<   6Y   �� 50      -   5        $��txbEddig��50      ${�False��6*   $	��100��6<   $��Right=�6H   $��30��6d   $��Center=�6�   ��6p   �� *Meddig+$ OneWay=�6�   51      ]� 52      $��Center=�6   .+�53      �� -	   5        $��	btnMentes��53      $��Mentés��6*   $	��120��6;   $��35��6G   $��10,20q�6S   6|   �� 54      -
   5        $��btnSzobaFelvitel��54      $��Új szoba felvitele��61   $	��120��6N   $��35��6Z   $��10,20q�6f   6�   55      57      58      59      