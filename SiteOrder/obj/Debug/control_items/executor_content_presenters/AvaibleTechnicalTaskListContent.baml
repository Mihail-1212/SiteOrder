   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:SiteOrder.control_items.executor_content_presenters3SiteOrder.control_items.executor_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      Y    SSiteOrder.control_items.executor_content_presenters.AvaibleTechnicalTaskListContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      SlocalAclr-namespace:SiteOrder.control_items.executor_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5        � 	Resources  5       �� 
TargetType   	ListStyle �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource �� Path �� Value	 �� Property
 �� Value�� 5   
   %I  &	        7���� 5      " ��6   8    5      �� 5       6"   �� # Z $ Items.Count� 06v   .a�5      �� 	 � ��
 5      �� 5   "   .R�5   &   �� $
��12pt(�60   RPОтсутствуют доступные технические задания!6m   5   #   5      5      5      5      .��5      � $��10,15q�6    � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5    
   �� 5!      $
��auto �6   �� 5"      .+�5$   
   � $��0,0,0,15q�6    5%      �� 5&      �� 5'      $
��auto �6     5)      �� 5*      �� 5+      $
��auto �6#   .+�5.      �� $K��EСписок доступных технических заданий��6   $
��18pt(�6E   5/      �� 51   
   -   5         ��Name$ techincalTaskList��51      #��[  6-   $��1��6P   $��Stretch=�6]   $
��10,0q�6�   ��52      �� 53      .R�54      � $	��120��6   $
��0,10q�6(    55      �� 56      $��* �6/   �� 57      $��* �6/   �� 58      $
��auto �6/    5:      �� 5;      $
��auto �6,   �� 5<      .+�5?      �� $
��14pt(�6$   $��0��65   $
��Wrap=�6[   $��Center=�6o   ��6E   �� *name+6o   �� 5@      $
��11pt(�6$   $��1��64   $��0��6A   $
��Wrap=�6�   $��Center=�6�   ��6Q   �� *
Customer+ �� TargetNullValue$= 7Создатель удалил свой профиль�� �� StringFormat$  Создатель: {0}��6�   �� 5A      $��1��6$    �� TextAlignment$ Right=�64   ��5B      `� 5C   "   $8 2Дата создания: {0:dd.MM.yyyy HH:mm:ss}��6/   .1�5D   &   �� $ createDatetime�6.   5E   #   5G      �� 5H      $ demandListPreview��6?   -   5        $��1��5H   "   $��1��6/    � Cursor$
 Hand��6y   ��6Z   �� *Demand+6�   �� 5J       ��Name$ buttonDemandAdd��6�   -   5        $��10,5,0,5q�5J   !   $��3��63   $��1��6C   $	��Top=�6P   $
��10px(�6h    � ToolTip$6 0Взять техническое задание��6x   ��5K      F� 5L   "   $��20��5M   %   $��20��5N   %   |���� -1��� р�� ��� р��  -1р��  -1р�� ��� � 	= ��� � 	= ��� р�� ��� р��  	= р��  	= р�� ��� � -1��� � -1��� 	
������� �� Stretch$ Uniform=�5Q   %   5S      �� 5U      $ buttonDemandAction��6�   -   5        $��10,5,0,0q�5U   !   $��3��63   $��1��6C   $��Bottom=�6P   $
��10px(�6k   $ Просмотр��6{   ��5V      F� 5W   "   $��20��5X   %   $��20��5Y   %   ����� � @T� ����  � ���- ��- � � ��� ���- ��- �@T�  � ���- ��- � � @T� ���- ��- � �  �D �@f �D ��D�t ��^ � ���Dp� @f��) � ��)���j ��)�) p�  � ��) �t ��j  �D  �  �D ���0  � �0�I  `� ��} ` � `Ӏz� `Ђ$ `�  �= � �Ђ$ փ �z� �.c  � �.c Ӏ�} �.c 0�I  փ ��0  � 	
�������$ Uniform=�5\   %   5^      5_      5`      5b      5c      5d      