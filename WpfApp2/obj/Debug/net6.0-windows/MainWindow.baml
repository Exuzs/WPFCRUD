   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��912��6)   ���#F5F5F5.��5      �  J� RenderTransformOrigin$ 0.5,0.5&�6   $��0,0,-2,0q�6+   z�5	   
   V� 5
      .~�5      �� �� 5      �� 5       �� Angle$ 0.058Q�6"   T� 5      5       � RowDefinitions 5   
   �� 5      $��70 �6   �� 5      $��30 �6   �� 5      $��25 �6   �� 5      $��20 �6   �� 5      $
��100* �6   �� 5      $
��100* �6   �� 5      $	��51* �6   �� 5      $	��49* �6   �� 5      $��20 �6    � ColumnDefinitions 5   
   �� 5      $
��2.75 �6   �� 5      $��16 �6   �� 5      $��26.009 �6   �� 5       $��28 �6   �� 5!      $��97.241 �6   �� 5"      $	��58* �6   �� 5#      $
��217* �6   �� 5$      $
��254* �6   �� 5%      $	��205 �6   �� 5&      $��3 �6   �� 5'      $��7 �6   .+�5)   
   �� $��2��5*      $��5��5+      $��MANTENIMIENTO USUARIO��5,      ���#333333$��30(�5.      $��Center=�5/      $
��Left=�50      $��10,0,0,0q�51      $��40��6   $	��372��6+   �� 52   
   $��Buscar Usuario��6   $
��Left=�53      $��6��54      $��2��55      $��16(�56      ���#666666$	��106��57   )   $��25,0,0,0q�65   �� 58   
   -   5         ��Name$ TxBuscar��58      
������ ���#CCCCCC$��7��5;      $��2��5<      $��Center=�5=      $��20 0 0 0q�5>      ���#6666665@      �� 5A   
   -   5         ��Name$ BtnCrearUsurio��5H      $��8��5A      $��2��5B      
������ ���#333333 � Cursor$
 Hand��5E      ���#333333$	��100��5G      $��Center=�5I      $��1q�5J      $��Crear USUARIO��5K      $��25��5L   /   $��Center=�6;   &   System.Windows.Controls.DataGrid  5M   
   -   5          Name$ 	GridDatos��5P      $��4��5M      $��2��5N      $��3��5O      	   AutoGenerateColumns$	 False��5Q      ���#FFFFFF���#333333$��15(�5T      
   CanUserAddRows$
 False��5U         CanUserResizeColumns$ False��5V         CanUserSortColumns$ False��5W         RowBackground
 ����    HeadersVisibility$ Column=�5Y         VerticalGridLinesBrush �#333333$��7��5Z   4   $��0,0,8,12q�6H      Columns 5[      0  *System.Windows.Controls.DataGridTextColumn  5\      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 1* 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+6H     5]      $ Nombre��6%   $ 3* 6P    65   �� *Nombre+6P     5^      $ 	Apellidos��6%   $ 3* 6V    68   �� *	Apellidos+6V     5_      $ 
Dirección��6%   $ 2* 6V    68   �� *	Direccion+6V     5`      $ Nacionalidad��6%   $ 2* 6\    6;   �� *Nacionalidad+6\     5a      $ Email��6%   $ 3* 6N    64   �� *Email+6N   4  .System.Windows.Controls.DataGridTemplateColumn  5b      $ Acciones��6)   $ 4* 6;      CellTemplate 5d      �� 5e      .R�5f      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   .+�5g   "   �� -   5        $��
Actualizar��5g   )   $��80��6>   $��5q�6I   6T   �� 5h   "   -   5        $��Eliminar��5h   )   $��80��6<   $��5q�6G   6R   5i      5j      5l      5n       � 5o   
   -   5          �Name$ USUARIOS��5o      $��0��5p      $��0��5q      $��9��5r      $��11��5s      $��	-3,7,-4,2q�6D   5t      5u      