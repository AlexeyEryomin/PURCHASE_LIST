   M S B A M L   `   `   `  ����@  <Proba, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Proba.PropertiesProba.Properties  5   	       	Proba.Add   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4	viewmodelclr-namespace:Proba.Properties     5   	     � Title$  Shopping list��5   	   $	��821��6   $	��600��6,    � 
ResizeMode$ CanMinimize=�5	   
    � WindowStartupLocation$ Manual=�5
       � DataContext 5      $  Proba.Properties.MainViewModel  5   
   .��5      � ��5   
   �� 5       �� ImageSource$ /fnmj_1zC-BU.jpg��6    j� Stretch$ UniformToFill=�68    � RowDefinitions 5   
   �� 5      $	��740 �6   �� 5      .+�5   
   �� $��100,200,90,0q�6   
�������$��0��6>   .+�5      �� -   5         ��Name$ mainList��5      $	��395��6s   $	��517��6   ��6(   �� *
mainList+ �� SelectedItem 6I   �� *SelectedMainList+��5      �� 5      .R�5      �� .+�5      �� 	 �� Orientation$	 
Horizontal=�6)   $��	10 10 0 0q�6B   .+�5   "   �� $#��Название списка��6,   $��10 0 0 0q�6C   $��	Underline{�6V   $
��Bold"�6r   �� 5   "   $	��190��6F   ��6,   �� *
ListName+.��6R   
 �� TextDecorations
 5!   *   }�  }� Location$ 	Underline=�69   .��5"   ?   5#   #   5$      �� 5%      $ 	itemsList��6'   $��0 10 0 0q�6�   ��6:   �� *	itemsList+ 6\   �� *SelectedItem+��5&   "   �� 5'   &   .R�5(   *   �� .+�5)   .   �� $	 
Horizontal=�69   .+�5*   2   �� $��Center=�5+   1   $��5 0 10 0q�5,   1    d� 	IsChecked 5*   ;   �� *
IsSelected+5,   1   �� 5-   2   $	��280��6Z   ��6;   ��  �� Path$ ItemName�6Z   �� 5.   2   ��6:   �� ��6W   �� *DataContext.RemoveCommand+ �� ElementName$ 	itemsList��.��5/   6   �� $��/trash_949934.png��6<   $��20��6W   $��20��6b   50   3   51   /   52   +   53   '   55      �� 56      $	 
Horizontal=�6)   .+�57   "   �� $&�� Добавить  покупку��6*      Two#��[  6F   
��� � �$
��Bold"�6�   ��6d   �� ��6�   �� *DataContext.AddCommand+$ 	itemsList��6�   �� 58   "   $!��Удалить список��6)   #��[  6B   
���  ��$��	150 0 0 0q�6�   $
��Bold"�6�   ��6_   �� ��6�   �� *$"DataContext.RemoveItemsListCommand+$ mainList��6�   59      5:      5;      5=      5>      �� 5?   
   $��1��6   
�������$	 
Horizontal=�65   .+�5A      �� -   5          RoundButtonTemplate#��[ 5A      $��40��6V   $
��Left=�6b   $��
Назад��6}   $��10 0 0 0q�6�   $��20(�6�   �� 5B      $��Новый список��6   #��[ 6J   $��20 0 0 0q�6�   $��20(�6�   ��6,   �� ��6x   �� *!DataContext.AddItemsListCommand+$ mainList��6�   �� 5C      #��[ 6   $��Сохранить��6B   $��20(�6�   $��	20 0 0 0 q�6�   $��40��6�   ��6V   �� ��6s   �� * DataContext.SaveChangesCommand+$ mainList��6�   5D      5E      5F      