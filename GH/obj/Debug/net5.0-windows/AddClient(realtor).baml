   M S B A M L   `   `   `  ����=  9GH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GHGH  5          GH.AddClient_realtor_   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:GH     5      ] YXceed.Wpf.Toolkit.NET5, Version=4.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5      -   5          N� Title$  AddClient_realtor_��5
       N� 
Background �#D9D9D9.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��20 �6   �� 5      $��60 �6   �� 5      $	��220 �6   �� 5      $	��220 �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   � $��0��6   $��2��6   ���#50CE3B J� Opacity$
 0.10Q�6E   �� 5   
   $��Клиенты��6   $��2��6"   $��35(�66   ���#3C9755$��10,0,0,0q�6Y   $��0��6k   �� 5   
   $��\Resourses\nameuser.png��6   $��0��61   $��251,18,261,18q�6>   $��2��6U   �� 5   
   -   5         ��Name$ nameuser��5      $��33,18,15,18q�6"   $%��Шакирова Эвелина��67   $��18(�6R   $��1��6`   � 5   
   $��3��6   
�������$	 0.5Q�60   $��15q�6>   $��2��6J   �� 5   
   $��Тип клиента:��6   $��2��6'   $��15(�64   �� 5   
   -   5         ��Name$ buyer_button��5   �   $��2��6   $��10,27,150,10q�6   ���#99CE86���#3C9755$��Покупатель��6_   $��15(�6t   6�   �� 5    
   -   5        $ 
sob_button��5    �   $��2��6   $��140,27,30,10q�6   ���#99CE86���#3C9755$��Собственник��6_   $��15(�6u   6�   �� 5!   
   $��Фамилия:��6   $��3��6#   $��0��60   $��15,27,150,160q�6@   �� 5"   
   -   5         ��Name$ surname_textbox��5"      $��3��6+   $��0��68   $��90,30,40,170q�6H   �� 5#   
   $��Имя:��6   $��3��6   $��0��6,   $��15,60,150,130q�6<   �� 5$   
   -   5        $ name_textbox��5$      $��3��6(   $��0��65   $��60,63,60,135q�6E   �� 5%   
   $��Отчество:��6   $��3��6$   $��0��61   $��15,90,150,100q�6A   �� 5&   
   -   5        $ patronymic_textbox��5&      $��3��6.   $��0��6;   $��90,95,30,105q�6K   �� 5'   
   $��Телефон:��6   $��3��6#   $��0��60   $��15,130,134,60q�6@   %  Xceed.Wpf.Toolkit.MaskedTextBox  5(   
   -   5          Name$ Phone_textBox��5(   6   	   Mask$	 +0(000) 000-00-00��6   $��3��6M   $��0��6Z   $��80,130,20,67q�6j   �� 5)   
   $��Пароль :��6   $��3��6#   $��1��60   $��15,27,123,160q�6@   �� 5*   
   -	   5        $ password_textbox��5*      $��3��6,   $��1��69   $��80,30,60,170q�6I   �� 5+   
   $&�� серия/№ паспорта:��6   $��3��6,   $��1��69   $��15,60,120,130q�6I   �� 5,   
   -
   5        $ requisites_textbox��5,      $��3��6.   $��1��6;   $��130,63,30,135q�6K   �� 5-   
   $��E-mail:��6   $��3��6"   $��1��6/   $��15,90,100,100q�6?   �� 5.   
   -   5        $ email_textbox��5.      $��3��6)   $��1��66   $��80,95,60,105q�6F   �� 50   
   $��Объект:��6   $��3��6"   $��1��6/   $��20,127,180,60q�6?   �� 51   
   -   5        $ idObject_textbox��51      $��3��6,   $��1��69   $��80,135,60,70q�6I   �� 55   
   -   5        $��addclient_button��55      $��4��6)   ���#99CE86$��2��6L   ���#3C9755$��170,15,194,170q�6v   
 � 	Resources
 56       �� 
TargetType �� Property �� Value��%_   '��       �� 57      " ��6   .�58      ��  �@��CornerRadius$ 10��65   59      5:      .��5;      ��  �� Orientation$ 
Horizontal=�6   .+�5<      �� $��Center=�6   $��Center=�69   !Добавить клиента6f   �� 5=      $��\Resourses\addob(add).png��6   $��25��6;   $��32��6G   5>      5?      �� 5@   
   -   5        $��clear_button��5@      $��4��6%   ���#99CE86���#3C9755$��98,15,10,170q�6^   $��1��6�   
 5A      ��%_   '��       �� 5B      " ��6   .�5C      ��  �@��CornerRadius$ 10��65   5D      5E      .��5F      �� $ 
Horizontal=�6   .+�5G      �� $��Center=�6   $��Center=�69   Очистить поля6c   �� 5H      $ ��\Resourses\delete(add).png��6   $��24��6<   $��32��6H   5I      5J      5K      5L      