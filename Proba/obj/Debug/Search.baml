   M S B A M L   `   `   `  ����@  <Proba, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Proba.PropertiesProba.Properties  5          Proba.Search   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4	viewmodelclr-namespace:Proba.Properties     5      -   5          � Title$  Search��5   	   $	��821��6   $	��600��6%    � 
ResizeMode$ CanMinimize=�5	   
    � WindowStartupLocation$ Manual=�5
       � DataContext 5      $  Proba.Properties.MainViewModel  5   
   .��5      � ��5   
   �� 5       �� ImageSource$ /fnmj_1zC-BU.jpg��6    j� Stretch$ UniformToFill=�68    � RowDefinitions 5   
   �� 5      �� 5      $	��690 �6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   $��0��6.   
�������.+�5      �� $4��.Введите название списка: ��6   $��30��69   $��20(�6E   $
��Bold"�6S   �� 5      -   5         ��Name$ 	SearchBox��5      $��20(�6j   $��30��6x   ��6)   �� *
ListFilter+	 �� UpdateSourceTrigger$	 PropertyChanged=�6x   5      �� 5   
   $��100,84,100,33q�6   
�������$��1��6?   .+�5      �� -   5        
 ��Name$
 mainList��5      $	��395��6s   $	��517��6   ��6(   �� *
mainList+ �� SelectedItem 6I   �� *SelectedMainList+��5      �� 5      .R�5       �� .+�5!      �� $ 
Horizontal=�6)   $��	10 10 0 0q�6B   .+�5"   "   �� $#��Название списка��6,   $��10 0 0 0q�6C   $��	Underline{�6V   $
��Bold"�6r   �� 5#   "   $	��190��6F   ��6,   �� *
ListName+.��6R    �� TextDecorations 5%   *   }�  }� Location$ 	Underline=�69   .��5&   ?   5'   #   5(      �� 5)      $
 	itemsList��6'   $��0 10 0 0q�6�   ��6:   �� *	itemsList+ 6\   �� *SelectedItem+��5*   "   �� 5+   &   .R�5,   *   �� .+�5-   .   �� $ 
Horizontal=�69   .+�5.   2   �� $��Center=�5/      $��5 0 10 0q�50       d� 	IsChecked 5.   ;   �� *
IsSelected+50      �� 51   2   $	��280��6Y   ��6:   ��  �� Path$ ItemName�6Y   �� 52   2   ��6:   �� ��6W   �� *DataContext.RemoveCommand+ �� ElementName$ 	itemsList��.��53   2   �� $��/trash_949934.png��68   $��20��6S   $��20��6^   54   /   55   /   56   +   57   '   59      �� 5:      $ 
Horizontal=�6)   .+�5;   "   �� $&�� Добавить  покупку��6*      Two#��[  6F   
��� � �$
��Bold"�6�   ��6d   �� ��6�   �� *DataContext.AddCommand+$ 	itemsList��6�   �� 5<   "   $!��Удалить список��6)   #��[  6B   
���  ��$��	150 0 0 0q�6�   $
��Bold"�6�   ��6_   �� ��6�   �� *$"DataContext.RemoveItemsListCommand+$ mainList��6�   5=      5>      5?      5A      �� 5B      $ 
Horizontal=�6   .+�5C      ��   RoundButtonTemplate#��[ 6   $��Сохранить��6F   $��	 0 10 0 0q�6y   $��20(�6�   $	��120��6�   $��40��6�   ��6Z   �� ��6�   �� * DataContext.SaveChangesCommand+$ mainList��6�   �� 5D      -   5        #��[ 5D      $	��100��6F   $��40��6e   $�� 160 10 0 0q�6s   $��Right=�6�   $��Stretch=�6�   $��
Назад��6�   $��20(�6�   5E      5F      5G      5H      