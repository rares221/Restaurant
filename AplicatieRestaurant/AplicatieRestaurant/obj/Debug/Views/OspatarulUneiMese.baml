   M S B A M L   `   `   `  ����N  JAplicatieRestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:AplicatieRestaurant.ViewModelsAplicatieRestaurant.ViewModels  5   	   E'clr-namespace:AplicatieRestaurant.ViewsAplicatieRestaurant.Views  5   	   1    +AplicatieRestaurant.Views.OspatarulUneiMese   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <ctx,clr-namespace:AplicatieRestaurant.ViewModels     5   	   9local'clr-namespace:AplicatieRestaurant.Views     5   	     � Title$  OspatarulUneiMese��5	   	   $	��500��6#   $	��400��60    � WindowStartupLocation$ CenterScreen=�6<    � DataContext 5
      8  2AplicatieRestaurant.ViewModels.OspatarulUneiMeseVM  5   
   .��5      � 
���`��� � RowDefinitions 5   
   �� 5      $��2* �6   6*   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   $��0��6;   $��3��6K   $��Center=�6_   $��Center=�6|   .+�5      �� $��0��6   $��0��6!   $
��Masa��61   $��Right=�6@   $��Center=�6\   $��40(�6w   
�������$
��Bold"�6�   6�   �� 5      $��0��6   $��1��6!   $
��Left=�6K   $��Center=�6f   $��40(�6�   
�������$
��Bold"�6�   ��61   �� *Numar+6�   5      �� 5"   
   $��1��6   $��0��6   $��3��6-   $��Ospatar��6A   $��Center=�6S   $��Center=�6p   $��30(�6�   
�������$
��Bold"�6�   6�   �� 5$   
   $��2��6   $��0��6   $��Nume:��6-   $��Right=�6=   $��Center=�6Y   $��20(�6t   
�������$
��Bold"�6�   6�   �� 5%   
   $��2��6   $��1��6   $
��Left=�6F   $��Center=�6a   $��20(�6|   
�������$
��Bold"�6�   ��6-   �� *Nume+6�   �� 5&   
   $��3��6   $��0��6   $��Prenume:��6-   $��Right=�6@   $��Center=�6\   $��20(�6w   
�������$
��Bold"�6�   6�   �� 5'   
   $��3��6   $��1��6   $
��Left=�6I   $��Center=�6d   $��20(�6   
�������$
��Bold"�6�   ��6-   �� *	Prenume+6�   �� 5)   
   -   5         ��Name$ BackBtn��5)     $��0��6   $��4��6!   $��Inapoi��6.   $��10,25,10,25q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��15(�6�   $
��Bold"�6�   65  �� 5*   
   -   5        $ AddBtn��5*     $��1��6   $��4��6!   $��Adauga��6.   $��10,25,10,25q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��15(�6�   $
��Bold"�6�   {�61  �� *Adauga+6P  �� 5+   
   -   5        $ 	DeleteBtn��5+     $��2��6   $��4��6!   $��Sterge��6.   $��10,25,10,25q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��15(�6�   $
��Bold"�6�   {�6  �� *Sterge+��6<  �� *Muta+6W  5,      5-      