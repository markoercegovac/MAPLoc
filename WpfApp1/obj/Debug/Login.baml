   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.Login   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5          � Icon$  img/rsz_grb.png��5	   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowState$ 	Maximized=�5   	    � 
ResizeMode$ NoResize=�5   	    � Title$ Prijavljivanje��5   	   $	��500��6    $	��720��6-   $	��720��69   $	��400��6H   $��Center=�6X   $��Center=�6u   ��5      �� 5   
    �� ImageSource$ img/slika8.jpg��6    j� 
AlignmentX$ Center=�62    j� 
AlignmentY$ Center=�6F    j� Stretch$ UniformToFill=�6Z   6t   .��5      � .+�5   
   �� $��Center=�6   $��Center=�62   $	��300��6M   $	��300��6Z   ��5      �� 5      	 �� Color$	 Black��6"   
 �� Opacity$	
 0.7Q�60   .+�5      �� $��Center=�6   $��20(�61   
�������$��MAPLoc��6R   $��109,0q�6c   �� 5      -   5         ��Name$ korisnickoimeTb��5   f   $��0,30,0,0q�6   $	��250��6(   $��30��64   $
��Bold"�6@   
������� � ToolTip$ Korisnicko ime��6   $��Arial)�6�   $��14(�6�    �� 
AcceptsTab . .��6�   ��5      �� 5      $	 White��6&   $	
 0.3Q�64   .��5   &   5       �� 5"      -   5        $ 	LozinkaTb��5"   l   $	��250��6   $��30��6#   $��Password)�6/   
�������$��0,20,0,2q�6Z   $ Lozinka��6   $��14(�6�   .��6�   ��5#      �� 5$      $	 White��6&   $	
 0.3Q�64   .��5%   &   5&      �� 5(      -   5         ��Name$ 	regButton��5(   �   $��25,20,199,0q�6   ���	#FF4680E6$��Registracija��6A   ��5)      �� 5*      $	 	#FF707070��6&   $
 0Q�68   ��5,      �� 5-      $	 	#FFDDDDDD��6&   $
 0Q�68   5/      �� 51      -   5        $ 	buttonPri��51   �   $��30��6   $	��250��6"   $��0,20,0,0q�6.   ���	#FF45D158
�������$��Prijava��6j   6�   �� 52      -   5         ��Name$ tbBlock��52      $��30��6)   $��0,20,0,0q�65   $	��250��6G   6V   54      �� 55   
   -   5        $��403,79,255,346q�55       J� RenderTransformOrigin$ 0.6,0.55&�6)   $��34��6W   $��33��6c   ��56      �� 57      $	 	#FF707070��6"   $
 0Q�64   ��59      �� 5:      $	 	#FFDDDDDD��6"   $
 0Q�64   .��5<      �� $��/img/prim1.png��6   $��34��6,   $��33��68   $ -0.788,0.233&�6C   5>      5?      5B      