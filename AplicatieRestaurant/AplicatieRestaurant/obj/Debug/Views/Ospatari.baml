   M S B A M L   `   `   `  ����N  JAplicatieRestaurant, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:AplicatieRestaurant.ViewModelsAplicatieRestaurant.ViewModels  5   	   E'clr-namespace:AplicatieRestaurant.ViewsAplicatieRestaurant.Views  5   	   (    "AplicatieRestaurant.Views.Ospatari   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <ctx,clr-namespace:AplicatieRestaurant.ViewModels     5   	   9local'clr-namespace:AplicatieRestaurant.Views     5   	     � Title$  Ospatari��5	   	   $	��500��6   $	��400��6'    � WindowStartupLocation$ CenterScreen=�63    � DataContext 5
      /  )AplicatieRestaurant.ViewModels.OspatariVM  5   
   .��5      � 
���`��� � RowDefinitions 5   
   �� 5      $��* �6   6)   �� 5      $��3* �6   6*   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   �� 5      $��* �6   6+   .+�5   
   �� $��0��6   $��0��6   $��4��6-   $��Ospatari��6A   $��Center=�6T   $	��Top=�6q   $��40(�6�   
�������$
��Bold"�6�   6�   &   System.Windows.Controls.DataGrid  5   
   $��1��6d   $��0��6r   $��4��6�   $��20,20,20,20q�6�   ��6   �� *Utilizatori+ �� SelectedItem 67   �� *UtilizatorSelectat+6�   �� 5   
   -   5         ��Name$ BackBtn��5     $��0��6   $��2��6!   $��Inapoi��6.   $��10,25,10,25q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��15(�6�   $
��Bold"�6�   65  �� 5   
   -   5        $ AddBtn��5     $��1��6   $��2��6!   $��Adauga��6.   $��10,25,10,25q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��15(�6�   $
��Bold"�6�   64  �� 5   
   -   5        $ 	UpdateBtn��5     $��2��6   $��2��6!   $��Modifica��6.   $��10,25,10,25q�6A   
�������
�������$��Center=�6�   $��Center=�6�   
�������$��2q�6�   $��15(�6�   $
��Bold"�6�   {�6!  �� *Sterge+6X  �� 5   
   -   5        $ 	DeleteBtn��5     $��3��6   $��2��6!   $��Sterge��6.   $��10,25,10,25q�6?   
�������
�������$��Center=�6~   $��Center=�6�   
�������$��2q�6�   $��15(�6�   $
��Bold"�6�   {�6  �� *Sterge+��6<  �� *StergereUtilizator+6e  5       5!      