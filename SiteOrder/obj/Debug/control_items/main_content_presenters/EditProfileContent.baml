   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5   #   q=clr-namespace:SiteOrder.control_items.main_content_presenters/SiteOrder.control_items.main_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5      H    BSiteOrder.control_items.main_content_presenters.EditProfileContent   5   #   :
overridden+clr-namespace:SiteOrder.overridden_controls  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Olocal=clr-namespace:SiteOrder.control_items.main_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5        � 	Resources  5      -   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter3  -SiteOrder.converters.StatusButtonSvgConverter  StatusButtonSvgConverter �� 
TargetType  	ListStyle �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource �� Path �� Value	 �� Property
 �� Value�� 5   
   %�  &	        &	      &	 &     &	 9     7��  5      6,     5      6-     5      62   �� 5      " ��6   8    5      �� 5       6"   �� # Z $ Items.Count� 06v   .a�5      �� 	 � ��
 5      �� 5   "   .R�5   &   �� $
��12pt(�60   IGУ вас отсутствуют технические задания!6i   5   #   5      5      5      5      .��5      �� .��5    
   ��  �� Orientation$ Vertical=�6   $��10,15q�6,   .+�5"      �  � RowDefinitions 5#      �� 5$      �� 5%      $
��auto �6$    � ColumnDefinitions 5'      �� 5(      �� 5)      $
��auto �6'   .+�5,      �� $E��?Просмотр и редактирование профиля��6   $
��18pt(�6E   5-      �� 5/        MainWindowColor#��[ 6    �� Padding$ 20,10q�6C   $
��0,20q�6S   ._�50      �   51      ��%�  '��       '�� �     �� 52      " ��6    .�53      �� 	 � ��$
 Center=�6B   �� 54      	 � ��$
 
0,0,20,5ptq�67   �� 55      	 � ��$

 12pt(�69   �� 56      	 �@��TextAlignment$
 Right=�6>   57      �� 58      " ��6    .�59      �� 	 � ��$
 Center=�6B   �� 5:      	 � ��$
 Stretch=�6D   �� 5;      	 � ��$	
 8,7q�68   �� 5<      	 � ��$

 12pt(�69   �� 5=      	 � ��$
 	0,0,0,5ptq�67   5>      5?       5@      �� 5A      $
��auto �6+   �� 5B       5D      �� 5E      �� 5F      �� 5G      �� 5H      �� 5I      �� 5J      �� 5K      .+�5N      �� $��Фамилия*:��6    $��0��61   $��0��6>   �� 5O      -   5         ��Name$ surname��5O   7   $��1��6H   ��6   �� *	surname+6H   �� 5Q      $��Имя*:��6    $��1��6-   $��0��6:   �� 5R      -   5        $
 name��5R   4   $��1��6B   $��1��6O   ��6   �� *name+6O   �� 5T      $��Отчество:��6    $��2��61   $��0��6>   �� 5U      -   5        $ 
patronymic��5U   G   $��2��6:   $��1��6[   ��6   �� *
patronymic+6[   �� 5W      $��Email:��6    $��3��6.   $��0��6;   �� 5X      -   5        $ email��5X   B   $��3��65   $��1��6Q   ��6   �� *email+6Q   �� 5Z      $��Фотография:��6    $��4��63   $��0��6@   �� 5[      -   5         ��Name$ photo��5[   D   $��4��67   $��1��6S   ��6   �� *Photo+6c   �� 5]      -   5        $ buttonPasswordChange��5]   V   $��0,10,0,0q�6   $#��Изменить пароль��6/   $��5��6I   $��0��6�   $��Stretch=�6�   5^      5_      � 5`      .+�5a      �� -   5        $ 
ButtonSave��5a   +   $��0,10,0,0q�6   $��1��6X   $��2��6e   $��Сохранить��6y   $��Center=�6�   $
��Left=�6�   �� 5c      -   5        $ ButtonDelete��5c   +   $��0,10,0,0q�6   $��1��6]   $��2��6j     ButtonDelete#��[ 6~   $��Удалить��6�   $��Center=�6�   $��Right=�6�   5d      5e      5g      5h      