   M S B A M L   `   `   `  ����J  FWpfApp1-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1_ProjectWpfApp1_Project  5           WpfApp1_Project.SearchName   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApp1_Project     5        N� 
Background
  ����� N� Title$ 
SearchName��5
      .��5      � .+�5   
   � ��5      �� 5       �� ImageSource$ G:\doan\thongke.jpg��6   5      (� 5   
    (� Stretch$ Uniform=�6   .��5      � $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   �� 5      $
��Auto �6$   .+�5      �� $��Nhập Tên : ��6   $
��Bold"�6/   $��0,0,0,0q�6A   �� 5       -   5         ��Name$ txtSearchName��5       $��0��61   $��	120,0,0,0q�6>   $	��200��6Q   �� 5"      -   5        $��Tìm Kiếm��5"      $	��100��6,   
�������
����p��$��Right=�6   �� 5$      -   5         ��Name$ listViewSearchResults��5$      $��3��6:   $��10q�6G   
������� �� View 5%      �� 5&      ! �� ColumnHeaderContainerStyle 5'      �� 5(   "   	 �� 
TargetType"	 ��6(   .�5)   &   �� 
 �� Property
 � �� �� Value$ Center=�6S   5*   #   .P�5,      �� $��Mã NV��6-    �� DisplayMemberBinding 6<   �� *MaNv+�� 5-      $
��Tên��6-    6:   �� *Name+�� 5.      $��	Năm Sinh��6-    6?   �� *Age+�� 5/      $��
Phòng Ban��6-    6@   �� *
Department+�� 50      $��Chức Vụ��6-    6>   �� *
Position+�� 51      $��Năm Làm Việc��6-    6C   �� *year+�� 52      $��Lương��6-    6<   �� *Salary+�� 53      $��Công��6-    6;   �� *Cong+�� 55      $��	Thưởng��6-    6=   �� *BonusSalary+�� 56      $ ��Số Lượng Sản Phẩm��6-    6H   �� *	product+�� 57      $��Tổng Lương��6-    6A   �� *TotalSalary+�� 59      $��Thành Phố��6-    6@   �� *City+5:      5<      �� 5?      -   5        $��4��5?      $��In��6&   $	��130��6H   
����+��$��5q�6l   
�������6x   �� 5A      -   5        $��5��5A      $��
Quay lại��6@   $	��130��6S   
����+��$��5q�6w   
�������6�   5B      5C      5D      5E      