   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:SiteOrder.control_items.admin_content_presenters0SiteOrder.control_items.admin_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5	      L    FSiteOrder.control_items.admin_content_presenters.EditSampleSiteContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Plocal>clr-namespace:SiteOrder.control_items.admin_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5	        � 	Resources  5      �� 5   
   %    5      .��5      �� .��5   
   ��  �� Orientation$ Vertical=�6   $��10,15q�6,   .+�5      �� $B��<Редактирование примерного сайта��6   $
��18pt(�6@   �� 5         MainWindowColor#��[  6    �� Padding$ 20,10q�6C   $��1��6S   $
��0,20q�6`   ._�5      �   5       �� 
TargetType �� Property �� Value��%�  '��       '�� �     �� 5      " ��6    .�5      ��  � ��$ Center=�6B   �� 5       � ��$ 	0,0,20,10q�67   �� 5       � ��$
 12pt(�69   �� 5       �@��TextAlignment$ Right=�6>   5      �� 5      " ��6    .�5       ��  � ��$ Center=�6B   �� 5!       � ��$ Stretch=�6D   �� 5"       � ��$ 0,0,0,10q�67   �� 5#       � ��$	 7,8q�68   �� 5$       � ��$
 12pt(�69   5%      5&       � ColumnDefinitions 5'      �� 5(      $
��auto �6+   �� 5)       � RowDefinitions 5+      �� 5,      $
��auto �6(   �� 5-      $
��auto �6(   �� 5.      $
��auto �6(   �� 50      $
��auto �6(   �� 51      $
��auto �6(   �� 52      $
��auto �6(   .+�55      �� $��URL сайта:��6    $��0��62   $��0��6?   �� 56      -   5         ��Name$ siteURL��56   7   $��1��6H   ��6   �� *	siteURL+6H   58      59      � 5;      .+�5<      �� -   5        	 ��Name$	 
ButtonSave��5<   +   $��0,10,0,0q�6   $��1��6X   $��2��6e   $��Сохранить��6y   $��Center=�6�   $
��Left=�6�   5=      5>      5?      5@      