   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	   -clr-namespace:WpfApp1.modelWpfApp1.model  5   	       WpfApp1.Etiketa   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -modelclr-namespace:WpfApp1.model     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ Dodavanje etikete��5
   	   $	��320��6#   $	��400��60   ��5      �� 5   
    j� 
AlignmentX$ Center=�6    j� 
AlignmentY$ Center=�6)    �� ImageSource$ img/mitrovica8.png��6=    j� Stretch$ UniformToFill=�6^    � DataContext 5         WpfApp1.model.Etikete  5   
   6    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      � $��Center=�6   $��Center=�6&   ��5   
   �� 5      	 �� Color$	 Black��6   
 �� Opacity$	
 0.8Q�6,    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6    � ColumnDefinitions 5&   
   �� 5(      $	��100 �6   �� 5)      $	��100 �6   �� 5*      $	��100 �6   6-   .+�54   
   �� -   5         ��Name$ buttonDodaj��54   H   $��Dodajte etiketu��6   $��1��6+   $��6��6;   6]   �� 55   
   
�������$��20(�6#   $��0��61   $��2��6A   $��0��6U   .��6b   Dodavanje etikete6u   �� 56   
   $	��ID:��6   
�������$��0��61   $��1��6A   �� 57   
   -   5         ��Name$ idTxt��57      $��1��6!   $��1��6.   .��6>   ��58      �� 59       �� Path$ Id�6    �� ValidatesOnDataErrors .  �� UpdateSourceTrigger$ PropertyChanged=�6A    �� ValidationRules 5:         WpfApp1.model.Empty  5;         minimumimena$ 2��6&   6:   5>      .��5@       =� ErrorTemplate 5A      �� 5B      .R�5C      �  5D      �� 5E      $��20 �6,   �� 5F      $��20 �6,    5H      �� 5I      �� 5J      $
��Auto �6/   .+�5M      �� $��0��64   $��1��6D   6T   �� 5N      $��1��6$   $��2��64   
���  ����6A   �� *[0].ErrorContent+6v   5O      5P      .��5S   (   5U      �� 5V   
    J� Opacity$ 0Q�6   $��5��6   $��20��6*   69   �� 5W   
   
���  ��$��3��6%   $��1��62   �� 5X   
   -   5         ��Name$ txtOpis��5X   Q   $��Opis:��6   
�������$��0��64   $��4��6D   6Q   �� 5Y   
   -   5        $ optxt��5Y   /   $��4��6   $��1��6   6/   �� 5Z   
   -   5        $��Odaberite boju��5Z      $��0��6@   $��2��6P   5]      5^      