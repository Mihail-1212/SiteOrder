   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:SiteOrder.control_items.executor_content_presenters3SiteOrder.control_items.executor_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5	      W    QSiteOrder.control_items.executor_content_presenters.SiteLayoutPossibleListContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      SlocalAclr-namespace:SiteOrder.control_items.executor_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5      9
converters"clr-namespace:SiteOrder.converters     5	        � 	Resources  5       �� MergedDictionaries�� 5   
    5      %    5      .��5      � $��10,15q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $,��&Список всех шаблонов��6   $
��18pt(�61   $��0,0,0,20q�6A   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$  datagridSiteLayoutFullList��5!   4   $��2��6   $��1��6'      AutoGenerateColumns .     
IsReadOnly .    Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn   Header$ Описание��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6W   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 67   �� *description+6W     5%      $ Владелец��6%   $	 * 67   
 6A   �� *Owner+  5'      $ Тип макета��6%   $	 * 69      ElementStyle 5(      �� 5)       �� 
TargetType" ��6     �� Triggers 5*      �� 5+   "    �� Binding 6.   �� *
isPublic+ �� Value True6K   .a�5,   &   ��  �� Property � �� �� Value$ Публичный��6=   6Q   5-   #   �� 5.   "    6.   �� *
isPublic+	 False6K   .a�5/   &   ��  � ��$ Приватный��6=   6Q   50   #   52      54      4  .System.Windows.Controls.DataGridTemplateColumn  56      $ Запрос��6)   $
	 auto 69      CellTemplate 57      �� 58      .R�59      ��  ��Name$ buttonRequestLayout��6E   -   5        $��Работать��59   %   $	��8,5q�68   $
��10pt(�6�    �� Triggers 5:      �� 5;   "   $
 True��6K    6.   �� *
isPublic+.a�5<   &   ��  �� 
TargetName$ buttonRequestLayout��6-    � ��$! Получить права��6a   6z   5=   #   �� 5>   "   $ False��6K    6.   �� *
isPublic+.a�5?   &   �� $ buttonRequestLayout��6-    � ��$# Запросить права��6a   6{   5@   #   5B      5D      5G      5M      5O      