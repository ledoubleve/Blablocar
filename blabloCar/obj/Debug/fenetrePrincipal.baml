   M S B A M L   `   `   `  ����D  @blabloCar, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:blabloCar	blabloCar  5   	        blabloCar.fenetrePrincipal   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:blabloCar     5   	     � Title$  	BlabloCar��5   	   $	��500��6   $	��900��6(    � 	Resources 5
         listeVilleDepart  listeTrajet �� Orientation �� UpdateSourceTrigger �� Mode��%Z  &	        &	 i     �� 5   
   .R�5      �� $
��Auto��63   $
��Auto��6@   ��6   �� *	nom_Ville+6@   5      �� 5   
   .R�5      �� $ 
Horizontal=�6   .+�5      �� $��
Départ : ��6   $
��auto��6-   $
��auto��6:   �� 5      ��6   �� *heureDepart+$ PropertyChanged=�$ TwoWay=�5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��480 �6   .+�5    
   �� $��2��6   ���	#FFE5E2E2.@�5!      �� $��Trajet��6   .��5"      �  � ColumnDefinitions 5#      �� 5$      $	��600 �6+   �� 5%      $	��300 �6+   .+�5'      �� -   5         ��Name$ listeTrajet��5'      $��0��63   ���	#FFBEB4B4#��[ 6�   ��6�   �� $ Default=��� 5)      $ Vertical=�6!   $	��Top=�68   $��0,20,0,0q�6P   $��Center=�6b   $��1��6   .+�5*      �� $��Ville de départ��6$   $	��150��6;    �� TextAlignment$ Center=�6G   �� 5+      -   5        	 ��Name$	 VilleDepart��5+   #   $	��100��68   $��0,0,0,15q�6D   #��[  6V   ��6�   �� �� 5,      $��Ville d'arrivée��6$   $	��150��6;   $ Center=�6G   �� 5-      -   5        $	 VilleArrivee��5-   #   $	��100��69   $��0,0,0,40q�6E   #��[  6W   ��6�   �� �� 5.      -   5        
 ��Name$
 rechercheTrajet��5.   B   $��
Rechercher��6!   $	��100��66   6[   �� 51      -   5         ��Name$ detailTrajet��51   #   $��Détail du trajet��69   $��0,50,0,0q�6S   $	��250��6e   $	��210��6q   ���	#FF26292B���	#FFF5F2F2.��52      �� $ 
Horizontal=�6)   $��0,10,0,0q�6B   .+�53   "   �� $��
Départ : ��6,   $
��auto��6=   $
��auto��6J   �� 54   "   -   5         ��Name$ villeDep��54   ,   $
��auto��6>   $
��auto��6K   $��5,0,0,0q�6Y   55      58      5:      5;      5<      �� 5=      $��Compte��6   5?      5@      5B      5C      