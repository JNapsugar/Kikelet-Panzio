   M S B A M L   `   `   `  ����J  FKikelet_Panzió, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Kikelet_PanzióKikelet_Panzió  5   	   "    Kikelet_Panzió.Statisztikak   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Kikelet_Panzió     5   	     � Title$  Statisztikak��5   	   $	��450��6   $
��1100��6+    � 	Resources 5	       �� 
TargetType �� Property �� Value��%�   '��       �� 5
   
   " ��6   .�5      ��  � ��$ Times New Roman)�6+   6E   �� 5       � ��$ 20(�6)   66   5      5      .��5      � 
����İ� � ColumnDefinitions 5   
   �� 5      $	��350 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      $��55 �6   6*   �� 5      6   .+�5   
   �� $&�� Kikelet Panzió - Sztatisztikák��6   $��35(�6:   $��Vivaldi)�6H   $��2��6]   $��0,5,0,5q�6q   $	��525��6�   $
��Left=�6�   6�   �� 5   
   -   5        $��	btnVissza��5      $��Vissza��6"   
�������$��Times New Roman)�6L   $��1��6i   $��30��6y   $��60��6�   $��Right=�6�   $
��15,0q�6�   6�   �� 5   
   $��2��6   .+�5      �� -   5        $��lblLegtobbet��5      $ ��Legtöbbet kiadott szoba: ��6(   $��	20,50,0,0q�6M   6b   �� 5      -   5        $��
lblBevetel��5      $��
Bevétel: ��6&   $��	20,20,0,0q�6;   6P   �� 5      -   5        $��	lblOsszes��5      $��	Összes: ��6%   $��	20,10,0,0q�69   $��15(�6L   6\   �� 5      -   5        $��lblIdoszakos��5      $��Időszakon belüli: ��6(   $��	20,10,0,0q�6F   $��15(�6Y   6i   ]� 5       $��Center=�6   .+�5!      �� -   5        $��txbEttol��5!      $	��100��6*   $��30��66   $��Center=�6B   6f   �� 5"      $��-��6   6&   �� 5#      -   5        $��txbEddig��5#      $	��100��6*   $��30��66   $��Center=�6B   6f   5$      �� 5%      -   5        $��btnSzamitas��5%      $��Számítás��6(   $	��100��6;   $��30��6G   $��10q�6S   6{   5&      �� 5'   
   $��2��6   $��2��6"   .+�5(      �� $��Visszatérő vendégek��6   64   &   System.Windows.Controls.DataGrid  5)      -	   5        $��dgrVisszaterok��5)      $	��350��6-   6<   5*      5,      5-      