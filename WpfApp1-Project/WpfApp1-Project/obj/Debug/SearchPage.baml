   M S B A M L   `   `   `  ����J  FWpfApp1-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1_ProjectWpfApp1_Project  5           WpfApp1_Project.SearchPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApp1_Project     5        N� 
Background
  ����� N� Title$ 
SearchPage��5
      .��5      � .+�5   
   (�  (� Stretch$ Uniform=�6   .��5   
   � $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    .+�5      �� $��Nhập Tên : ��6   $
��Bold"�6+   $��0,0,0,0q�6=   �� 5      -   5         ��Name$ txtSearchName��5      $��0��6-   $��	120,0,0,0q�6:   $	��200��6M   �� 5      -   5        $��Tìm Kiếm��5      $	��100��6(   
�������
����p��$��Right=�6w   �� 5      $��Nhập Phòng Ban : ��6   $
��Bold"�61   $��0,10,0,0q�6C   $��1��6U   �� 5      -   5        $ txtSearchDepartment��5      $��1��63   $��
120,10,0,0q�6@   $	��200��6T   �� 5      -   5        $��Tìm kiếm��5      $	��100��6(   
�������
����p��$��Right=�6w   $��
325,10,0,0q�6�   $��1��6�   �� 5       $��Nhập Năm : ��6   $
��Bold"�6+   $��0,10,0,0q�6=   $��2��6O   �� 5!      -   5        $ txtSearchYear��5!      $��2��6-   $��
120,10,0,0q�6:   $	��200��6N   �� 5"      -   5        $��Tìm Kiếm��5"      $	��100��6(   
�������
����p��$��Right=�6|   $��2��6�   $��
325,10,0,0q�6�   �� 5$      -   5         ��Name$ listViewSearchResults��5$      $��3��66   $
��0,10q�6C   
������� �� View 5%      �� 5&      ! �� ColumnHeaderContainerStyle 5'      �� 5(       �� 
TargetType" ��6$   .�5)   "   �� 	 �� Property	 � ��
 �� Value$
 Center=�6O   5*      .P�5-      �� $��Mã NV��6)    �� DisplayMemberBinding 68   �� *MaNv+�� 5.      $
��Tên��6)    66   �� *Name+�� 5/      $��	Năm Sinh��6)    6;   �� *Age+�� 50      $��
Phòng Ban��6)    6<   �� *
Department+�� 51      $��Chức Vụ��6)    6:   �� *
Position+�� 52      $��Năm Làm Việc��6)    6?   �� *year+�� 53      $ ��Số Lượng Sản Phẩm��6)    6D   �� *	product+�� 54      $��Lương Tháng��6)    6>   �� *Salary+�� 55      $��Lương Thưởng��6)    6?   �� *BonusSalary+�� 56      $��Tổng Lương��6)    6=   �� *TotalSalary+�� 58      $��Thành Phố��6)    6<   �� *City+59      5;      �� 5>      -   5        $��4��5>      $��
Quay lại��6;   $	��130��6N   
����+��$��5q�6r   
�������6~   5?      5@      5A      5B      