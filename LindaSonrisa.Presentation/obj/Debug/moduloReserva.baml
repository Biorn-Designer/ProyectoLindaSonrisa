   M S B A M L   `   `   `  ����T  PLindaSonrisa.Presentation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LindaSonrisa.PresentationLindaSonrisa.Presentation  5   	   -    'LindaSonrisa.Presentation.moduloReserva   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:LindaSonrisa.Presentation     5   	     � Title$  moduloReserva��5      $	��650��6   $	��850��6+    � WindowStyle$
 None=�67    � WindowStartupLocation$ CenterScreen=�6J   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��873* �6   �� 5      $��0* �6   �� 5      $	��19* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgdDataGrid��5      $
��Left=�6(   $	��460��6C   $��
425,29,0,0q�6P   $	��Top=�6d   $	��375��6|   �� 5   
   $��ID RESERVA:��6   $
��Left=�6&   $	��Top=�6A   $��	98,70,0,0q�6Y   $��26��6l   $��71��6x   �� 5   
   $��ID CLIENTE:��6   $
��Left=�6&   $	��Top=�6A   $��
98,109,0,0q�6Y   $��26��6m   $��81��6y   �� 5   
   $��ID SERVICIO:��6   $
��Left=�6'   $	��Top=�6B   $��
91,154,0,0q�6Z   $��26��6n   $��86��6z   �� 5   
   $��FECHA RESERVA:��6   $
��Left=�6)   $	��Top=�6D   $��
93,215,0,0q�6\   $��26��6p   $��99��6|   �� 5   
   $��
ID MODULO:��6   $
��Left=�6%   $	��Top=�6@   $��
93,260,0,0q�6X   $��26��6l   $��81��6x   �� 5   
   $��ESTADO:��6   $
��Left=�6"   $	��Top=�6=   $��
91,304,0,0q�6U   $��26��6i   $��70��6u    J� RenderTransformOrigin$ 0.543,2.173&�6�   �� 5   
   $
��Left=�6   $��23��6-    �� TextWrapping$
 Wrap=�69   $�� ��6M   $	��Top=�6U   $	��120��6m   $��229,304,0,0q�6y   �� 5#   
   $
��Left=�6   $	��Top=�6.   $	��120��6F   $��
229,71,0,0q�6R   �� 5$   
   $
��Left=�6   $	��Top=�6.   $	��120��6F   $��229,101,0,0q�6R   �� 5%   
   -   5         ��Name$ cboServicio��5%      $
��Left=�6(   $	��Top=�6C   $	��120��6[   $��229,146,0,0q�6g   �� 5&   
   $
��Left=�6   $	��Top=�6.   $	��120��6F   $��229,260,0,0q�6R   (  "System.Windows.Controls.DatePicker  5*   
   -   5          Name$ dtpFechaNacimientoCliente��5*      $
��Left=�68   $	��Top=�6S   $��229,215,0,0q�6k   $��24��6�   $	��120��6�   �� 5.   
   -   5        	 ��Name$	 btnLimpiarCliente��5.      $��Limpiar��6,   $
��Left=�6>   $	��Top=�6Y   $��86��6q   $��
88,428,0,0q�6|   $��36��6�   �� 5/   
   -   5        $	 btnEliminarCliente��5/      $��Eliminar��6-   $
��Left=�6@   $	��Top=�6[   $��93��6s   $��202,428,0,0q�6~   $��36��6�   �� 50   
   -   5        $	 btnModificarCliente��50      $��	Modificar��6.   $
��Left=�6B   $	��Top=�6]   $��94��6u   $��202,371,0,0q�6�   $��36��6�   �� 51   
   -   5        $	 btnAgregarCliente��51      $��Agregar��6,   $
��Left=�6>   $	��Top=�6Y   $��86��6q   $��
88,373,0,0q�6|   $��34��6�   �� 52   
   -   5        $	 	btnVolver��52      $��Volver��6$   $
��Left=�65   $	��Top=�6P   $��84��6h   $��716,516,0,0q�6s   $ 0.507,0.475&�6�   $��35��6�   6�   57      58      