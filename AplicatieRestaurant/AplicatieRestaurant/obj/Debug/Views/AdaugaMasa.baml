   M S B A M L   `   `   `  ����N  JAplicatieRestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:AplicatieRestaurant.ViewModelsAplicatieRestaurant.ViewModels  5   	   E'clr-namespace:AplicatieRestaurant.ViewsAplicatieRestaurant.Views  5   	   *    $AplicatieRestaurant.Views.AdaugaMasa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <ctx,clr-namespace:AplicatieRestaurant.ViewModels     5   	   9local'clr-namespace:AplicatieRestaurant.Views     5   	     � Title$  
AdaugaMasa��5	   	   $	��500��6   $	��400��6)    � WindowStartupLocation$ CenterScreen=�65    � DataContext 5
      1  +AplicatieRestaurant.ViewModels.AdaugaMasaVM  5   
   .��5      � 
���`��� � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   �� 5      $��* �6   6)   .+�5   
   �� $��0��6   $��0��6   $��2��6-   $��Adauga masa��6A   $��Center=�6W   $��Center=�6{   $��40(�6�   
�������$
��Bold"�6�   6�   �� 5   
   $��1��6   $��0��6   $��Numar��6-   $��Center=�6=   $��Center=�6a   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5   
   -   5         ��Name$ NumarTxt��5      $��1��6Q   $��1��6^   $��20,40,20,40q�6n   $��Center=�6�   $��Center=�6�   ��6�   �� *Numar+6�   �� 5   
   $��2��6   $��0��6   $��Locuri��6-   $��Center=�6>   $��Center=�6b   $��20(�6�   
�������$
��Bold"�6�   6�   �� 5    
   -   5        $ 	LocuriTxt��5       $��2��6T   $��1��6a   $��20,40,20,40q�6q   $��Center=�6�   $��Center=�6�   ��6�   �� *NumarLocuri+6�   �� 5"   
   -   5         ��Name$ BackBtn��5"     $��0��6   $��4��6!   $��Inapoi��6.   $��50,40,50,40q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   65  �� 5#   
   $��1��6   $��4��6!   $��Adauga��6.   $��50,40,50,40q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��12(�6�   $
��Bold"�6�   ��6  �� *Adauga+6)  5$      5%      