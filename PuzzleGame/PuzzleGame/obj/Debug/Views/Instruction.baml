   M S B A M L   `   `   `  ����E  APuzzleGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:PuzzleGame.ViewsPuzzleGame.Views  5      "    PuzzleGame.Views.Instruction   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      *localclr-namespace:PuzzleGame.Views  5        � 	Resources  5
         btnLoginImgIdle  btnLoginImgHover  btnLoginImgClick��%W   &	        &	      &	 &     �� 5   
   6   �� 5   
   6   �� 5   
   6   5      .��5      � 
�������  5   
    �� 
TargetType  btnLoginStyle �� Property �� Value �� 
TargetType ��Name J� SnapsToDevicePixels �� Triggers P� Property	 P� Value
 �� 
TargetName��%�  &	       �� 5      " ��6   .�5      ��  � ��# �   6/   6[   �� 5       � ��$ 0q�64   6@   �� 5       �@�Cursor$
 Hand��6+   �� 5       � �� 5      �� 5      " ��6*   .R�5      �� $ button1��6%   #��z��66   #��z��6`   #��z��6�   $��60��6�   $��60��6�   ._�5   "   �� #��z��63   #��z��5      #��z��68   # z 5      ��. 6Q   5       5      P� 5   "    �@J�IsMouseOver	 . . �5    &   �� # �  6C    � ���� 5!   &   $
 button1��6I    � ��$ 70��6>   6`   �� 5"   &   $
 button1��6J    � ��$ 70��6?   6a   5#   #   P� 5$   "    � ��	 . . �5%   &   �� # �  6C    � ��5&   #   5(      5*      5+      5,      .+�5.   
   �  � RowDefinitions 5/      �� 50      $��3* �6    6.   �� 51      $��9* �6    6.   ��53      �� 54       �� ImageSource$% /Images/Game1/Round3/board1.png��6   6P   .+�56      �� -   5         ��Name$
 back��56      #��[ 6#   $
��Left=�6J   $	��Top=�6e   7  1MaterialDesignThemes.Wpf.Transitions.Transitioner   MoveFirstCommand#��Z 6}   .��57      �� $&�� /Images/Background/backdoor1.png��6   6D   58      � 59      $��0��6   .+�5;      �� $��35(�6   $��DemiBold"�6*   $��
Constantia)�6@   
�������$��Center=�6o   $��	0 130 0 0q�6�   HƯỚNG DẪN6�   5<      � 5=      $��1��6   .+�5>      �� $��25(�6   $��DemiBold"�6*   $��
Constantia)�6@   
�������$��	130 0 0 0q�6o   Các kí hiệu:6�   �� 5?      $&�� /Images/Background/backdoor1.png��6   $��50��6B   $��50��6M   $��50 50 1100 470q�6Y   6s   �� 5@      $��20(�6   $��DemiBold"�6*   $��
Constantia)�6@   
�������$��190 60 1000 470q�6o   : Quay Lại6�   �� 5A      $��/Images/Game2/muiten1.png��6   $��50��6;   $��50��6F   $��50 100 1100 400q�6R   6m   �� 5B      $��20(�6   $��DemiBold"�6*   $��
Constantia)�6@   
�������$��190 120 1000 400q�6o   
: Qua Màn6�   �� 5C      $#��/Images/Background/close1.png��6   $��50��6?   $��50��6J   $��50 170 1100 350q�6V   6q   �� 5D      $��20(�6   $��DemiBold"�6*   $��
Constantia)�6@   
�������$��190 180 1000 350q�6o   : Thoát Game6�   �� 5E      $��25(�6   $��DemiBold"�6*   $��
Constantia)�6@   
�������$��130 250 0 0q�6o   Cách chơi:6�   5G      5J      5K      5L      