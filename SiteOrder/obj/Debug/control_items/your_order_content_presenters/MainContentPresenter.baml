   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      }Cclr-namespace:SiteOrder.control_items.your_order_content_presenters5SiteOrder.control_items.your_order_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5	      P    JSiteOrder.control_items.your_order_content_presenters.MainContentPresenter   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:SiteOrder.control_items.your_order_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5	        � 	Resources  5      -   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter3  -SiteOrder.converters.StatusButtonSvgConverter  StatusButtonSvgConverter �� 
TargetType  	ListStyle �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource �� Path �� Value	 �� Property
 �� Value�� 5   
   %�  &	        &	      &	 &     &	 9     7��  5      6,     5      6-     5      62   �� 5      " ��6   8    5      �� 5       6"   �� # Z $ Items.Count� 06v   .a�5      �� 	 � ��
 5      �� 5   "   .R�5   &   �� $
��12pt(�60   IGУ вас отсутствуют технические задания!6i   5   #   5      5      5      5      .��5       � $��10,15q�6    � RowDefinitions 5!   
   �� 5"      $
��auto �6   �� 5#      $
��auto �6   �� 5$      .+�5&   
   �  � ColumnDefinitions 5'      �� 5(      $
��Auto �6#   �� 5)      .+�5+      �� -   5         ��Name$" filterBystatusGroupContainer��5+       �� Orientation$ Vertical=�6?   $��Center=�6V   .+�5,      	� -   5         	� 	GroupName$ filterBystatusGroup��5,      $��Все��6M    d� 	IsChecked$
 TrueY�6[   $
��10pt(�6l   
 � Tag 6>   Z� 6|   	� 5-      -   5        $ filterBystatusGroup��5-      /   )SiteOrder.db_context.TechnicalTask_status   	completed# Z 6>   $��Выполненные��6y   $
��10pt(�6�   6�   	� 5.      -   5        $ filterBystatusGroup��5.         
processing# Z 6>   $��В работе��6z   $
��10pt(�6�   6�   	� 5/      -   5        $ filterBystatusGroup��5/         canceled# Z 6>   $��Отмененные��6x   $
��10pt(�6�   6�   50      �� 51      -   5         ��Name$ createNewTaskButton��51      $��2��6T   $
��0,10q�6d   $��Сделать заказ��6r   $��Right=�6�   $��Bottom=�6�   52      �� 54   
   $V��PСписок ваших созданных технических заданий��6   $��1��6F   $
��0,10q�6T   $
��18pt(�6b    �� Padding$ 30,0,0,0q�6r   �� 56   
   -   5         ��Name$ techincalTaskList��56      $��2��6-   $��Stretch=�6:   #��[ 6_   ��57      �� 58      .R�59      � $
��0,10q�6   $	��100��6)    5:      �� 5;      $
��40px �6/   �� 5<      $��* �6/   �� 5=      $��* �6/   �� 5>      $
��auto �6/    5@      �� 5A      $
��auto �6,   �� 5B      .+�5E      �� $��2��6!    � Cursor$
 Hand��62   $
��auto��6�   $
��auto��6�   
������ $��Center=�6�    � ToolTip 6@   �� *Status+ �� 	Converter# [ ._�5F      F� $��20��5G   !   $��20��5H   !     darkula#��[ 5J   !    �� Stretch$ Uniform=�5K   !   ��5I   !   �� *Status+# [  5K   !   5L      �� 5M      $��2��6$   $
��14pt(�65   $��1��6F   $
��Wrap=�6l   $��Center=�6�   ��6V   �� *name+6�   �� 5N      $��2��6$    �� TextAlignment$ Right=�64   ��5O      `� 5P   "    �� StringFormat$8 2Дата создания: {0:dd.MM.yyyy HH:mm:ss}��6/   .1�5Q   &   �� $ createDatetime�6.   5R   #   5T      �� 5U      $ 
demandList��6?   -   5        $��1��5U   "   $��2��6/   $
 Hand��6r   ��6S   �� *Demand+6�   �� 5W      $ buttonDemandAction��6�   -	   5        $��10,5,0,0q�5W   !   $��3��63   $��2��6C   $��Bottom=�6T   $
��10px(�6o   $ Просмотр��6   ��5X      F� 5Y   "   $��20��5Z   %   $��20��5[   %   
�������$ Uniform=�5^   %   ��5\   %   �� *Status+# [ 5^   %   5`      5a      5b      5d      5e      5f      