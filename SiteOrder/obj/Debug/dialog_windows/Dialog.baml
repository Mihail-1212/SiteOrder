   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:SiteOrder.dialog_windowsSiteOrder.dialog_windows  5   	   9!clr-namespace:SiteOrder.templatesSiteOrder.templates  5   	   ;"clr-namespace:SiteOrder.PropertiesSiteOrder.Properties  5   	   %    SiteOrder.dialog_windows.Dialog   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:SiteOrder.dialog_windows     5   	   7	templates!clr-namespace:SiteOrder.templates     5   	   3resx"clr-namespace:SiteOrder.Properties     5   	   &    SiteOrder.templates.CustomWindow    ContentRendered$"  CustomWindow_ContentRendered��5	   	      Closing$ CustomWindow_Closing��5
         DialogWindow#��[  5   	   $	��250��5      $	��450��6'    � 	Resources 5       �� MergedDictionaries �� Source �� 
TargetType  ButtonPopup �� BasedOn �� 	Resources  Key �� Color	 �� Property
 �� Value  electron_blue �� 
TargetType ��Name �� CornerRadius J� SnapsToDevicePixels ��Name �� Triggers P� Property P� Value  electron_blue_hover  Button.IsEnabled.False�� 5   
    5      �� 5      $. (/styles/IelementsResourceDictionary.xaml?�6%   %�  '��       7  7  7  7  7  �� 5      " ��6   8    5      ���� 5      Button.IsEnabled.False $ 	#FFADADAD��6E   5      .�5      �� 	 � ��$

 70px��6*   �� 5      	 � ��$	
 6pxq�6,   �� 5      	 � ��$
 DemiBold"�6/   �� 5      	 � ��$
 Bottom=�66   �� 5      	 � ��
 �#fff6/   �� 5      	 � ��8
  6/   �� 5      	 � ��
 5      �� 5      " ��6*   .R�5       �� $ border��66   $ 5��6%   #��z��6F   #��z��6r   #��z��6�    . ._�5!   "   �� $ contentPresenter��63   |�.  #��z��6_   #��z��6�   ��. # z 6�   #��z��6  5"       5#      P� 5$   "    �@J�IsMouseOver . . �5%   &   �� 8
  	 � ��6C   5&   #   P� 5'   "    � �� . . �5(   &   �� 8
  	 � ��6C   5)   #   P� 5*   "    � {� .  . �5+   &   �� 8
  	 � ��6C   5,   #   5.      50      51      52      .��55      � $��20,10q�6    � ColumnDefinitions 56   
   �� 57      �� 58       � RowDefinitions 5:   
   �� 5;      $
��auto �6   �� 5<      $��* �6   �� 5=      $
��auto �6   .+�5?   
   �� $
��14pt(�6   $��2��6$    �� TextAlignment$
 Left=�6�   $��Center=�6�   $
��5,10q�6�   ��68   �� *	Message+ �� RelativeSource �� *FindAncestor+ �� AncestorType" �6�   �� 5@   
   -   5         ��Name$ 	txtAnswer��5@      $��1��6%   $	��4,7q�62   $��2��6@   $	��0,7q�6T   $��Center=�6a   �� 5A   
   -   5         ��Name$ ButtonOk��5A   V   $
��ОК��6   $��2��6   $��1��6+   $
��Left=�6;   6h   �� 5B   
   -   5        $ ButtonCancel��5B   [   $��Отмена��6   $��2��6"   $��1��6/   $��Right=�6?   6q   5C      5D      