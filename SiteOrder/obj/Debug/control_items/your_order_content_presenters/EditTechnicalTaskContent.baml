   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      }Cclr-namespace:SiteOrder.control_items.your_order_content_presenters5SiteOrder.control_items.your_order_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5	      T    NSiteOrder.control_items.your_order_content_presenters.EditTechnicalTaskContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:SiteOrder.control_items.your_order_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5	        � 	Resources  5       �� MergedDictionaries �� Source-   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter �� 
TargetType  	ListStyle �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource	 �� Path
 �� Value �� Property �� Value�� 5   
    5      �� 5      $. (/styles/IelementsResourceDictionary.xaml?�6%   %�  &	        &	      &	 &     7��  5      6,     5      6-   �� 5      " ��6   8    5      �� 5       6"   �� # Z $	 Items.Count�
 06v   .a�5      ��  � �� 5      �� 5   "   .R�5   &   �� $
��12pt(�60   WUУ данного технического задания нет требований6p   5   #   5      5      5      5       .��5"      �� .��5#   
   ��  �� Orientation$ Vertical=�6   $��10,15q�6,   .+�5$      �  � RowDefinitions 5%      �� 5&      �� 5'      $
��auto �6$    � ColumnDefinitions 5)      �� 5*      �� 5+      $
��auto �6'   .+�5.      �� $J��DРедактирование технического задания��6   $
��18pt(�6H   d� 50      -   5         d�Name$ BorderTogglePopup��50      $��1��6:   
������ $��0q�6c   .��51      ��  � Cursor$
 Hand��6   $
��auto��6v   $
��auto��6�   
������ $��Center=�6�    � ToolTip 6+   �� *Status+ �� 	Converter# [ ._�52      F� $��40��53      $��40��54        darkula#��[ 56       �� Stretch$ Uniform=�57      ��55      �� *Status+# [  57      58      59      � 5;      -   5         �Name$ PopupStatus��5;       � 	StaysOpen .  $��Bottom=�6�    � VerticalOffset$ 0��6�    � AllowsTransparency . ��6-   �� *	IsChecked+ �� ElementName$ BorderTogglePopup�� � PlacementTarget 6{   �� $ BorderTogglePopup��.��5<      ��  J� Effect 5=      3  -System.Windows.Media.Effects.DropShadowEffect  5>      -   5        DropShadowEffect��   
BlurRadius$ 15Q�5>   I      	Direction$	 -90Q�6Y      RenderingBias$ Quality=�6i      ShadowDepth$ 0Q�6�       Color  6�   �� $	 Color�  electron_blue! �� Source#! [ ._�5@      �� $ Vertical=�6%   .+�5B      �� -   5        " ��Name$" ButtonStatusExecute��5B   %   /   )SiteOrder.db_context.TechnicalTask_status#   	completed
$ � Tag#$ Z# 6c   
������ $��0q�6�   $
 Hand��6�   $ Выполнить��6�   .��5C   "   �� $��Center=�6)   ._�5D   &   F� $��40��5E   )   $��40��5F   )   ����� -1 � � �  -1� z  z � 	=  � � z  z � �  	= � z  z ����  	= `�� q=
ףp@��� ��A ѐ��  �) �P��  |" `�� ��  � �� ׀�  �  ��� ��� � � ��O ��� ��� ׀�O �  ��� ��� �p�x  ϙ Ѡ.c �y� ��ا  $� �@o@��[ �p�*��E ��ا P�� �p�x  ϙ 	#��[ 5H   )   $ Uniform=�5I   )   5J   '   5K   #   5L      �� 5N      -   5        $" ButtonStatusCancel��5N   %   %   canceled#$ Z% 6b   
������ $��0q�6�   $
 Hand��6�   $ Отменить��6�   .��5O   "   �� $��Center=�6)   ._�5P   &   F� $��40��5Q   )   $��40��5R   )   ����� -1 � � �  -1� z  z � 	=  � � z  z � -1 � � z  z � � �� ׀�  �  ��� ��� � � ��O ��� ��� ׀�O �  ��� ��� � � ��  ��� ��� Ѐ�[  z � z ��[ р� $� � $� ��� $� ��[ р� z � z ��р�[  $� � � ��� р��  � � � ��� р��  � 	#��[ 5T   )   $ Uniform=�5U   )   5V   #   5W      5Y      5Z      5[      �� 5]      $��1��6   ��5^      `� 5_      & �� StringFormat$8& 2Дата создания: {0:dd.MM.yyyy HH:mm:ss}��6'   .1�5`      �� $	 createDatetime�6&   5a      5c      5d      �� 5f        MainWindowColor#��[ 6   ' �� Padding$' 20,10q�6C   $
��0,20q�6S   ._�5g      �   5h      ��%p  '��       '�� �     �� 5i      " ��6    .�5j      ��  � ��$ Center=�6B   �� 5k       � ��$ 0,0,20,0q�67   �� 5l       � ��$
 12pt(�69   5m      �� 5n      " ��6    .�5o      ��  � ��$ Center=�6B   �� 5p       � ��$ Stretch=�6D   �� 5q       � ��$	 7,8q�68   �� 5r       � ��$
 12pt(�69   5s      5t       5u      �� 5v      $
��auto �6+   �� 5w       5y      �� 5z      �� 5{      .+�5~      �� $��Название:��6    $��0��61   $��0��6>   �� 5      -   5        ( ��Name$
( name��5   4   $��1��6B   ��6   �� *name+6B   5�      5�      � 5�       5�      �� 5�      $��2* �6'   �� 5�      $��* �6'    5�      �� 5�      $
��Auto �6$   �� 5�      $��200px �6$   .+�5�      �� $'��!Список требований��6   $
��18pt(�65   ) �� Padding$) 30,0,0,0q�6E   �� 5�      $+��%Описание требования��6   $) 0,0,30,0q�67   $��1��6J   * �� TextAlignment$* Right=�6Z   $��Center=�6p   $
��12pt(�6�   �� 5�      -   5        + ��Name$+ 
DemandList��5�   �   $��1��6   $
 Hand��6U   $��Disabled=�6�   #��[ 6�   $��Stretch=�6�   5�      �� 5�      $��1��6   $��1��6,   $��Disabled=�6<   .��5�      �� -   5        , ��Name$, DemandDescription��5�   !   $
��Wrap=�6<   $
��10pt(�6P   $	) 8,7q�6`   $* Justify=�6n   5�      5�      �� 5�      -	   5        $" ButtonAddDemand��5�   3   $+��%Добавить требование��6   6L   � 5�      .+�5�      �� -
   5        $" 
ButtonSave��5�   +   $��0,10,0,0q�6   $��1��6X   $��2��6e   $��Сохранить��6y   $��Center=�6�   $
��Left=�6�   �� 5�      -   5        $" ButtonDelete��5�   +   $��0,10,0,0q�6   $��1��6]   $��2��6j     ButtonDelete#��[ 6~   $��Удалить��6�   $��Center=�6�   $��Right=�6�   5�      5�      5�      5�      