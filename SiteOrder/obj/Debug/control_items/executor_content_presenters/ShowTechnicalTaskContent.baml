   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:SiteOrder.control_items.executor_content_presenters3SiteOrder.control_items.executor_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5	      R    LSiteOrder.control_items.executor_content_presenters.ShowTechnicalTaskContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      SlocalAclr-namespace:SiteOrder.control_items.executor_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5      9
converters"clr-namespace:SiteOrder.converters     5	        � 	Resources  5       �� MergedDictionaries-   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter �� 
TargetType  	ListStyle �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource �� Path	 �� Value
 �� Property �� Value�� 5   
    5      %�  &	        &	      &	 &     7��  5      6,     5      6-   �� 5      " ��6   8    5      �� 5       6"   �� # Z $ Items.Count�	 06v   .a�5      �� 
 � �� 5      �� 5   "   .R�5   &   �� $
��12pt(�60   WUУ данного технического задания нет требований6p   5   #   5      5      5      5       .��5"      �� .��5#   
   � $��10,15q�6    � RowDefinitions 5$      �� 5%      $
��auto �6    �� 5&      $
��auto �6    �� 5'      $
��auto �6    �� 5(      �� 5)      $
��auto �6    .+�5,      �  5-      �� 5.      �� 5/      $
��auto �6$    � ColumnDefinitions 51      �� 52      �� 53      $
��auto �6'   .+�56      �� $>��8Просмотр технического задания��6   $
��18pt(�6A   �� 57      -   5         ��Name$ buttonDemandAdd��57   �   $��10,5,0,5q�6   $��1��6+   $��Center=�6;   $
��10px(�6V    � ToolTip$6 0Взять техническое задание��6f   ��58      F� 59      $��20��5:      $��20��5;      |���� -1��� р�� ��� р��  -1р��  -1р�� ��� � 	= ��� � 	= ��� р�� ��� р��  	= р��  	= р�� ��� � -1��� � -1��� 	
������� �� Stretch$ Uniform=�5>      5@      �� 5B      -   5        $ buttonTechnicalTaskWork��5B   �   $��10,5,0,5q�6   $��1��6+   $��Center=�6;   $
��10px(�6V   $A ;Работать с техническим заданием��6f   ��5C      F� 5D      $��20��5E      $��20��5F      ����� -1��[ Ӡ:��[ �2A��^ ��F0�d �@�L��j ��O��q ��O z р�O��!Ӏ�O0O*@�L -1��F�n7Ӑ2A b=�:@o@ -1@o@� 	= @o@�`/4 @o@p-  b= ^' �n7���!  -1�� 0O*�� ��!р�  z Ӏ� ��q ��! ��j  ^' 0�d �p- ��^ `/4 ��[  	= ��[ � z ��[ � z  	= � z `/4 ffffff @p- ��  ^' �� ��! ༏ �� ��� �� р�� �� � y� �� �� ��! `J�  ^' ��� p-  $� `/4  $�  	= � $� ��[ � -1��[ � 	=  z � 	= ��!� -1��!� -1 z � 	=  z ���� ��[ р��  	= р��  	= р�� ��[ р�� ��[ 	
�������$ Uniform=�5I      5K      �� 5M      $��1��6   ��5N      `� 5O       �� StringFormat$8 2Дата создания: {0:dd.MM.yyyy HH:mm:ss}��6'   .1�5P      �� $ createDatetime�6&   5Q      5S      5T      �� 5V        MainWindowColor#��[ 6    �� Padding$ 20,10q�6C   $
��0,20q�6S   $��1��6a   ._�5W      �   5X      ��%p  '��       '�� �     �� 5Y      " ��6    .�5Z      �� 
 � ��$ Center=�6B   �� 5[      
 � ��$ 0,0,20,0q�67   �� 5\      
 � ��$
 12pt(�69   5]      �� 5^      " ��6    .�5_      �� 
 � ��$ Center=�6B   �� 5`      
 � ��$ Stretch=�6D   �� 5a      
 � ��$	 7,8q�68   �� 5b      
 � ��$
 12pt(�69   5c      5d       5e      �� 5f      $
��auto �6+   �� 5g       5i      �� 5j      �� 5k      .+�5n      �� $��Название:��6    $��0��61   $��0��6>   �� 5o      -   5         ��Name$
 name��5o   6   $��1��6D   ��6    �� *name+6D   �� 5q      $��Создатель:��6    $��1��62   $��0��6?   �� 5r      -   5        $ customer��5r   k   $��1��6}   $��1��6�   ��6    �� *
Customer+ �� TargetNullValue$= 7Создатель удалил свой профиль��6�   5t      5u      �� 5w      $'��!Список требований��6   $��2��61   $
��18pt(�6>    �� Padding$ 30,0,0,0q�6N   �� 5y      -   5        $��3��5y   5    � Cursor$
 Hand��6B   $��Disabled=�6|   #��[ 6�   ��6   �� *Demand+��5z      �� 5{      .R�5|      � $	��0,2q�6   $��80��6,    5}      �� 5~   "   �� 5   "   .+�5�      �� $
��13pt(�6>   ��6(   �� *name+6>   �� 5�      $
��Wrap=�6>   $��1��6R   ��6(   �� *text+6R   5�      5�      5�      �� 5�      -   5        $ buttonRefuseTechnicalTask��5�   ]   $��4��6   $��Отказаться��6"     ButtonDelete#��[ 67   $��Right=�6�   $��0,10,0,0q�6�   5�      5�      5�      