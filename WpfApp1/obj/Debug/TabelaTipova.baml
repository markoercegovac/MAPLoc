   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.TabelaTipova   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	   -   5        $��winTable��5   8     � Title$  Tipovi lokala��6	   $	��363��6   $	��636��6,   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5       � ColumnDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrMain��5         
IsReadOnly .    AutoGenerateColumns .  $ �� IsSynchronizedWithCurrentItem$
 TrueY�6v   $��2��6�   ��6$   ��  �� Path$ Tipovi�   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Tipovi��6)   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToCells 69      CellTemplate 5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6)   .+�5   "   �� $��	IDTipa : ��6,   �� 5   "   ��6,   �� *Id+5      5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $		 Tip��6%   $
 SizeToCells 62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6F   �� *Naziv+6b     5      $
	 Opis��6%   $
 SizeToCells 63    6G   �� *Opis+6b     5      $	 Slika��6%   $
 SizeToCells 64    6H   �� *Image+6d    �� 
GroupStyle 5"      (  "System.Windows.Controls.GroupStyle  5#         HeaderTemplate 5$      �� 5%      .R�5&      �� $ 
Horizontal=�6)   .+�5'   "   �� $��Upisan: ��6,   6>   �� 5(   "   $
��Bold"�6B   ��6,   �� *Name+6B   5)      5*      5,      5.      50      51      