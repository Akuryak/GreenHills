   M S B A M L   `   `   `  ����=  9GH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GHGH  5          GH.Object_realtor   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:GH     5      -   5          N� Title$  Object_realtor��5	       N� 
Background �#D9D9D9.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��10 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $	��450 �6   .+�5   
   � $��0��6   $��2��6   ���#50CE3B J� Opacity$
 0.10Q�6E   �� 5   
   $��Объекты��6   $��2��6"   $��35(�66   ���#3C9755$��10,0,0,0q�6Y   $��0��6k   �� 5   
   $��\Resourses\nameuser.png��6   $��0��61   $��246,18,270,18q�6>    J� RenderTransformOrigin$ 2.207,0.626&�6U   �� 5   
   -   5         ��Name$ nameuser��5      $��0��6"   $��290,18,10,18q�6/   $%��Шакирова Эвелина��6E   $��18(�6`   �� 5   
   -   5         ��Name$ search_textbox��5      $��2��6*   $��
10,0,162,1q�67   
���   ����#C8C6C66_   �� 5   
   -   5        $��search_button��5      
������ $��2��6@   $��420,0,103,0q�6M   
���   �.��5      �� $��\Resourses\search.png��6   $��25��63   $��38��6?   5      �� 5   
   -   5        $��filter_button��5      $��2��6&   
������ 
���   �$��
462,0,49,0q�6a   .��5      �� $��\Resourses\filter.png��6   $��27��63   $��36��6?   5      �� 5!   
   -   5        $��addObject_button��5!      $��3��6)   ���#99CE86���#3C9755$��
10,5,340,0q�6b    � 	Resources 5"       �� 
TargetType	 �� Property
 �� Value��%_   '��       �� 5#      " ��6   .�5$      �� 	 �@��CornerRadius$
 10��65   5%      5&      .��5'      ��  �� Orientation$ 
Horizontal=�6   .+�5(      �� $��Center=�6   $��Center=�69   Добавить объект6e   �� 5)      $��\Resourses\add-house.png��6   $��27��6:   $��47��6F   5*      5+      �� 5,   
   -   5        $��deliteObject_button��5,      $��3��6,   ���#99CE86���#3C9755$��235,5,135,0q�6e    5-      ��%_   '��       �� 5.      " ��6   .�5/      �� 	 �@��CornerRadius$
 10��65   50      51      .��52      �� $ 
Horizontal=�6   .+�53      �� $��Center=�6   $��Center=�69   Удалить объект6d   �� 54      $��\Resourses\delete.png��6   $��27��67   $��47��6C   55      56      �� 58   
   -   5         ��Name$ ObjectsListBox��58      $��5��6*   $��10q�67   $��Stretch=�6C   5:      5;      