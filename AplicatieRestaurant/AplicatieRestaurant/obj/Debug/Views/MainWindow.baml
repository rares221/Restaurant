   M S B A M L   `   `   `  ����N  JAplicatieRestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:AplicatieRestaurantAplicatieRestaurant  5   	   $    AplicatieRestaurant.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:AplicatieRestaurant     5   	     � Title$  
MainWindow��5   	   $	��400��6   $	��500��6)    � WindowStartupLocation$ CenterScreen=�65   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��1.5* �6   6,   �� 5      $	��.5* �6   6+   �� 5      $	��.5* �6   6+   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��4��6   $��0��6.   $��2��6>   $��../Images/restaurant.png��6R   $
��Fill=�6t   6�   �� 5   
   $��0��6   $��0��6   $��2��6-   $��	TRATTORIA��6A   $��Center=�6U   $��Center=�6w   $��50(�6�   
�������6�   �� 5   
   $��1��6   $��0��6   $��Nume utilizator��6-   $��Right=�6G   $��Center=�6c   $��25(�6~   
�������$
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ UsernameTxt��5      $��1��6'   $��1��64   $��20,15,70,15q�6D   6\   �� 5   
   $��2��6   $��0��6   $��Parola��6-   $��Right=�6>   $��Center=�6Z   $��25(�6u   
�������$
��Bold"�6�   6�   G� 5   
   -   5         G�Name$ PasswordTxt��5      $��2��6+   $��3��68   $��20,15,70,15q�6H   6`   �� 5   
   -   5         ��Name$ LoginBtn��5   �   $��0��6   $��3��6!   $��2��6.   $��Autentificare��6B   $��Center=�6Z   $��Center=�6~   
�������$��175,30,175,30q�6�   
�������$��2q�6  
�������$��15(�63  $
��Bold"�6A  6U  5      5      