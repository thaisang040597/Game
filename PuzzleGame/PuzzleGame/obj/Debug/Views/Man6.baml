   M S B A M L   `   `   `  ����E  APuzzleGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PuzzleGame.ViewsPuzzleGame.Views  5          PuzzleGame.Views.Man6   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      J FXamlAnimatedGif, Version=1.2.2.0, Culture=neutral, PublicKeyToken=null<gif2https://github.com/XamlAnimatedGif/XamlAnimatedGif  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      :d2http://schemas.microsoft.com/expression/blend/2008  5      *localclr-namespace:PuzzleGame.Views  5        � 	Resources  5
         btnLoginImgIdle��%   &	        �� 5   
   6   5       � Triggers 5      .��5      � 
�������  5   
    �� 
TargetType  btnLoginStyle �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers	 P� Property
 P� Value  btnLoginImgHover �� 
TargetName  btnLoginImgClick��%�  &	       �� 5      " ��6   .�5      ��  � ��# �   6/   6]   �� 5       � ��$ 0q�64   6@   �� 5       �@�Cursor$
 Hand��6+   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� $ button1��6%   #��z��66   #��z��6`   #��z��6�   $��60��6�   $��60��6�   ._�5   "   �� #��z��63   #��z��5   3   #��z��6V   # z 5   3   ��. 6o   5       5       P� 5!   "   	 �@J�IsMouseOver
 . . �5"   &   �� # �  6C    � ���� 5#   &   $ button1��6I    � ��$ 70��6>   6`   �� 5$   &   $ button1��6J    � ��$ 70��6?   6a   5%   #   P� 5&   "   	 � ��
 . . �5'   &   �� # �  6C    � ��5(   #   5*      5,      5-      5/      .+�50   
   �� -   5         ��Name$
 back��50      #��[ 6   $
��Left=�6F   $	��Top=�6a   .��51      �� $&�� /Images/Background/backdoor1.png��6   6@   52      �� 53   
   -   5         ��Name$ Canvas1��53      .+�54      �� $	��250��6   $	��200��6     �� Left$ 50��6-   
 �� Top$	 300��6>   $)��#/Images/Game1/Round5/barbersHop.png��6O   6~   �� 55      $	��350��6   $	��350��6    $	 308��6-   $	 235��6?   $*��$/Images/Game1/Round6/supermarket.png��6P   57      �� 58      $	��250��6   $	��210��6    $	 730��6-   $	 320��6?   $)��#/Images/Game1/Round6/coffeesHop.png��6P   6   �� 59      $	��300��6   $	��300��6    $
 1060��6-   $	 200��6@   $#��/Images/Game1/Round6/bank.png��6Q   6z   � 5:      $
��1366��6   $	��100��6    $	 490��6-   ��5;      �� 5<       �� ImageSource$' !/Images/Game1/Round5/pavement.png��6!   6V   5?      � 5@      $
��1446��6   $	��270��6    $	 570��6-   $	 -40��6>   ��5A      �� 5B      $# /Images/Game1/Round5/road.png��6!   6R   5E      �� 5F      $	��200��6   $	��250��6    $	 340��6-   $	 550��6>   $#��/Images/Game1/Round5/tree.png��6P   6z   �� 5G      $	��250��6   $	��250��6    $	 380��6-   $	 250��6>   $&�� /Images/Game1/Round5/busstop.png��6P   6}   �� 5H      $	��200��6   $	��250��6    $	 340��6-   $	 -20��6>   $#��/Images/Game1/Round5/tree.png��6P   6y   �� 5I      $	��200��6   $	��250��6    $	 340��6-   $	 950��6>   $#��/Images/Game1/Round5/tree.png��6P   6z   �� 5J      -   5         ��Name$ xebuyt��5J      $	��350��6%   $	��200��61   $	 480��6>   $ 0��6O   $#��/Images/Game1/Round6/bus2.png��6_   6�   �� 5K      -   5        $ xekem��5K      $	��350��6#   $	��180��6/   $	 580��6<   $	 100��6M   $)��#/Images/Game1/Round6/Layer kem1.png��6_   6�   �� 5L      -   5        $ xepolice��5L      $	��250��6&   $	��180��62   $	 620��6?   $	 900��6P   $+��%/Images/Game1/Round6/Layer police.png��6b   6�   �� 5M      -   5        $ 	xeferarri��5M      $	��250��6'   $	��180��63   $	 530��6@   $	 500��6Q   $)��#/Images/Game1/Round6/Layer2 car.png��6c   6�   �� 5N      -   5        $ xetoyota��5N      $	��250��6&   $	��180��62   $	 520��6?   $
 1100��6P   $&�� /Images/Game1/Round6/Layer 1.png��6c   6�   �� 5O      -   5        $ xebus��5O      $	��350��6#   $	��200��6/   $#��/Images/Game1/Round5/bus1.png��5P   ]    6   �� *XPositionBus+ 69   �� *YPositionBus+6�   �� 5Q      -	   5        $ 	xecanhsat��5Q      $	��250��6'   $	��180��63   $(��"/Images/Game1/Round6/policecar.png��5R   i    6   �� *XPositionPoliceCar+ 6?   �� *YPositionPoliceCar+6�   �� 5S      -
   5        $ sieuxe��5S      $	��250��6$   $	��180��60   $&�� /Images/Game1/Round6/ferarri.png��5T   e    6   �� *XPositionFerarri+ 6=   �� *YPositionFerarri+6�   �� 5U      -   5        $ xe4cho��5U      $	��250��6$   $	��180��60   $%��/Images/Game1/Round6/toyota.png��5V   c    6   �� *XPositionToyota+ 6<   �� *YPositionToyota+6�   �� 5W      -   5        $ 	xekemlanh��5W      $	��350��6'   $	��180��63   $$��/Images/Game1/Round6/xekem.png��5X   ]    6   �� *XPositionKem+ 69   �� *YPositionKem+6�   5Y      � 5_   
   -   5         �Name$ report��5_   <   $	��250��6   $	��250��6   $y�Hidden=�6(    � RowDefinitions 5`      �� 5a      $��7* �6    6.   �� 5b      $��3* �6    6.   .+�5d      �� -   5        $ 
boderstart��5e   T   $��2��5d       �� CornerRadius$ 15��6&    �� Padding$ 2q�68   $	��250��6E   $	��250��6Q    J� RenderTransformOrigin$ 0.844,0.439&�6^   $��Center=�5e      $��Center=�6,   $��0q�6I    J� Opacity$	 0.9Q�6i   ��5f      �� 5g       �� 
StartPoint$	 0,0&�6*    �� EndPoint$	 0,1&�6;   .��5h      �  � Color$ Bisque��6'    � Offset$ 0Q�66   � 5i      $ Orange��6'   $
 0.95Q�66   5j      5n      � 5o      $��0��6   .+�5p      �� '  !XamlAnimatedGif.AnimationBehavior   	SourceUri$ /Images/Gif/icon.gif?�6   6T   5q      � 5r      $��1��6    � ColumnDefinitions 5s      �� 5t      6)   �� 5u      6)   .+�5w      �� -   5        $ Continue��5w      $��0��6,    � Cursor$
 Hand��6<   $��90��6K   $��40��6V   
������ ���#339999
��� ���$��15(�6�   $��Qua Màn��5x      $
��Bold"�6'     5y      ��%^   '��       �� 5z      " ��6    .�5{      ��  �@��CornerRadius$ 5��6=   5}      5~      5      �� 5�      -   5        $ Replay��5�      $��1��6*   $
 Hand��6:   $��90��6I   $��40��6T   
������ ���#339999
��� ���$��15(�6�   $��Chơi Lại��5�      $
��Bold"�6(     5�      ��%^   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 5��6=   5�      5�      5�      5�      5�      � 5�   
   -   5        $ timeout��5�   (   $	��250��6   $	��250��6   $y�	Collapsed=�6:    5�      �� 5�      $��7* �6    6.   �� 5�      $��3* �6    6.   .+�5�      �� -   5        $ bodertimeout��5�   T   $��2��5�      $ 15��6&   $ 2q�68   $	��250��6E   $	��250��6Q   $ 0.844,0.439&�6^   $��Center=�5�      $��Center=�6,   $��0q�6I   $	 0.9Q�6k   ��5�      �� 5�      $	 0,0&�6*   $	 0,1&�6;   .��5�      � $ Bisque��6'   $ 0Q�66   � 5�      $ Orange��6'   $
 0.95Q�66   5�      5�      � 5�      $��0��6   .+�5�      �� $��
10 30 10 0q�6   $$��/Images/Background/timeout.png��6,   6Y   5�      � 5�      $��1��6    5�      �� 5�      6)   �� 5�      6)   .+�5�      �� -   5        $ 	Continue1��5�      $��0��6-   $
 Hand��6=   $��90��6L   $��40��6W   
������ ���#339999
��� ���$��15(�6�   $��Qua Màn��5�      $
��Bold"�6'     5�      ��%^   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 5��6=   5�      5�      5�      �� 5�      -   5        $ Replay1��5�      $��1��6+   $
 Hand��6;   $��90��6J   $��40��6U   
������ ���#339999
��� ���$��15(�6�   $��Chơi Lại��5�      $
��Bold"�6(     5�      ��%^   '��       �� 5�      " ��6    .�5�      ��  �@��CornerRadius$ 5��6=   5�      5�      5�      5�      5�      5�      5�      