   M S B A M L   `   `   `  ����@  <mebel, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:mebelmebel  5   	       mebel.Win_Mebel   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:mebel     5   	     � Title$  	Win_Mebel��5   	   $	��450��6   $	��600��6(    � 
ResizeMode$ CanMinimize=�64    � WindowStartupLocation$ CenterScreen=�6M   .��5	      � ���	#FFA08D8D$��0,0,0,-6q�6"    � RowDefinitions 5
   
   �� 5      $��90 �6   �� 5      $	��270 �6   �� 5      $��90 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGrid��5      ���	#FFA08D8D   AutoGenerateColumns$ False��6:      
IsReadOnly$
 True��6V   $��0,64,0,0q�6�   $��2��6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$	 №��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 35 6M   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 60   �� *
id_mebel+6Z     5      $ Артикул��6%   $	 * 6R   
 66   �� *	artikul+6^     5      $ Название��6%   $	 * 6P   
 67   �� *name+6\     5      $ Количество��6%   $	 * 6Y   
 69   �� *kolichestvo+6e   4  .System.Windows.Controls.DataGridTemplateColumn  5      $
	 auto 6)      CellTemplate 5      �� 5      .R�5      �� $��
btn_redact��6=   -   5        $ ��Редактировать��5   %   6g   5      5      5!      �� 5"   
   -   5        $��Добавить��5"      $
��Left=�67   $��35,6,0,0q�6R   $��2��6d   $	��Top=�6q   $��39��6�   $	��130��6�   ���	#FFA08D8D���	#FFFCFCFC$%��Bahnschrift Light SemiCondensed)�6�   $��20(�6�   �� 5#   
   -   5        $��Удалить��5#      $
��Left=�69   $��	411,6,0,0q�6T   $��2��6g   $	��Top=�6t   $��38��6�   $	��135��6�   ���	#FFA08D8D
�������$%��Bahnschrift Light SemiCondensed)�6�   $��20(�6�   �� 5$   
   $��Center=�6   $��Berlin Sans FB)�61   $��22(�6M   $��0,10,0,0q�6[   $
��Wrap=�6m   $!��Каталог мебели��6�   $	��Top=�6�   $��35��6�   $	��170��6�   �� 5%   
   -   5         ��Name$ 
strelochka��5%      $	��→��6   $
��Left=�61   ���	#FFA08D8D$��24(�6d   $��
518,10,0,0q�6r   $	��Top=�6�   $��40��6�   $��56��6�   ���	#FFEFECEC6�   5'      5(      