   M S B A M L   `   `   `  ����J  FWpfApp1-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1_ProjectWpfApp1_Project  5      "    WpfApp1_Project.UpdateSalary   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApp1_Project     5        N� 
Background
  ����� N� Title$ UpdateSalary��5
      .��5      � ��5   
   �� 5       �� ImageSource$ G:\doan\coin.jpg��6   .+�5   
   (�  (� Stretch$ Uniform=�6   .��5      � $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��Nhập Mã Nhân Viên: ��6   $
��Bold"�67   $��0,0,0,0q�6I   �� 5      -   5         ��Name$ txtSearchMaNv��5      $��0��61   $��	120,0,0,0q�6>   $	��200��6Q   �� 5!      -   5        $��Tìm Kiếm��5!      $	��100��6,   
�������
����p��$��Right=�6}   �� 5"      $��Nhập Lương  : ��6   $
��Bold"�62   $��0,10,0,0q�6D   $��1��6V   �� 5#      -   5        $ txtUpdateSalary��5#      $��1��63   $��
120,10,0,0q�6@   $	��200��6T   �� 5$      -   5        $��Cập nhật��5$      $	��100��6,   
�������
����p��$��Right=�6�   $��1��6�   $��
325,10,0,0q�6�   �� 5&      -   5         ��Name$ listViewSearchResults��5&      $��3��6:   $
��0,10q�6G   
������� �� View 5'      �� 5(      ! �� ColumnHeaderContainerStyle 5)      �� 5*   "   	 �� 
TargetType"	 ��6(   .�5+   &   �� 
 �� Property
 � �� �� Value$ Center=�6S   5,   #   .P�5.      �� $��Mã NV��6-    �� DisplayMemberBinding 6<   �� *MaNv+�� 5/      $
��Tên��6-    6:   �� *Name+�� 50      $��	Năm Sinh��6-    6?   �� *Age+�� 51      $��
Phòng Ban��6-    6@   �� *
Department+�� 52      $��Chức Vụ��6-    6>   �� *
Position+�� 53      $��Năm Làm Việc��6-    6C   �� *year+�� 54      $��Lương��6-    6<   �� *Salary+�� 55      $��Công��6-    6;   �� *Cong+�� 57      $��	Thưởng��6-    6=   �� *BonusSalary+�� 58      $ ��Số Lượng Sản Phẩm��6-    6H   �� *	product+�� 59      $��Tổng Lương��6-    6A   �� *TotalSalary+�� 5;      $��Thành Phố��6-    6@   �� *City+5<      5>      �� 5A      -   5        $��4��5A      $��
Quay lại��6@   $	��130��6S   
����+��$��5q�6w   
�������6�   5B      5C      5D      5E      