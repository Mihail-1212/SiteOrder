   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      }Cclr-namespace:SiteOrder.control_items.your_order_content_presenters5SiteOrder.control_items.your_order_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5	      P    JSiteOrder.control_items.your_order_content_presenters.TechnicalTaskContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:SiteOrder.control_items.your_order_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5	        � 	Resources  5       �� MergedDictionaries-   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter �� 
TargetType  	ListStyle �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource �� Path	 �� Value
 �� Property �� Value�� 5   
    5      %�  &	        &	      &	 &     7��  5      6,     5      6-   �� 5      " ��6   8    5      �� 5       6"   �� # Z $ Items.Count�	 06v   .a�5      �� 
 � �� 5      �� 5   "   .R�5   &   �� $
��12pt(�60   WUУ данного технического задания нет требований6p   5   #   5      5      5      5!      .��5$      �� .��5%   
   ��  �� Orientation$ Vertical=�6   $��10,15q�6,   .+�5'      �  � RowDefinitions 5(      �� 5)      �� 5*      $
��auto �6$    � ColumnDefinitions 5,      �� 5-      �� 5.      $
��auto �6'   .+�51      �� $>��8Просмотр технического задания��6   $
��18pt(�6A   d� 53      -   5         d�Name$ BorderTogglePopup��53      $��1��6:   
������ $��0q�6c   .��54      �� $��1��6    � Cursor$
 Hand��6-   $
��auto��6�   $
��auto��6�   
������ $��Center=�6�    � ToolTip 6;   �� *Status+ �� 	Converter# [ ._�55      F� $��40��56      $��40��57        darkula#��[ 59       �� Stretch$ Uniform=�5:      ��58      �� *Status+# [  5:      5;      5<      � 5>       � 	StaysOpen .  $��Bottom=�6�    � VerticalOffset$ 0��6�    � AllowsTransparency . ��6   �� *	IsChecked+ �� ElementName$ BorderTogglePopup�� � PlacementTarget 6f   �� $ BorderTogglePopup��.��5?      ��  J� Effect 5@      3  -System.Windows.Media.Effects.DropShadowEffect  5A      -   5        DropShadowEffect��   
BlurRadius$ 15Q�5A   I      	Direction$	 -90Q�6Y      RenderingBias$ Quality=�6i      ShadowDepth$ 0Q�6�      Color 6�   �� $ Color�  electron_blue �� Source# [ ._�5C      �� $ Vertical=�6%   .+�5E      �� -   5          ��Name$  ButtonStatusProcessing��5E   %   /   )SiteOrder.db_context.TechnicalTask_status!   
processing
" � Tag#" Z! 6f   
������ $��0q�6�   $
 Hand��6�   $&  Добавить в работу��6�   .��5F   "   �� $��Center=�6)   ._�5G   &   F� $��40��5H   )   $��40��5I   )   ����Ѐ�[ �� р��� р� z р� z р� z р��  � р� $� р� $� р� $� р���Oр�[ ��Oр�[  $� р�[  $� р�[  $� р��  � р�[  z р�[  z р�[  z р�[ �� � $�  �� � �  �� � z  �� � z  -1� $�  -1� $�  �� � � �y� � $� �pr � $�  	= � z  	= � z �pr � � �y� ���� ��[ р�� ��[ р�� 0�f � � ��� р�� 0�f р�� ��[ 	#��[ 5K   )   $ Uniform=�5L   )   5M   '   5N   #   5O      5P      5Q      5R      �� 5T      $��1��6   ��5U      `� 5V      # �� StringFormat$8# 2Дата создания: {0:dd.MM.yyyy HH:mm:ss}��6'   .1�5W      �� $ createDatetime�6&   5X      5Z      5[      �� 5]        MainWindowColor#��[ 6   $ �� Padding$$ 20,10q�6C   $
��0,20q�6S   ._�5^      �   5_      ��%p  '��       '�� �     �� 5`      " ��6    .�5a      �� 
 � ��$ Center=�6B   �� 5b      
 � ��$ 0,0,20,0q�67   �� 5c      
 � ��$
 12pt(�69   5d      �� 5e      " ��6    .�5f      �� 
 � ��$ Center=�6B   �� 5g      
 � ��$ Stretch=�6D   �� 5h      
 � ��$	 7,8q�68   �� 5i      
 � ��$
 12pt(�69   5j      5k       5l      �� 5m      $
��auto �6+   �� 5n       5p      �� 5q      �� 5r      .+�5u      �� $��Название:��6    $��0��61   $��0��6>   �� 5v      -   5        % ��Name$
% name��5v   6   $��1��6D   ��6    �� *name+6D   5x      5y      �� 5{      $'��!Список требований��6   $
��18pt(�61   & �� Padding$& 30,0,0,0q�6A   �� 5}      -   5        $
 Hand��5}      $��Disabled=�6o   #��[ 6�   ��6$   �� *Demand+��5~      �� 5      .R�5�      � $	��0,2q�6   $��80��6,    5�      �� 5�   "   �� 5�   "   .+�5�      �� $
��13pt(�6>   ��6(   �� *name+6>   �� 5�      $
��Wrap=�6>   $��1��6R   ��6(   �� *text+6R   5�      5�      5�      � 5�      .+�5�      �� -   5        $  ButtonDelete��5�   +   $��0,10,0,0q�6   $��1��6]   $��2��6j     ButtonDelete#��[ 6~   $��Удалить��6�   $��Center=�6�   $��Right=�6�   5�      5�      5�      5�      