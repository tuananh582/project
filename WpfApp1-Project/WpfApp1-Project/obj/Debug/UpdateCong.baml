   M S B A M L   `   `   `  ����J  FWpfApp1-Project, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApp1_ProjectWpfApp1_Project  5           WpfApp1_Project.UpdateCong   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:WpfApp1_Project     5        N� 
Background
  ����� N� Title$ 
UpdateCong��5
      .��5      � .+�5   
   � ��5      �� 5       �� ImageSource$ G:\doan\coin.jpg��6   .+�5      (�  (� Stretch$ Uniform=�6   .��5      � $��20q�6    � RowDefinitions 5      �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   �� 5      $
��Auto �6(   .+�5      �� $��Nhập mã nhân viên: ��6    $
��Bold"�6;   $��0,0,0,0q�6M   �� 5      -   5         ��Name$ txtSearchMaNv��5      $��0��65   $��	120,0,0,0q�6B   $	��200��6U   �� 5       -   5        $��Tìm Kiếm��5       $	��100��60   
�������
����p��$��Right=�6   �� 5!      $��Nhập số công  : ��6    $
��Bold"�68   $��0,10,0,0q�6J   $��1��6\   �� 5"      -   5        $ txtUpdateCong��5"      $��1��65   $��
120,10,0,0q�6B   $	��200��6V   �� 5#      -   5        $��Cập nhật��5#      $	��100��60   
�������
����p��$��Right=�6�   $��1��6�   $��
325,10,0,0q�6�   �� 5%      -   5         ��Name$ listViewSearchResults��5%      $��3��6>   $
��0,10q�6K   
������� �� View 5&      �� 5'      ! �� ColumnHeaderContainerStyle 5(   "   �� 5)   &   	 �� 
TargetType"	 ��6,   .�5*   *   �� 
 �� Property
 � �� �� Value$ Center=�6W   5+   '   .P�5-   "   �� $��Mã NV��61    �� DisplayMemberBinding 6@   �� *MaNv+�� 5.   "   $
��Tên��61    6>   �� *Name+�� 5/   "   $��	Năm Sinh��61    6C   �� *Age+�� 50   "   $��
Phòng Ban��61    6D   �� *
Department+�� 51   "   $��Chức Vụ��61    6B   �� *
Position+�� 52   "   $��Năm Làm Việc��61    6G   �� *year+�� 53   "   $��Lương��61    6@   �� *Salary+�� 54   "   $��Công��61    6?   �� *Cong+�� 56   "   $��	Thưởng��61    6A   �� *BonusSalary+�� 57   "   $ ��Số Lượng Sản Phẩm��61    6L   �� *	product+�� 58   "   $��Tổng Lương��61    6E   �� *TotalSalary+�� 5:   "   $��Thành Phố��61    6D   �� *City+5;      5=      �� 5@      -   5        $��4��5@      $��
Quay lại��6A   $	��130��6T   
����+��$��5q�6x   
�������6�   5A      5B      5C      5D      5E      