   M S B A M L   `   `   `  ����N  JAplicatieRestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:AplicatieRestaurant.ViewModelsAplicatieRestaurant.ViewModels  5   	   E'clr-namespace:AplicatieRestaurant.ViewsAplicatieRestaurant.Views  5   	   /    )AplicatieRestaurant.Views.ModificaOspatar   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <ctx,clr-namespace:AplicatieRestaurant.ViewModels     5   	   9local'clr-namespace:AplicatieRestaurant.Views     5   	     � Title$  ModificaOspatar��5	   	   $	��500��6!   $	��400��6.    � WindowStartupLocation$ CenterScreen=�6:    � DataContext 5
      4  .AplicatieRestaurant.ViewModels.AdaugaOspatarVM  5   
   .��5      � 
���`��� � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Modifica ospatar��6A   $��Center=�6\   $��Center=�6�   $��40(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��0��6   $
��Nume��6-   $��Center=�6<   $��Center=�6`   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5    
   $��1��6   $��1��6   $��20,25,20,25q�6/   $��Center=�6Z   $��Center=�6|   ��6D   �� *Nume+6�   �� 5!   
   $��2��6   $��0��6   $��Prenume��6-   $��Center=�6?   $��Center=�6c   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5"   
   $��2��6   $��1��6   $��20,25,20,25q�6/   $��Center=�6]   $��Center=�6   ��6D   �� *	Prenume+6�   �� 5#   
   $��3��6   $��0��6   $��Nume de utilizator��6-   $��Center=�6J   $��Center=�6n   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5$   
   $��3��6   $��1��6   $��20,25,20,25q�6/   $��Center=�6d   $��Center=�6�   ��6D   �� *NumeUtilizator+6�   �� 5%   
   $��4��6   $��0��6   $��Parola��6-   $��Center=�6>   $��Center=�6b   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5&   
   $��4��6   $��1��6   $��20,25,20,25q�6/   $��Center=�6\   $��Center=�6~   ��6D   �� *Parola+6�   �� 5(   
   -   5         ��Name$ BackBtn��5(     $��0��6   $��5��6!   $��Inapoi��6.   $��50,20,50,20q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   65  �� 5)   
   $��1��6   $��5��6!   $��Modifica��6.   $��50,20,50,20q�6A   
�������
�������$��Center=�6�   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   ��6  �� *
Modifica+6-  5*      5+      