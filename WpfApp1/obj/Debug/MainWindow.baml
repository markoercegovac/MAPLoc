   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � WindowState$  	Maximized=�5      ���	#FF3A3A3A � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ MAPLoc��5   	    � 
ResizeMode$ CanMinimize=�6   $��Center=�61   $��Center=�6O    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Help��5      6<   .��5      ]� .+�5   
   o� $	��Top=�6   $��20��6$   ���	#FF232425 J� OpacityMask 5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 Black��6#   
 � Offset$
 1Q�61   � 5      #	 � ��6#   5      .@�5      m� $��_File��6   ���	#FF3A3A3A
�������.@�5      m� -   5        $��_Close��5      
�������
���   �6L   5      5       �� 5"   
   -   5         ��Name$	 pan��5"   /   $
��Auto��6   $	��200��6#   ��5#      �� 5$       j� 
AlignmentX$ Center=�6    j� 
AlignmentY$ Center=�62    j� Stretch$ UniformToFill=�6F   6`   .+�5'      �� .+�5)      �� -   5        $ panel��5)   ;   $
��auto��6!   $	��140��6.   ��5*      �� 5+      $ 0.5,1&�62   $ 0.5,0&�6C    � SpreadMethod$ Reflect=�6V   .��5,   "   � $	 Black��6/   $
 1Q�6=   � 5-   "   $	 Black��6/   5.       50      �� 51       �� Color$ Black��6.    �� Opacity$ 1Q�6<   .+�53      �� -   5        $
��Auto��53      $
��Auto��6+    ^� InitialShowDelay$
 2000��68    ^� ShowDuration$ 30000��6_   $��0,0,0,0q�6�   $	��Top=�6�   $
��Left=�6�   ���	#FF464646 � ToolTip 54      �� 55       �� Orientation$ 
Horizontal=�6)   .+�56   "   �� $��5q�6(   $��img/Screenshot_3.png��63   6S   �� 57   "   $��5q�6,   $
��Wrap=�67   $	��100��6K   ��Klikom na ovo dugme otvara se ovaj meni za izbor rada nad lokalom. Dugme dodavanje lokala pokrece novi prozor u kome dodajete lokal i omogucen Vam je help pritiskom na F1. Za izmenu i brisanje prvo morate selektovati id lokala koji zelite da izmenite ili izbrisete pa zatim izvrziti izmenu ili brisanje. Moguca je funkcionalnost save i load klikom na ikonicu save ili load koje se sa leve strane od comboBoxa lokala.5=   #   5>      .��5A      �� $��img/LocalInsider-hero.png��6    6F   5B      5C      5F      �� 5G      -   5         ��Name$ skroler��5G   �   $��Center=�6   $ Lista lokala��6@   $
��Auto=�6W   ��.  �� PanningMode$ HorizontalOnly=�6�    J� SnapsToDevicePixels .  � DataContext 6�   �� .��5H      �� -   5         ��Name$ panelcic��5H      $	��200��6.   ��6<   �� *Slike+��5I      �� 5K      .R�5L      � .+�5M   "   �� $
��Bold"�6C   ��6,   �� *Naziv+6C   �� 5N   "   $��50��6-   $��50��69   .+�5O   &   �� ��6,   �� *Image2+6H   5P   #   5Q      5R      5V      5X      5^      �� 5a      -	   5         ��Name$ 
mapaLokala��5a   �   $
��auto��6   $
��auto��6#    J� 	AllowDrop . }�. $��Stretch=�6�   $��Stretch=�6�   ��5b      �� 5c       �� ImageSource$ img/mapa4.png��6!   $ Center=�6=   $ Center=�6Q   $ UniformToFill=�6e   6�   5i      5n      5t      