   M S B A M L   `   `   `  ����E  AGorselVize, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:GorselVize
GorselVize  5   	       GorselVize.Uygulama   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:GorselVize     5   	     � Title$  Uygulama��5   	   $	��450��6   $	��800��6'   .��5	      � 
������� J� OpacityMask 5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FF252526��6   $ 1Q�61   5      .+�5   
   �� 
���   �$��10,4,632,387q�6#   $��28��69   .��6E   Ad:6J   �� 5   
   -   5         ��Name$ txtAd��5      $��10,32,632,359q�6!   $��28��68   $	��150��6D   �� 5   
   
���   �$��10,65,632,321q�6#   .��6:   Soyad:6B   �� 5   
   -   5        $ txtSoyad��5      $��10,98,632,293q�6$   $��28��6;   $	��150��6G   �� 5   
   
���   �$��10,126,625,261q�6#   .��6;   	Cinsiyet:6F   	� 5   
   -   5        $
��btn1��5       	� 	GroupName$ rdBtnCinsiyet��6"   $��10,158,724,228q�6<   .��6U   Erkek6\   	� 5   
   -   5        $
��btn2��5      $ rdBtnCinsiyet��6"   $��73,158,661,228q�6<   .��6U   Kadın6\   �� 5   
   
���   �$��10,191,632,189q�6#    J� RenderTransformOrigin$ 3.294,6.069&�6;   .��6_   Doğum Tarihi:6n   (  "System.Windows.Controls.DatePicker  5   
   -   5        $��10,235,632,150q�5      6-   �� 5   
   
���   �$��10,269,632,116q�6#   .��6;   Öğrenci No:6H   �� 5   
   -   5        $ txtOgrenciNo��5      $��10,303,632,85q�6(   �� 5!   
   
���   �$��10,339,632,44q�6#   $ 3.294,6.069&�6:   .��6^   
Bölüm:6f   �� 5"   
   -   5        $��cmbBolum��5"      $��10,373,632,10q�6#   .@�5#      �� .��6   Adalet6#   �� 5$      .��6   
Anestezi6%   �� 5%      .��6   Bilgisayar Programcılığı65   �� 5&      .��6   Dış Ticaret6(   �� 5'      .��6   
Elektrik6%   �� 5(      .��6   Fizyoterapi6(   �� 5)      .��6   Grafik Tasarımı6,   �� 5*      .��6   İnşaat Teknolojisi6/   �� 5+      .��6   Optisyenlik6(   5,      &   System.Windows.Controls.DataGrid  5.   
   -   5        $��tablo��5.   9   	   MinColumnWidth$	 85Q�6   
   MinRowHeight$
 32Q�6'   $	��247��6F   $��172,10,10,0q�6S   $��0��6h      AutoGenerateColumns .  $	��Top=�6�   ���	#33999999���	#FF252526   Columns 5/      0  *System.Windows.Controls.DataGridTextColumn  50      ,  &System.Windows.Controls.DataGridColumn   Header$ Sıra No��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6O      
FontFamily$ Verdana)�6Y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Sira+6Y     51      $ Ad��6%   $ * 6H   $ Verdana)�6R    61   �� *Ad+6R     52      $ Soyad��6%   $ * 6N   $ Verdana)�6X    64   �� *Soyad+6X     53      $ Cinsiyet��6%   $ * 6T   $ Verdana)�6^    67   �� *
Cinsiyet+6^     54      $ Doğum Tarihi��6%   $ * 6U   $ Verdana)�6_    6;   �� *Tarih+6_     55      $ Öğrenci No��6%   $ * 6W   $ Verdana)�6a    69   �� *	OgrenciNo+6a     56      $ Bölüm��6%   $ * 6N   $ Verdana)�6X    64   �� *Bolum+6X   58      �� 5:   
   -	   5        $��btnEkle��5:      $��20(�6    $
��Ekle��6.   $��192,347,450,9q�6=   $��Century)�6j   $ 2.168,0.183&�6   �� 5;   
   -
   5        $��btnMenu��5;      $��20(�6    $��	Ana Menü��6.   $��632,367,10,10q�6A   $��Century)�6n   �� 5=   
   
���   �$��15(�6#   $��477,269,165,110q�61   $��Satır Bilgisi Sorgula:��6J   �� 5>   
   -   5        $��cmbBilgi��5>      $��632,269,10,110q�6#   5?      �� 5@   
   -   5         ��Name$ 
labelUyari��5@      $�� ��6$   $
��Left=�6/   $��172,269,0,0q�6J   $	��Top=�6_   $	��300��6w   $��40��6�   
���  ��6�   5A      5B      