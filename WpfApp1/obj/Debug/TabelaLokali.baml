   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.TabelaLokali   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5        $��winTable��5   8     � Title$  TableExample��6
   $	��200��6   $	��636��6,   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   �� 5      $	��100 �6   .+�5   
   �� .��6   Filter po nazivu6"   �� 5   
   -   5         ��Name$ 	txtFilter��5   S   $��1��6   $��14(�6E   6h   �� 5   
   $��2��6   .��6    Pretraga po id60   �� 5   
   -   5        $ txtPretraga��5   T   $��3��6   $��14(�6F   6k   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgrMain��5      $��0��6$   $��9��64   $��1��6H      
IsReadOnly .    AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6�   $��2��6�   ��6U   ��  �� Path$ Lokali�	   Columns	 5      4  .System.Windows.Controls.DataGridTemplateColumn  5       ,  &System.Windows.Controls.DataGridColumn
   Header$
 Indeks��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToCells 69      CellTemplate 5!      �� 5"      .R�5#      ��  �� Orientation$ 
Horizontal=�6)   .+�5$   "   �� $��ID : ��6,   �� 5%   "   ��6,   �� *Id+5&      5'      5)      0  *System.Windows.Controls.DataGridTextColumn  5*      $
 Naziv��6%   $ SizeToCells 64   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6H   �� *Naziv+6f     5+      $

 Opis��6%   $ SizeToCells 63    6G   �� *Opis+6b     5,      $	
 Tip��6%   $ SizeToCells 62    6F   �� *Tip+6`     5-      $
 Etikete��6%   $ SizeToCells 66    6J   �� *	Etikete+6h     5.      $
 Dostupan za hendikepirane��6%   $ SizeToCells 6H    6\   �� *Hendikepirani+6�     5/      $
 Dozvoljeno pusenje��6%   $ SizeToCells 6A    6U   �� *	Pusenje+6s     50      $
 Kategorije cena��6%   $ SizeToCells 6>    6R   �� *
Kategorije+6s     51      $
 Sluzenje alkohola��6%   $ SizeToCells 6@    6T   �� *	Alkohol+6r     52      $
 Datum otvaranja��6%   $ SizeToCells 6>    6R   �� *Datum+6n   57      59      5:      