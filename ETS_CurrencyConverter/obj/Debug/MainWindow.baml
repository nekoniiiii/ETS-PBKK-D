   M S B A M L   `   `   `  ����P  LETS_CurrencyConverter, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:ETS_CurrencyConverterETS_CurrencyConverter  5   	   &     ETS_CurrencyConverter.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:ETS_CurrencyConverter     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ���	#FFBAE058.+�5
   
   �� -   5         ��Name$ 	comboBox1��5
      $
��Left=�6&   $��243,136,0,0q�6A   $	��Top=�6V   $��90��6n   $��20(�6�   .@�5      �� -   5         ��Name$ comboBoxItem1��5      $	��USD��62   �� 5      $	��EUR��6   �� 5      $	��IDR��6   �� 5      $	��JPY��6   �� 5      $	��MYR��6   5      �� 5   
   -   5         ��Name$ button1��5      $��	Convert
��6"   $��Center=�6>   $��	0,280,0,0q�6[   $	��Top=�6n   $��22(�6�   $��38��6�   $	��102��6�   6�   �� 5   
   -   5        $ 	comboBox2��5      $
��Left=�6&   $��515,135,0,0q�6A   $	��Top=�6V   $��90��6n   $��20(�6�   .@�5      �� -   5        $ comboBoxItem2��5      $	��USD��62   �� 5      $	��EUR��6   �� 5      $	��IDR��6   �� 5      $	��JPY��6   �� 5      $	��MYR��6   5      �� 5   
   $��Currency Converter
��6   $��Center=�67   $��0,33,0,0q�6T   $	��Top=�6f   $��36(�6~   $��Segoe UI Semibold)�6�   $
��Bold"�6�   �� 5   
   $��From
��6   $
��Left=�6$   $��145,132,0,0q�6?   $	��Top=�6T   $��22(�6l   �� 5   
   $��Amount
��6   $
��Left=�6+   $��145,184,0,0q�6F   $	��Top=�6[   $��22(�6s   �� 5   
   $	��To
��6   $
��Left=�6"   $��429,131,0,0q�6=   $	��Top=�6R   $��22(�6j   �� 5   
   $��Result��6   $
��Left=�6!   $��429,184,0,0q�6<   $	��Top=�6Q   $��22(�6i   �� 5   
   -   5         ��Name$ textBox1��5      $
��Left=�6$   $��243,189,0,0q�6?    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   $��20(�6�   6�   �� 5   
   -   5        $ textBox2��5      $
��Left=�6$   $��515,188,0,0q�6?   $
 Wrap=�6T   $	��Top=�6h   $	��120��6�   $��20(�6�   6�   �� 5    
   $
��Left=�6   $	��137��6+   $��635,280,0,0q�68   $	��Top=�6M   $	��144��6e    J� OpacityMask 5!      �� 5"       �� ImageSource$ /icons-currency-trade.png��6    j� Stretch$ Uniform=�6E   5$      �� 5%   
   $
��Left=�6   $	��161��6+   $��603,252,0,0q�68   $	��Top=�6M   $	��173��6e   $��/icons-currency-trade.png��6q   5&      5'      