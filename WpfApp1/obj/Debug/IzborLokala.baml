   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:WpfApp1.modelWpfApp1.model  5   	       WpfApp1.IzborLokala   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -modelclr-namespace:WpfApp1.model     5   	     � 
ResizeMode$  NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5       � Title$ Lokali��5   	   $	��400��6   $	��450��6%    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ model:Komande.Save��5      6�     5   
   -   5        $ ApplicationCommands.Help��5      6<   ��5      �� 5   
    j� 
AlignmentX$ Center=�6    j� 
AlignmentY$ Center=�6)    �� ImageSource$ img/mitrovica3.jpg��6=    j� Stretch$ UniformToFill=�6^   .��5      � $	��400��6   $	��300��6   ��5   
   �� 5      	 �� Color$	 Black��6   
 �� Opacity$	
 0.8Q�6,    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5       $
��Auto �6   �� 5!      $
��Auto �6   �� 5"      $
��Auto �6   �� 5#      $
��Auto �6   �� 5$      $
��Auto �6   �� 5%      $
��Auto �6    � ColumnDefinitions 5)   
   �� 5*      $	��200 �6   �� 5+      $	��200 �6   .+�5-   
   �� -   5         ��Name$ buttonIzmeni��5-   �   $��Izmenite lokal��6   
�������$��Center=�6=   $	��Top=�6Z   $	��228��6r   $��30��6~   ���	#FF5B78F9$��4��6�   $��2��6�   $��0,20,0,0q�6  �� 5.   
   
�������$��20(�6#   $��Center=�61   $��1��6N   $��2��6[   $	��Top=�6o   .��6�   Lokali6�   �� 50   
   -   5        $ buttonDodaj��50   �   $��Dodajte lokal��6   
�������$��Center=�6=   $	��Top=�6[   $	��228��6s   $��30��6   $��3��6�   $��2��6�   $��0,20,0,0q�6�   ���	#FF30CB3E6
  �� 51   
   -   5         ��Name$ comboBox��51      $��2��6%   $��2��62   $	��228��6F   $��20(�6R   �� 52   
   -   5        
����������	#FFE42C2C$	��228��52   ;   $��30��6G   $��5��6S   $��Center=�6`   $��2��6{   $��0,20,0,0q�6�   .��6�   Uklonite lokal6�   �� 54   
   -   5        
�������$��2��54   %   $��2��62   $��30��6B   $��Right=�6N   $��0,0,10,0q�6j    � ToolTip$ Tabela lokala��6�   .��55      �� $��img/table(1).png��6   56      �� 58   
   -   5        $��2��58       J� Opacity$	 100Q�6"   $
��Left=�61   $��30��6M   $��30��6X   $��2��6d   $��50,0,0,0q�6x   $ Cuvanje(ctrl+s)��6�   .��59      �� $��img/save.png��6   5:      �� 5;   
   -	   5        $��2��5;      $��30��6   $��30��6*   $	 100Q�6C   $
��Left=�6Q   $��10,0,0,0q�6l   $ 
Ucitavanje��6~   .��5<      �� $��img/folder.png��6   5>      5@      5A      