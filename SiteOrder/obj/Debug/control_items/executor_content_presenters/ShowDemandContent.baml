   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullyAclr-namespace:SiteOrder.control_items.executor_content_presenters3SiteOrder.control_items.executor_content_presenters  5      ;"clr-namespace:SiteOrder.db_contextSiteOrder.db_context  5      M+clr-namespace:SiteOrder.overridden_controlsSiteOrder.overridden_controls  5      ;"clr-namespace:SiteOrder.convertersSiteOrder.converters  5	      K    ESiteOrder.control_items.executor_content_presenters.ShowDemandContent   5   "   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      SlocalAclr-namespace:SiteOrder.control_items.executor_content_presenters     5      9
db_context"clr-namespace:SiteOrder.db_context     5      B
overridden+clr-namespace:SiteOrder.overridden_controls     5      9
converters"clr-namespace:SiteOrder.converters     5	        � 	Resources  5       �� MergedDictionaries-   'SiteOrder.converters.StatusSvgConverter   StatusSvgConverter.  (SiteOrder.converters.StatusTextConverter  StatusTextConverter �� 
TargetType  	ListStyle �� BasedOn �� Triggers �� Binding �� Self �� RelativeSource �� Path	 �� Value
 �� Property �� Value�� 5   
    5      %�  &	        &	      &	 &     7��  5      6,     5      6-   �� 5      " ��6   8    5      �� 5       6"   �� # Z $ Items.Count�	 06v   .a�5      �� 
 � �� 5      �� 5   "   .R�5   &   �� $
��12pt(�60   OMУ данного требования нет примерных сайтов6l   5   #   5      5      5      5       .��5#      �� .��5$   
   � $��10,15q�6    � RowDefinitions 5&      �� 5'      $
��auto �6    �� 5(      $
��auto �6    �� 5)      .+�5,      �  5-      �� 5.      �� 5/      $
��auto �6$    � ColumnDefinitions 51      �� 52      �� 53      $
��auto �6'   .+�56      �� $+��%Просмотр требования��6   $
��18pt(�68   57      �� 59        MainWindowColor#��[ 6   $��1��6C    �� Padding$ 20,10q�6P   $
��0,20q�6`   ._�5:      �   5;      ��%�  '��       '�� �     �� 5<      " ��6    .�5=      �� 
 � ��$ Center=�6B   �� 5>      
 � ��$ 	0,0,20,10q�67   �� 5?      
 � ��$
 12pt(�69   5A      �� 5B      " ��6    .�5C      �� 
 � ��$ Center=�6B   �� 5D      
 � ��$ Stretch=�6D   �� 5E      
 � ��$ 0,0,0,10q�67   �� 5F      
 � ��$	 7,8q�68   �� 5G      
 � ��$
 12pt(�69   5H      5I       5J      �� 5K      $
��auto �6+   �� 5L       5N      �� 5O      �� 5P      .+�5S      �� $��Название:��6    $��0��61   $��0��6>   �� 5T      -   5         ��Name$
 name��5T   6   $��1��6D   ��6    �� *name+6D   �� 5V      $��Описание:��6    $��1��61   $��0��6>   �� 5W      -   5        $
 text��5W   6   $��1��6D   $��1��6Q   ��6    �� *text+6Q   5X      5Y      � 5[      $��2��6    5\      �� 5]      $��2* �6'    5_      �� 5`      $
��auto �6$   �� 5a      $��200px �6$   .+�5d      �� $2��,Список примерных сайтов��6   $
��18pt(�6;    �� Padding$ 30,0,0,0q�6K   �� 5g      -   5         ��Name$ SampleSitesList��5g   '   $��1��6    � Cursor$
 Hand��6@   $��Stretch=�6�   $��Disabled=�6�   #��[ 6  $��Stretch=�6)  ��6�   �� *SampleSitesGroup+��5h      �� 5i      .R�5j      � $	��0,5q�6#   #��[ 60   $��Stretch=�6^   $
 Hand��6|   $��80��6�    5k   "   �� 5l   &   $
��auto �64   �� 5m   &   $
��auto �64    5o   "   �� 5p   &   $��* �67   �� 5q   &   $
��auto �67   .+�5s   "   �� $��16(�6,   $
��Left=�6^   $
��Bold"�6y   $��Center=�6�   ��6:   �� *SampleSite.siteURL+6�   �� 5t   "   $
��10pt(�6,   $��7,8,7,0q�6R   $��Stretch=�6c    �� TextAlignment$ Justify=�6�   $��Center=�6�   $
��Wrap=�6�   $��2��6�   $��1��6�   ��6<   �� *note+6�   5u      5v      5x      5y      5|      5}      5~      