   M S B A M L   `   `   `  ����E  APotionBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PotionBook.PagesPotionBook.Pages  5      !    PotionBook.Pages.PotionPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:PotionBook.Pages     5      -   5          N� Title$  
Зелья��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   � $��1��6      ColorSecondary#��[  6   �� 5   
   -   5        $��ListPotions��5      $��Disabled=�5      ��5      �� 5      .R�5      ��   ColorAccent#��[ 6   ._�5      �  � ColumnDefinitions 5      �� 5   "   $	��100 �63   �� 5   "   $��* �63   �� 5   "   $��70 �63   .+�5      ��   ProductImage#��[ 6$   ��5   "   �� 5   &    �� Path$ Image�6.    �� TargetNullValue 5   *   ��5    .   icon.png��6D   5"   '   5$      �� 5%   "   $��1��6-   .+�5&   "   ��   BlockDescription#��[ 6,   $
��auto��6V   ��5'   ,   �� *Name+�� 5(   "   #��[ 6,   ��5)   ,   �� *NameIngredientOne+�� 5*   "   #��[ 6,   $
��auto��6V   ��5+   ,   �� *NameIngredientTwo+�� 5,   "   #��[ 6,   $
��auto��6V   ��5-   ,   �� *NameIngredientThr+�� 5.   "   #��[ 6,   $
��auto��6V   ��5/   ,   �� *NameIngredientFour+�� 50   "    �� Orientation$ 
Horizontal=�6-   $��Center=�6F   .+�51   &   �� $��EditBtn��6-   -   5        $ ��Редактировать��51   R   6l   �� 52   &   $��	DeleteBtn��6-   -   5        $��Удалить��52   V   6j   53   #   54      55      56      57      59      �� 5:   
   -   5        $��BackBtn��5:   I   $
��Left=�6   $��1��6,   $��
Назад��69   6X   �� 5;   
   -   5        $��AddPotionBtn��5<   *   $��Right=�5;      $��1��6-   $!��Добавить зелье��5<      6>   �� 5=   
   -   5        $��LogOut��5=   K   $��Center=�6   $��1��6.   $��
Выйти��6;   6Y   5>      5?      