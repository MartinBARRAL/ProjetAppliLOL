   M S B A M L   `   `   `  ����I  EProjetAppliLOL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:ProjetAppliLOLProjetAppliLOL  5      "    ProjetAppliLOL.ChoixTournois   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:ProjetAppliLOL     5        N� Title$  ChoixTournois��5      .��5
      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FF08ABAC��6    � Offset$ 1Q�61   � 5      $ 	#FF00142C��6   5      .+�5   
   �� -   5         ��Name$ Trouvez_Votre_Tournois��5   2   $��0��6   $��0��6"   $��Center=�6R   $
��Wrap=�6o   $	��Top=�6�   $��37��6�   $	��143��6�   ���	#FFFFAA00 � Cursor$
 None��6�   	 �� 
LineHeight$	 16��6�   $��18(�6�   $
��Bold"�6�   $��ROG Fonts v1.6)�6  
 �� TextAlignment$
 Center=�6$  &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�6;  �� 6e  $�Rechercher ��6i  �� 6~  $� ��6�  6�  �� 5   
   -   5         ��Name$ 	textBlock��5   H   $��1��6   $��0��6    $��30��60   $	��300��6<   $
��Left=�6[    �� TextWrapping$
 Wrap=�6w   $��
Nom Equipe��6�   $	��Top=�6�   
�������$��ROG Fonts v1.6)�6�   �� 5   
   -   5        $ textBlock_Copy��5   H   $��2��6   $��0��6    $��30��60   $	��300��6<   $
��Left=�6`   $
 Wrap=�6|   $��Nom Tournois��6�   $	��Top=�6�   
�������$��ROG Fonts v1.6)�6�   �� 5   
   -   5        $! Trouvez_Votre_Tournois_Copy��5   2   $��0��6   $��2��6"   $��Center=�6W   $
��Wrap=�6t   $	��Top=�6�   $��46��6�   $	��143��6�   ���	#FFFFAA00$
 None��6�   $	 16��6�   $��18(�6�   $
��Bold"�6�   $��ROG Fonts v1.6)�6  $
 Center=�6)  $ Display=�6@  �� 6j  $�Tournois��6n  �� 6�  $�	 en cours��6�  6�  �� 5    
   -   5         ��Name$ listBox��5    A   $��1��6   $��2��6   $��2��61   ���	#FFFFAA00���	#FFFFAA00$��ROG Fonts v1.6)�6�   ��6R   Z� .@�5!      �� 5"      �� 5#   
   -   5         ��Name$ button1��5#   0   $��1��6   $��1��6    $��Button��6A   $��30��6R   $��50��6^   $	��Top=�6i   ��5%      �� 5&       J� 	CacheMode 5(      &   System.Windows.Media.BitmapCache  5)       � BindingGroup 5+      &   System.Windows.Data.BindingGroup  5,      5.      �� 5/   
   -   5        $ button2��5/   0   $��2��6   $��1��6    $��Button��6A   $��30��6R   $��60��6^   $	��Top=�6i   ��51      �� 52       54        55       57        58      5:      5;      5<      