   M S B A M L   `   `   `  ����=  9GH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GHGH  5          GH.ListRealtor   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:GH     5      -   5          N� Title$  ListRealtor��5	       N� 
Background �#D9D9D9.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��10 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��20 �6   �� 5      $	��400 �6   .+�5   
   � $��0��6   $��2��6   ���#50CE3B J� Opacity$
 0.10Q�6E   �� 5   
   $��Риэлторы��6   $��2��6#   $��35(�67   ���#3C9755$��10,0,0,0q�6Z   $��0��6l   �� 5   
   $��\Resourses\nameuser.png��6   $��0��61   $��240,18,274,18q�6>   �� 5   
   -   5         ��Name$ nameuser��5      $��0��6"   $��290,18,10,18q�6/   $%��Шакирова Эвелина��6E   $��18(�6`   �� 5   
   -   5         ��Name$ search_textbox��5      $��2��6*   $��
10,0,100,1q�67   
���   ����#C8C6C66_   �� 5   
   -   5        $��search_button��5      
������ $��2��6@   $��
465,0,50,0q�6M   
���   �.��5      �� $��\Resourses\search.png��6   $��25��63   $��38��6?   5      �� 5   
   -   5        $��addrealtor_button��5      $��3��6*   ���#99CE86���#3C9755$��
10,5,359,0q�6c    � 	Resources 5        �� 
TargetType �� Property	 �� Value��%_   '��       �� 5!      " ��6   .�5"      ��  �@��CornerRadius$	 10��65   5#      5$      .��5%      �� 
 �� Orientation$
 
Horizontal=�6   .+�5&      �� $��Center=�6   $��Center=�69   #!Добавить риэлтора6g   �� 5'      $��\Resourses\addClient.png��6   $��23��6:   $��40��6F   5(      5)      �� 5*   
   -   5        $��deliterealtor_button��5*      $��3��6-   ���#99CE86���#3C9755$��246,5,135,0q�6f    5+      ��%_   '��       �� 5,      " ��6   .�5-      ��  �@��CornerRadius$	 10��65   5.      5/      .��50      �� $
 
Horizontal=�6   .+�51      �� $��Center=�6   $��Center=�69   !Удалить риэлтора6f   �� 52      $��\Resourses\delete.png��6   $��27��67   $��47��6C   53      54      �� 56   
   -   5         ��Name$ RealtorsListListBox��56      $��5��6/   $��Stretch=�6<   57      58      