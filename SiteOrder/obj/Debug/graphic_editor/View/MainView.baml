   M S B A M L   `   `   `  ����D  @SiteOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:SiteOrder.graphic_editor.ViewModel"SiteOrder.graphic_editor.ViewModel  5   	   U/clr-namespace:SiteOrder.graphic_editor.Controls!SiteOrder.graphic_editor.Controls  5   	   ,    &SiteOrder.graphic_editor.View.MainView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   F	viewModel0clr-namespace:SiteOrder.graphic_editor.ViewModel     5   	   Dcontrols/clr-namespace:SiteOrder.graphic_editor.Controls     5   	     � Title$  Simple graphic editor��5   	   $	��600��6'   $	��800��64    � 	Resources 5      6   0SiteOrder.graphic_editor.ViewModel.MainViewModel   	ViewModel �� 
TargetType  
TitleStyle �� Property �� Value  TitleBorderStyle��%_  &	        &	      &	 �       5   
   6"   �� 5	   
   " ��6   .�5
      ��  � ��$ 5q�6'   �� 5       � ��$ 12(�6)   �� 5       � ��
 �����6+   5      �� 5   
   " ��6   .�5      ��  � ��$ 5q�6'   �� 5       �@��CornerRadius$ 4��6-   �� 5       � ��
 ����6+   5      5      .��5      � $��Stretch=�6E   $��Stretch=�6c    � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      �� 5      $	��260 �6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      .+�5    
   o� $��0��6   $��2��6   $��Stretch=�60   $��30��6N   $	��Top=�6Z   .@�5!      m� $	��New��6   	 m� Command	 6$   �� *
NewCommand+m� 5"      $
��Save��6   	 6%   �� *SaveCommand+m� 5#      $
��Load��6   	 6%   �� *LoadCommand+m� 5$      $��Export to PNG��6   	 6.   �� *ExportCommand+5%      �� 5'   
   $��1��6   $��2��6"   $��0��63   .+�5(   
   �� #��[ 6   ._�5)      �� #��[ 6   $��Canvas��6<   6N   5*      5,      �� 5-   
   $��5q�6   
 �� Padding$
 5q�6   $��2��6)   $��3��66   $��0��6G    �� CornerRadius$ 4��6W   
����ح�$��1q�6�   $��Stretch=�6�   $��Stretch=�6�   ._�5.      3   -SiteOrder.graphic_editor.Controls.DrawControl  $��Stretch=�6�   $��Stretch=�6�      
ActualSize 6#   ��  �� Path$ VisibleSize� �� Mode$ OneWayToSource=�   Scene 6`   �� $ SceneViewModel.Scene�5/      50      �� 52   
   $��1��6   $��1��6   #��[ 6.   ._�53      �� #��[ 6   $��Brush��6<   6M   54      �� 55   
   $��2��6   $��1��6"    62   �� *SceneViewModel+.+�57      3   -SiteOrder.graphic_editor.Controls.ColorPicker  $��5q�6#   $��Stretch=�6.   $��20��6L      SelectedColor 6X   �� $ Color�$ OneWayToSource=�6�   �� 58      $��5q�6    � Maximum$	 100Q�6     � Minimum$ 1Q�6.    � Value 6:   �� *	Thickness+6Y   �� 59      $��Stretch=�6   $ 3��64   $��5q�6E   ��6Q   �� *	Thickness+��6n   �� $ ColorString�$ OneWay=��� 5:      $��4q�6   $��Move layer (brush off)��6@    d� 	IsChecked 6"   �� *	PanMode+6c   5;      �� 5<   
   $��Stretch=�6   $��Stretch=�63   $��3��6P   $��1��6]    �� CanVerticallyScroll . .+�5=      �� #��[ 6   ._�5>      �� #��[ 6   $��Layers��6@   6Q   5?      �� 5@       �� Orientation$ 
Horizontal=�6   .+�5A      �� $	��Add��6   $��5q�6'   ��63   �� $$ SceneViewModel.AddLayerCommand�6m   �� 5B      $��Delete��6   $��5q�6+   ��66   �� $' !SceneViewModel.RemoveLayerCommand�6s   �� 5C      $��Up��6   $��5q�6'   ��62   �� $# SceneViewModel.UpLayerCommand�6k   �� 5D      $
��Down��6   $��5q�6(   ��63   �� $% SceneViewModel.DownLayerCommand�6o   5E      5G      �� 5H   
   $��1��6   $��4��6$   $��0q�61   $��Stretch=�6E    �� SelectionMode$ Single=�6c   $��5q�6z   $��Stretch=�6�    �� SelectedIndex 6�   �� $' !SceneViewModel.SelectedLayerIndex�$ TwoWay=� �� SelectedItem 6�   �� *'%SceneViewModel.SelectedLayerViewModel+$ OneWay=���6<  �� $ SceneViewModel.Layers���5I      �� 5J      .R�5K      �� $ 
Horizontal=�6!   $��5q�6:   .+�5L      �� 
�������$��1q�64   ._�5M      �� $	��img��6r   $
��Left=�6L   $��5q�6g   $��60��6~   $��60��6�   ��6$   �� *Image+$ OneWay=�6�   5N      �� 5O      $��5q�6=   $��Center=�6H   ��6$   �� *Name+ 6d   �� *	IsVisible+6�   5P      5Q      5S      5T      5U      