   M S B A M L   `   `   `  ����N  JAplicatieRestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:AplicatieRestaurant.ViewModelsAplicatieRestaurant.ViewModels  5   	   E'clr-namespace:AplicatieRestaurant.ViewsAplicatieRestaurant.Views  5   	   ,    &AplicatieRestaurant.Views.AdaugaProdus   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <ctx,clr-namespace:AplicatieRestaurant.ViewModels     5   	   9local'clr-namespace:AplicatieRestaurant.Views     5   	     � Title$  AdaugaProdus��5	   	   $	��500��6   $	��400��6+    � WindowStartupLocation$ CenterScreen=�67    � DataContext 5
      3  -AplicatieRestaurant.ViewModels.AdaugaProdusVM  5   
   .��5      � 
���`��� � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Adauga produs��6A   $��Center=�6Y   $��Center=�6}   $��40(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��0��6   $��Denumire��6-   $��Center=�6@   $��Center=�6d   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��1��6   $��20,30,20,30q�6/   $��Center=�6^   $��Center=�6�   ��6D   �� *
Denumire+6�   �� 5    
   $��2��6   $��0��6   $
��Pret��6-   $��Center=�6<   $��Center=�6`   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5!   
   -   5         ��Name$ PretTxt��5!      $��2��6P   $��1��6]   $��20,30,20,30q�6m   $��Center=�6�   $��Center=�6�   ��6�   �� *Pret+6�   �� 5"   
   $��3��6   $��0��6   $
��Stoc��6-   $��Center=�6<   $��Center=�6`   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5#   
   -   5        $ StocTxt��5#      $��3��6P   $��1��6]   $��20,30,20,30q�6m   $��Center=�6�   $��Center=�6�   ��6�   �� *Stoc+6�   �� 5%   
   -   5         ��Name$ BackBtn��5%     $��0��6   $��4��6!   $��Inapoi��6.   $��50,20,50,20q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   65  �� 5&   
   $��1��6   $��4��6!   $��Adauga��6.   $��50,20,50,20q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   ��6  �� *Adauga+6)  5'      5(      