   M S B A M L   `   `   `  ����=  9GH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GHGH  5          GH.Document_realtor_   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:GH     5      -   5          N� Title$  Document_realtor_��5	       N� 
Background �#D9D9D9.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��10 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $	��450 �6   .+�5   
   � $��0��6   $��2��6   ���#50CE3B J� Opacity$
 0.10Q�6E   �� 5   
   $��Договора��6   $��2��6#   $��35(�67   ���#3C9755$��10,0,0,0q�6Z   $��0��6l   �� 5   
   $��\Resourses\nameuser.png��6   $��0��61   $��246,18,270,18q�6>   �� 5   
   -   5         ��Name$ nameuser��5      $��0��6"   $��290,18,10,18q�6/   $%��Шакирова Эвелина��6E   $��18(�6`   �� 5   
   -   5         ��Name$ search_textbox��5      $��2��6*   $��
10,0,255,1q�67   
���   ����#C8C6C66_   �� 5   
   -   5        $��search_button��5      
������ $��2��6@   $��310,0,205,0q�6M   
���   �.��5      �� $��\Resourses\search.png��6   $��25��63   $��38��6?   5      �� 5   
   -   5         ��Name$ Filter_combox��5       �� SelectedIndex$ 0��6*   $��2��6<   $��	360,0,5,0q�6I   .@�5      �� $��Все��6   �� 5      $��
Купли��6   �� 5       $��Продажи��6   5!      �� 5#   
   -   5        $��addDoc_button��5#      $��3��6&   ���#99CE86���#3C9755$��
10,5,359,0q�6_    � 	Resources 5$      	 �� 
TargetType
 �� Property �� Value��%_   '��       �� 5%      "	 ��6   .�5&      �� 
 �@��CornerRadius$ 10��65   5'      5(      .��5)      ��  �� Orientation$ 
Horizontal=�6   .+�5*      �� $��Center=�6   $��Center=�69   !Добавить договор6f   �� 5+      $ ��\Resourses\addDocument.png��6   $��27��6<   $��47��6H   5,      5-      �� 5.   
   -   5        $��deliteDoc_button��5.      $��3��6)   ���#99CE86���#3C9755$��225,5,135,0q�6b    5/      ��%_   '��       �� 50      "	 ��6   .�51      �� 
 �@��CornerRadius$ 10��65   52      53      .��54      �� $ 
Horizontal=�6   .+�55      �� $��Center=�6   $��Center=�69   Удалить договор6e   �� 56      $��\Resourses\delete.png��6   $��27��67   $��47��6C   57      58      �� 5:   
   -   5         ��Name$ DocumentsListBox��5:      $��4��6,   $��10,10,10,10q�69   $��Stretch=�6N   5;      5<      