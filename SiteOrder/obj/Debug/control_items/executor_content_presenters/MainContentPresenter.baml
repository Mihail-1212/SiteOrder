   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:SiteOrder.control_items.executor_content_presenters3SiteOrder.control_items.executor_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5	      N    HSiteOrder.control_items.executor_content_presenters.MainContentPresenter   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      SlocalAclr-namespace:SiteOrder.control_items.executor_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5	        � 	Resources  5      -   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter �� 
TargetType  	ListStyle �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource �� Path �� Value	 �� Property
 �� Value�� 5   
   %{  &	        &	      &	 &     7��  5      6,     5      6-   �� 5      " ��6   8    5      �� 5       6"   �� # Z $ Items.Count� 06v   .a�5      �� 	 � ��
 5      �� 5   "   .R�5   &   �� $
��12pt(�60   JHВы не выбрали себе технические задания!6j   5   #   5      5      5      5      .��5      � $��10,15q�6    � RowDefinitions 5    
   �� 5!      $
��auto �6   �� 5"      $
��auto �6   �� 5#      .+�5%   
   �  � ColumnDefinitions 5&      �� 5'      $
��Auto �6#   �� 5(      .+�5*      �� -   5         ��Name$2 ,filterBystatusAvaibleTaskTasksGroupContainer��5*       �� Orientation$ Vertical=�6O   $��Center=�6f   .+�5+      	� -   5         	� 	GroupName$$ filterByStatusAvaibleTaskGroup��5+      $��Все��6X    d� 	IsChecked$
 TrueY�6f   $
��10pt(�6w   
 � Tag 6I   Z� 6�   	� 5,      -   5        $$ filterByStatusAvaibleTaskGroup��5,      /   )SiteOrder.db_context.TechnicalTask_status   	completed# Z 6I   $��Выполненные��6�   $
��10pt(�6�   6�   	� 5-      -   5        $$ filterByStatusAvaibleTaskGroup��5-         
processing# Z 6I   $��В работе��6�   $
��10pt(�6�   6�   	� 5.      -   5        $$ filterByStatusAvaibleTaskGroup��5.         canceled# Z 6I   $��Отмененные��6�   $
��10pt(�6�   6�   5/      �� 50      -   5         ��Name$ showAvaibleTechnicalTask��50      $��2��6^   $
��0,10q�6n   $>��8Доступные технические задания��6|   $��Right=�6�   $��Bottom=�6�   51      �� 52   
   $K��EСписок выбранных технических заданий��6   $��1��6@   $
��0,10q�6N   $
��18pt(�6\    �� Padding$ 30,0,0,0q�6l   �� 53   
   -   5         ��Name$ techincalTaskList��53   B   #��[ 6   $��2��65   $��Stretch=�6]   $
��10,0q�6�   ��54      �� 55      .R�56      � $	��120��6   $
��0,10q�6(    57      �� 58      $
��40px �6/   �� 59      $��* �6/   �� 5:      $��* �6/   �� 5;      $
��auto �6/    5=      �� 5>      $
��auto �6,   �� 5?      .+�5B      �� $��2��6!    � Cursor$
 Hand��62   $
��auto��6�   $
��auto��6�   
������ $��Center=�6�    � ToolTip 6@   �� *Status+ �� 	Converter# [ ._�5C      F� $��20��5D   !   $��20��5E   !     darkula#��[ 5G   !    �� Stretch$ Uniform=�5H   !   ��5F   !   �� *Status+# [  5H   !   5I      �� 5K      $
��14pt(�6$   $��1��65   $
��Wrap=�6[   $��Center=�6o   ��6E   �� *name+6o   �� 5L      $
��11pt(�6$   $��1��64   $��1��6A   $
��Wrap=�6�   $��Center=�6�   ��6Q   �� *
Customer+ �� TargetNullValue$= 7Создатель удалил свой профиль�� �� StringFormat$  Создатель: {0}��6�   �� 5M      $��2��6$    �� TextAlignment$ Right=�64   ��5N      `� 5O   "   $8 2Дата создания: {0:dd.MM.yyyy HH:mm:ss}��6/   .1�5P   &   �� $ createDatetime�6.   5Q   #   5S      �� 5T      $ demandListPreview��6?   -   5        $��1��5T   "   $��2��6/   $
 Hand��6y   ��6Z   �� *Demand+6�   �� 5V      $ buttonTechnicalTaskWork��6�   -	   5        $��10,5,0,5q�5V   !   $��3��63   $��1��6C   $	��Top=�6P   $
��10px(�6h   $A ;Работать с техническим заданием��6x   ��5W      F� 5X   "   $��20��5Y   %   $��20��5Z   %   ����� -1��[ Ӡ:��[ �2A��^ ��F0�d �@�L��j ��O��q ��O z р�O��!Ӏ�O0O*@�L -1��F�n7Ӑ2A b=�:@o@ -1@o@� 	= @o@�`/4 @o@p-  b= ^' �n7���!  -1�� 0O*�� ��!р�  z Ӏ� ��q ��! ��j  ^' 0�d �p- ��^ `/4 ��[  	= ��[ � z ��[ � z  	= � z `/4 ffffff @p- ��  ^' �� ��! ༏ �� ��� �� р�� �� � y� �� �� ��! `J�  ^' ��� p-  $� `/4  $�  	= � $� ��[ � -1��[ � 	=  z � 	= ��!� -1��!� -1 z � 	=  z ���� ��[ р��  	= р��  	= р�� ��[ р�� ��[ 	
�������$ Uniform=�5]   %   5_      �� 5a      $ buttonDemandAction��6�   -
   5        $��10,5,0,0q�5a   !   $��3��63   $��2��6C   $��Bottom=�6T   $
��10px(�6o   $ Просмотр��6   ��5b      F� 5c   "   $��20��5d   %   $��20��5e   %   ����� � @T� ����  � ���- ��- � � ��� ���- ��- �@T�  � ���- ��- � � @T� ���- ��- � �  �D �@f �D ��D�t ��^ � ���Dp� @f��) � ��)���j ��)�) p�  � ��) �t ��j  �D  �  �D ���0  � �0�I  `� ��} ` � `Ӏz� `Ђ$ `�  �= � �Ђ$ փ �z� �.c  � �.c Ӏ�} �.c 0�I  փ ��0  � 	
�������$ Uniform=�5h   %   5j      5k      5l      5n      5o      5p      