   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:SiteOrder.control_items.admin_content_presenters0SiteOrder.control_items.admin_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5	      F    @SiteOrder.control_items.admin_content_presenters.UserListContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:SiteOrder.control_items.admin_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5	        � 	Resources  5      -   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter*  $SiteOrder.converters.RightsConverter  RightsConverter�� 5   
   %W   &	        &	      &	 &       5      6,     5      6-     5      6)   5      .��5      � $��10,15q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $-��'Список пользователей��6   $
��18pt(�61   $��0,0,0,20q�6A   &   System.Windows.Controls.DataGrid  5    
   -   5          Name$ datagridUserList��5    4   $��2��6   $��1��6'      AutoGenerateColumns .     
IsReadOnly .    Columns 5!      0  *System.Windows.Controls.DataGridTextColumn  5"      ,  &System.Windows.Controls.DataGridColumn   Header$ 
Логин��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6N   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *login+6N     5#      $ ФИО��6%   $ * 6F   	 62   �� 6F     5$      $% Тип пользователя��6%   $ * 6~   	 6?   �� 
 �� 	Converter#
 [ 6~     5%      $ Эл. почта��6%   $ * 6R   	 68   �� *Email+6R   4	  .System.Windows.Controls.DataGridTemplateColumn	  5&      $" Редактирование��6)   $
 auto 6A    	  CellTemplate 5'      �� 5(      .R�5)      ��  ��Name$ buttonUserEdit��6K   -   5        $"��Редактирование��5)   %   $	��8,5q�6>   $
��10pt(�6�   5*      5,      5.      �� 50   
   -   5        $ buttonCreate��50   A   $��Добавить��6   $��2��6$   $��0��61   $��0,10,0,0q�6r   �� 52   
   -   5        $ buttonDelete��52   @   $��Удалить��6   $��2��6#   $��1��60   $��0,10,0,0q�6q   $��Right=�6�     ButtonDelete#��[ 6�   54      55      