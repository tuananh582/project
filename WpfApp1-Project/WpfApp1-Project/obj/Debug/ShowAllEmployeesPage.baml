   M S B A M L   `   `   `  ����J  FWpfApp1-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1_ProjectWpfApp1_Project  5      *    $WpfApp1_Project.ShowAllEmployeesPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApp1_Project     5        N� Title$  ShowAllEmployeesPage��5	       � 	Resources 5         CenteredHeaderStyle �� 
TargetType �� Property �� Value  ListViewItemStyle��%A  &	        &	 L     �� 5   
   " ��6,   .�5      ��  � ��$ Center=�6;   5      �� 5   
   " ��6*   .�5      ��  � ��
 �����6+   �� 5       � ��
 �����6,   �� 5       � ��$ 0 0 0 1q�60   �� 5       � ��$	 0 1q�6'   �� 5       � ��$ 5q�6(   5      5      .��5      (� .��5   
   � $	��800��6   $	��450��6    � RowDefinitions 5      �� 5      $��* �6    �� 5      $
��Auto �6    .+�5#      �� -   5         ��Name$ listViewEmployees��5#      $��10q�62   
�������
�������$��1q�6m    �� View 5$      �� 5%      ! �� ColumnHeaderContainerStyle 5&      �� 5(      	 �� BasedOn#	 [  6$   " ��5)   $   .P�5,      �� $��Mã NV��6)   
 �� DisplayMemberBinding
 68   �� *MaNv+�� 5-      $
��Tên��6)   
 66   �� *Name+�� 5.      $��	Năm Sinh��6)   
 6;   �� *Age+�� 5/      $��
Phòng Ban��6)   
 6<   �� *
Department+�� 50      $��Chức Vụ��6)   
 6:   �� *
Position+�� 51      $��Số Năm Làm Việc��6)   
 6B   �� *year+�� 52      $��Lương��6)   
 68   �� *Salary+�� 53      $��Công��6)   
 67   �� *Cong+�� 54      $.��(Số Lượng Sản Phẩm Làm Được��6)   
 6M   �� *	product+�� 55      $��	Thưởng��6)   
 69   �� *BonusSalary+�� 56      $��Tổng Lương��6)   
 6=   �� *TotalSalary+�� 57      $��Thành Phố��6)   
 6<   �� *City+58      ��5;      �� 5<      #	 [ 6   " ��6I   5>      �� 5A      $��1��6    �� Orientation$ 
Horizontal=�6&   $��Center=�6?   $
��0,10q�6\   .+�5B      �� -   5        $
��Xóa��5B      $	��100��6D   $��5q�6P   �� 5C      -   5        $��
Quay Lại��5C      $	��150��6K   $��5q�6W   �� 5D      -   5        $��In��5D      $	��150��6@   $��5q�6L   5F      5G      5H      5I      