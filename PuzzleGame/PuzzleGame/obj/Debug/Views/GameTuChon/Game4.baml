   M S B A M L   `   `   `  ����E  APuzzleGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:PuzzleGame.Views.GameTuChonPuzzleGame.Views.GameTuChon  5      '    !PuzzleGame.Views.GameTuChon.Game4   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:PuzzleGame.Views.GameTuChon     5        � 	Resources  5	         masterImage �� 	UriSource  croppedImage �� Source �� 
SourceRect��%}   &	        &	 7     7   �� 5   
   $# /Images/Game1/Round1/gau2.png?�6*   �� 5   
   8   $ 0 0 500 500��5   -   5      .��5      �   5   
   3  -System.Windows.Media.Effects.DropShadowEffect  z-depth5   
BlurRadius   ShadowDepth   	Direction   Color �� 
TargetType  btnLoginStyle	 �� Property  btnLoginImgIdle
 �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property P� Value  btnLoginImgHover �� 
TargetName  btnLoginImgClick��%8  &	       &	 L       5      $ 35Q�60   $ 15Q�6@   $	 270Q�6Q   $ #BBBBBB��6a   �� 5      " ��6   .�5      �� 	 � ��#
 �  6/   6[   �� 5      	 � ��$
 0q�64   6@   �� 5      	 �@�Cursor$

 Hand��6+   �� 5      	 � ��
 5      �� 5      " ��6*   .R�5      �� $ button1��6%   #��z��66   #��z��6`   #��z��6�   $	��130��6�   $��45��6�   ._�5   "   �� #��z��63   #��z��5      #��z��68   # z 5      ��. 6Q   5       5      P� 5    "    �@J�IsMouseOver . . �5!   &   �� #
 �  6C   	 � ���� 5"   &   $ button1��6J   	 � ��$	
 125��6>   6a   �� 5#   &   $ button1��6J   	 � ��$
 45��6?   6a   5$   #   P� 5%   "    � �� . . �5&   &   �� #
 �  6C   	 � ��5'   #   5)      5+      5,      5-      .+�5.   
   �� $$��/Images/Game2/Round2.1/img.jpg��6   6:   �� 5/   
   -   5         ��Name$
 back��5/      #��[ 6   $	��Top=�6Y   $
��Left=�6q   .��50      �� $&�� /Images/Background/backdoor1.png��6   6@   51      �� 52   
   .+�53      � $��10q�6   $��Center=�6$   .+�54      �� -   5        $��btnLoadFromFile��54      $��0,0,20,0q�60   .��6`   Load from File...6s   56      �� 58      -   5         ��Name$	 abc��58      $	��500��6!   $	��500��6-   ��59      �� 5:      -   5        anh��$# /Images/Game1/Round1/gau2.png��5:   1   $ 0,0,150,150��6X   6s   5<      �� 5=      -   5        $
 abcd��5=      $	��500��6"   $	��500��6.   ��5>      �� 5?      -   5        anh1��$# /Images/Game1/Round1/gau2.png��5?   2   $ 0,0,150,150��6Y   6t   5A      5B      5C      5D      