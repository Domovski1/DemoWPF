   M S B A M L   `   `   `  ����B  >DemoWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DemoWPF.Views.PagesDemoWPF.Views.Pages  5      )    #DemoWPF.Views.Pages.ServiceListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:DemoWPF.Views.Pages     5        N� Title$  Список услуг��5
      .��5      �  � RowDefinitions 5   
   �� 5      $
��0.1* �6   �� 5      $
��0.9* �6   .+�5   
   �� -   5        $��20��5      $	��100��5      $��Right=�5      $	��Top=�5      $��5q�5      $
��0000��5      5      �� 5   
   -   5        $��ProductListView��5      $��1��5      ��5!      �� *
products+��5"      �� 5#      .R�5$      �� 
���  �� �� Orientation$ 
Horizontal=�5&      .+�5'      �� $	��120��5(      $	��120��5)      �� 5+      $
��10 5q�5,      .+�5-      �� $��17(�5.   (   ��5-   (   �� *Title+5.   (   �� 5/      $��14(�50   (   ��5/   (   �� *Cost+50   (   �� 51      $��12(�52   (   ��51   (   �� *Description+52   (   �� 54      $ 
Horizontal=�6)   .+�55   "   �� $��	BtnUpdate��58   %   $��20��56   %   $	��100��57   %   $ ��Редактировать��59   %   $y�Hidden=�5:   %   $	��5 0q�5;   %   �� 5=   "   $��	BtnDelete��5?   %   $y�Hidden=�5>   %   $��20��5@   %   $	��100��5A   %   $��Удалить��5B   %   5E      5F      5G      5H      5J      5K      5L      