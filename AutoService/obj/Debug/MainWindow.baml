   M S B A M L   `   `   `  ����F  BAutoService, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AutoServiceAutoService  5   	       AutoService.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AutoService     5   	     � Title$  
MainWindow��5   	   $	��600��6   $
��1000��6)    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � WindowStyle$
 None=�6q    � 	Resources 5	       �� MergedDictionaries �� Source�� 5
   
    5      �� 5      $ ResourceDictionary.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   6*   �� 5      6   .+�5   
    � -   5        $��	MainFrame��5      ���#f5f5f5$��1��66     � NavigationUIVisibility$ Hidden=�6C   6e   �� 5   
   	 �� Orientation$	 
Horizontal=�6   ���#735184.+�5      �� -   5        $��	ToMainBtn��5      ���#ccccff$	��135��6;   $��
10,10,0,10q�6G   $��На главную��6[   $4��./AutoService;component/Fonts/#PerfectDOSVGA437)�6p   $��18(�6�   6�   �� 5      -   5        $��ExitBtn��5      ���#ccccff$	��135��69   $��
10,10,0,10q�6E   $��Вход��6Z   $4��./AutoService;component/Fonts/#PerfectDOSVGA437)�6i   $��18(�6�   6�   �� 5      -   5        
 ��Name$
 ExitImg��5      $��Images/cross.png��6%   $��650,10,11,12q�6?   $��51��6�   ��5      �� 5       �� 
TargetType" ��6   .�5      ��  �� Property � �� �� Value$ Images/cross.png��63    �� Triggers 5      �� 5       �� Binding 6*   �� *IsMouseOver+ �� ElementName$ CloseBtn�� �� Value true6`   .a�5   "   ��  � ��$ Images/cross.png��6;   5       5"       J� Effect 5$      -  'System.Windows.Media.Effects.BlurEffect  5%         Radius$ 1Q�6!   5'      5(      5)      5*      