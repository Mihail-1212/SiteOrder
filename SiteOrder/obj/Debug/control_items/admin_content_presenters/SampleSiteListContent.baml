   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:SiteOrder.control_items.admin_content_presenters0SiteOrder.control_items.admin_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5	      L    FSiteOrder.control_items.admin_content_presenters.SampleSiteListContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:SiteOrder.control_items.admin_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5	        � 	Resources  5      �� 5   
   %    5      .��5      � $��10,15q�6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      �� 5      $
��auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $2��,Список примерных сайтов��6   $
��18pt(�64   $��0,0,0,20q�6D   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ datagridSampleSiteList��5   4   $��2��6   $��1��6'      AutoGenerateColumns .     
IsReadOnly .    Columns 5       4  .System.Windows.Controls.DataGridTemplateColumn  5!      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6)      Header$ Открыть��66   	   CellTemplate	 5"      �� 5#      .R�5$      �� 
 ��Name$
 
buttobLink��6%   -   5         � ToolTip$ Открыть сайт��5$   R   $	��0,5q�6i   ��5%   "   F� 5&   &   $��20��5'   )   $��20��5(   )   �����`�;  � �`�; P� �P �͇ ��j �͇ ��ا �͇ ��ا ��j ���j ��j ׀�  �  @KL @KL ���j @f @KL @KL ��ا @f��ا `h� ���j `h� ��P `h� `�; �2� `�;  � � z @]� � $� @]� � $� �ا � z �ا � z @]� �@f��j �@]� ��j �@]� �͇ �@f�͇ ��}�͇ ��2P� ��2 � Ӡ�2�2� �}`h� @f`h� �@]� `h� �@]� @f�@f@f׀�O �  @KL @KL �@f��j  @KL @KL 	
������� �� Stretch$ Uniform=�5+   )   5-      5.      50      0  *System.Windows.Controls.DataGridTextColumn  51      $	 URL��6%   $ * 6N   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *	siteURL+6N     52      $/ )Количество требований��6%   $
 auto 6o    6D   �� *SampleSitesGroup.Count+6o     53      $" Редактирование��6)   $
 auto 6A   	 54      �� 55      .R�56      �� $
 buttonUserEdit��6K   -   5        $"��Редактирование��56   %   $	��8,0q�6>   $
��10pt(�6�   57      59      5;      �� 5=   
   -   5        $
 buttonCreate��5=   A   $��Добавить��6   $��2��6$   $��0��61   $��0,10,0,0q�6r   �� 5?   
   -   5        $
 buttonDelete��5?   @   $��Удалить��6   $��2��6#   $��1��60   $��0,10,0,0q�6q   $��Right=�6�      ButtonDelete#��[  6�   5A      5B      