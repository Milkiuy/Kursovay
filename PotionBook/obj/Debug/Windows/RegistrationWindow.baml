   M S B A M L   `   `   `  ����E  APotionBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PotionBook.WindowsPotionBook.Windows  5   	   +    %PotionBook.Windows.RegistrationWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:PotionBook.Windows     5   	     � Title$+  %Электронный учебник��5   	   $	��500��6%   $	��500��62    � WindowStartupLocation$ CenterScreen=�5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   � $��0��6      ColorSecondary#��[  6   �� 5   
     BlockHeader#��[ 6   ��69   ��  �� ElementName$ 	FrameMain�� �� Path$ Content.Title��� 5   
   $��/Resources/icon.png��6   $
��Left=�6-   6J    � 5   
   -   5        $��	FrameMain��5        � NavigationUIVisibility$ Hidden=�6!   $��1��6A   �� 5   
   -   5         ��Name$ BtnBack��5      $��2��6   $��
Назад��6/   6?   5      5      