   M S B A M L   `   `   `  ����=  9GH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:GHGH  5          GH.Report_admin_   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      "localclr-namespace:GH     5      -   5          N� Title$  Report_admin_��5	       N� 
Background �#D9D9D9.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��10 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $	��350 �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      .+�5   
   � $��0��6   $��4��6   ���#50CE3B J� Opacity$
 0.10Q�6E   �� 5   
   $��Отчеты��6   $��3��6!   $��35(�65   ���#3C9755$��10,0,0,0q�6X   $��0��6j   �� 5   
   $��\Resourses\nameuser.png��6   $��0��61   $��
90,18,4,18q�6>   $��1��6R   �� 5   
   -   5         ��Name$ nameuser��5      $��0��6"   $��290,18,10,18q�6/   $��4��6E   $%��Шакирова Эвелина��6Y   $��18(�6t   �� 5   
   $(��"Отчеты о сделках с:��6   $��2��6.   $��2��6B   $��14(�6O   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ StartDatePicker��5      $��2��6.   $��1��6;   $��5q�6K   6V   �� 5    
   $��по:��6   $��2��6   $��2��6.   $��14(�6;     5!   
   -   5        $ EndDatePicker��5!      $��2��6,   $��2��69   $��	35,5,70,5q�6M   $��2��6�   �� 5"   
   -   5         ��Name$ Realtor_combobox��5"      $��3��6-   $��2��6:   $��5q�6N    �� SelectedIndex$ 0��6Y   .@�5#      �� .��5$      �� $.��(Вывод всех диапозонов��6   5%      5&      �� 5(   
   -   5        	 ��Name$	 ContractListBox��5(      $��4��6+   $��4��68   $��Stretch=�6L   5)      5*      