   M S B A M L   `   `   `  ����B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.CrearUsuario   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     � Title$  Creación de usuarios��5   	   $	��350��6&   $	��600��63   .��5	      � $��20q�6   .+�5
   
   �� $��Creación de usuarios��6   $
��Bold"�60   $��20(�6B   $
��Left=�6P   $��0,0,0,20q�6k   � 5   
   $��0,40,0,0q�6    � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $	��250 �6#   �� 5      $
��Auto �6#    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Nombre:��6   $��Center=�6'   $��0��6B   $��0��6O   �� 5      $��
Apellidos:��6   $��Center=�6*   $��1��6E   $��0��6R   �� 5      $��
Direccion:��6   $��Center=�6*   $��2��6E   $��0��6R   �� 5      $��Nacionalidad:��6   $��Center=�6-   $��3��6H   $��0��6U   �� 5      $��Email:��6   $��Center=�6&   $��4��6A   $��0��6N   �� 5       -   5         ��Name$ 	txtNombre��5       $��0��6)   $��1��66   $��10,0,0,0q�6F   �� 5!      -   5        $ txtApellidos��5!      $��1��6,   $��1��69   $��10,5,0,5q�6I   �� 5"      -   5        $ txtDireccion��5"      $��2��6,   $��1��69   $��10,5,0,5q�6I   �� 5#      -   5        $ txtNacionalidad��5#      $��3��6/   $��1��6<   $��10,5,0,5q�6L   �� 5$      -   5        $ txtEmail��5$      $��4��6(   $��1��65   $��10,5,0,5q�6E   �� 5'      $��0��6   $��5��6&   $��2��67   $��Right=�6G   $	��Top=�6c   $��20,0,0,0q�6{   .+�5(      �� 
�������$��1q�6,   $	��100��6@   $	��100��6L   ._�5)      �� $��Imagenes/hoy.png��6   $
��Fill=�66   5*      �� 5+      -   5         ��Name$ 	bntcambio��5+      $��Cambiar imagen��6,   $	��150��6E   $��0,10,0,5q�6Q   �� 5,      -   5        $ 	bntCrearU��5,      $��Crear usuario��6,   $	��150��6D   $��0,5,0,5q�6P   6a   �� 5-      -   5        $ bntRegresar��5-      $��Regresar��6.   $	��150��6A   $��0,5,0,5q�6M   6^   5.      5/      50      51      