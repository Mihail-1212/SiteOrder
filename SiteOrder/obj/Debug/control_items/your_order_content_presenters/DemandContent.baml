   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null}Cclr-namespace:SiteOrder.control_items.your_order_content_presenters5SiteOrder.control_items.your_order_content_presenters  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5	      I    CSiteOrder.control_items.your_order_content_presenters.DemandContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      UlocalCclr-namespace:SiteOrder.control_items.your_order_content_presenters     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5      9
db_context"clr-namespace:SiteOrder.db_context     5      9
converters"clr-namespace:SiteOrder.converters     5	        � 	Resources  5       �� MergedDictionaries �� Source-   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter �� 
TargetType  NoteTextBlock �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource	 �� Path
 �� Value �� Property �� Value  	ListStyle�� 5   
    5      �� 5      $. (/styles/IelementsResourceDictionary.xaml?�6%   %Q  &	        &	      &	 &     7��&	 �     7��  5      6,     5      6-   �� 5      " ��6   8    5      �� 5       6"   �� # Z $	 Text.Length�
 06v   .a�5      ��  � ��$/ )Примечания не указаны!��61   5      5      �� 5      " ��6   8    5      �� 5       6"   �� # Z $	 Items.Count�
 06v   .a�5      ��  � �� 5       �� 5!   "   .R�5"   &   �� $
��12pt(�60   HFУ данного требования не указаны сайты!6i   5#   #   5%      5&      5(      5)      .��5+      �� .��5,   
   ��  �� Orientation$ Vertical=�6   $��10,15q�6,   .+�5-      �  � RowDefinitions 5.      �� 5/      �� 50      $
��auto �6$    � ColumnDefinitions 52      �� 53      �� 54      $
��auto �6'   .+�57      �� $+��%Просмотр требования��6   $
��18pt(�68   58      �� 5:        MainWindowColor#��[ 6    �� Padding$ 20,10q�6C   $
��0,20q�6S   ._�5;      �   5<      ��%�  '��       '�� �     �� 5=      " ��6    .�5>      ��  � ��$ Center=�6B   �� 5?       � ��$ 	0,0,20,10q�67   �� 5@       � ��$
 12pt(�69   5B      �� 5C      " ��6    .�5D      ��  � ��$ Center=�6B   �� 5E       � ��$ Stretch=�6D   �� 5F       � ��$ 0,0,0,10q�67   �� 5G       � ��$	 7,8q�68   �� 5H       � ��$
 12pt(�69   5I      5J       5K      �� 5L      $
��auto �6+   �� 5M       5O      �� 5P      �� 5Q      .+�5T      �� $��Название:��6    $��0��61   $��0��6>   �� 5U      -   5         ��Name$
 name��5U   6   $��1��6D   ��6    �� *name+6D   �� 5W      $��Описание:��6    $��1��61   $��0��6>   �� 5X      -   5        $
 text��5X   6   $��1��6D   $��1��6Q   ��6    �� *text+6Q   5Y      5Z      � 5\       5]      �� 5^      $��2* �6'    5`      �� 5a      $
��auto �6$   �� 5b      $��200px �6$   .+�5e      �� $2��,Список примерных сайтов��6   $
��18pt(�6;    �� Padding$ 30,0,0,0q�6K   �� 5h      -   5         ��Name$ SampleSitesList��5h   i    � Cursor$
 Hand��6   $��1��6\   $��Stretch=�6�   $��Disabled=�6�   #��[ 6�   $��Stretch=�6   ��5i      �� 5j      .R�5k      � $	��0,5q�6#   #��[ 60   $
 Hand��6^   $��80��6l    5l   "   �� 5m   &   $
��auto �64   �� 5n   &   $
��auto �64    5p   "   �� 5q   &   $��* �67   �� 5r   &   $
��auto �67   .+�5t   "   �� $��16(�6,   $
��Left=�6^   $
��Bold"�6y   $��Center=�6�   ��6:   �� *SampleSite.siteURL+6�   �� 5u   "   $
��10pt(�6,   $��7,8,7,0q�6R   $��Stretch=�6c    �� TextAlignment$ Justify=�6�   $��Center=�6�   $
��Wrap=�6�   $��2��6�   $��1��6�   ��6<   �� *note+6�   5v      5x      5z      5�      5�      5�      5�      