   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.EditEtiketa2   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  Izmena etikete��5      $	��320��6   $	��400��6+   ��5      �� 5	   
    j� 
AlignmentX$ Center=�6    j� 
AlignmentY$ Center=�6)    �� ImageSource$ img/mitrovica8.png��6=    j� Stretch$ UniformToFill=�6^    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      � $	��300��6   $	��200��6   ��5   
   �� 5       �� Color$ Black��6    �� Opacity$	 0.8Q�6,   .+�5   
   �� -   5        	 ��Name$	 buttonDodaj��5   �   $��Izmenite etiketu��6   $
��Left=�6,   $��198,170,0,0q�6G   $	��Top=�6\   $��92��6t   ���	#FF1754BD
�������6�   �� 5   
   
�������$��20(�6#   $��Center=�61   $��40��6N   $	��Top=�6Z   .��6r   Dodavanje etikete6�   �� 5   
   $	��ID:��6   $
��Left=�6   $��	40,61,0,0q�69   
�������$	��Top=�6_   �� 5   
   -   5        
 ��Name$
 idTxt��5   �   $
��Left=�6   $��23��6-   $��	64,64,0,0q�69    �� TextWrapping$
 Wrap=�6L   $	��Top=�6a   $	��120��6y   6�   �� 5   
   $
��Left=�6   $��	95,92,0,0q�6/   $
��Wrap=�6B   $	��Top=�6W   $	��120��6o   �� 5   
   $��Opis:��6   $
��Left=�6    $��
27,120,0,0q�6;   
�������$	��Top=�6b    J� RenderTransformOrigin$ -0.351,0.577&�6z   �� 5   
   -   5        $

 opis��5   �   $
��Left=�6   $��31��6-   $��
64,120,0,0q�69   $
 Wrap=�6M   $	��Top=�6b   $	��120��6z   6�   �� 5   
   -   5        $	 buttonPromena��5   �   $��Odaberite boju��6   $
��Left=�6*   $��
198,64,0,0q�6E   $	��Top=�6Y   $��92��6q   $��23��6|   
����������	#FF4E55616�   �� 5   
   $
��Left=�6   $��
66,156,0,0q�6/   $
��Wrap=�6C   $	��Top=�6X   $	��120��6p   5      5      