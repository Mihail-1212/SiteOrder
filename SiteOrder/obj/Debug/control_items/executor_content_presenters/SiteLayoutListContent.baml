   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:SiteOrder.control_items.executor_content_presenters3SiteOrder.control_items.executor_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5	      O    ISiteOrder.control_items.executor_content_presenters.SiteLayoutListContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      SlocalAclr-namespace:SiteOrder.control_items.executor_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5      9
converters"clr-namespace:SiteOrder.converters     5	        � 	Resources  5       �� MergedDictionaries�� 5   
    5      %    5      .��5      � $��10,15q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ textblockLayoutList��5   5   $6��0Список выбранных шаблонов��6   $
��18pt(�6S   $��0,0,0,20q�6c   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ datagridSiteLayoutList��5!   4   $��2��6   $��1��6'      AutoGenerateColumns .     
IsReadOnly .    Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Описание��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 67   �� *SiteLayout.description+6b     5%      $%	 Тип пользователя��6%   $
 * 6?      ElementStyle 5&      �� 5'       �� 
TargetType" ��6     �� Triggers 5(      �� 5)   "    �� Binding 6.   �� *	isOwner+ �� Value True6J   .a�5*   &   ��  �� Property � �� �� Value$ Владелец��6=   6P   5+   #   �� 5,   "    6.   �� *	isOwner+	 False6J   .a�5-   &   ��  � ��$- 'Обычный пользователь��6=   6\   5.   #   50      52        53      $	 Тип макета��6%   $
 * 69    54      �� 55      " ��6     56      �� 57   "    6.   �� *SiteLayout.isPublic+ True6V   .a�58   &   ��  � ��$ Публичный��6=   6Q   59   #   �� 5:   "    6.   �� *SiteLayout.isPublic+	 False6V   .a�5;   &   ��  � ��$ Приватный��6=   6Q   5<   #   5>      5@      4  .System.Windows.Controls.DataGridTemplateColumn  5A      $	 Работа��6)   $

 auto 69      CellTemplate 5B      �� 5C      .R�5D      ��  ��Name$ buttonSiteLayoutWork��6E   -   5        $��Работать��5D   %   $	��8,5q�68   $
��10pt(�6�   5E      5G      5I      �� 5K   
   -   5        $ buttonCreateLayout��5K   F   $��Создать макет��6   $��2��6)   $��0��66   $��0,10,0,0q�6�   �� 5M   
   -   5        $ buttonRequestAccess��5M   Q   $3��-Запросить права к макету��6   $��2��64   $��1��6A   $��Right=�6�   $��0,10,0,0q�6�   5O      5Q      