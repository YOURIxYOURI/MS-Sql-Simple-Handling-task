   M S B A M L   `   `   `  ����M  IDatabase-task-BU3P, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Database_task_BU3P.ViewsDatabase_task_BU3P.Views  5      +    %Database_task_BU3P.Views.UserControl2   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Database_task_BU3P.Views     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $
��268* �6   �� 5      $
��207* �6   .+�5   
   �� $
��Imie��6   $
��Left=�6   $��	83,63,0,0q�6:   $	��Top=�6M   $	��127��6e   $��1��6q   $��26��6�   �� 5   
   -   5         ��Name$ 	FnameForm��5      $
��Left=�6%   $��
173,65,0,0q�6@    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��165��6�   $��1��6�   $��18��6�   �� 5   
   $��Nazwisko��6   $
��Left=�6#   $��	83,86,0,0q�6>   $	��Top=�6Q   $��77��6i   $��1��6t   $��26��6�   �� 5   
   -   5        $ 	LnameForm��5      $
��Left=�6%   $��
173,88,0,0q�6@   $
 Wrap=�6T   $	��Top=�6h   $	��165��6�   $��1��6�   $��18��6�   �� 5   
   -   5        $��Utwórz��5      $
��Left=�6"   $��242,189,0,0q�6=   $	��Top=�6R   $��28��6j   $��96��6v   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
dgTechnicy��5         AutoGenerateColumns$ False��6%      CanUserAddRows$ False��6A      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *ID+  5      $ Imie i Nazwisko��6%    6>   �� *Name+4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Usuń��6)      CellTemplate 5      �� 5      .R�5      �� -   5        $��Usuń��5   %   64   5      5      5      �� 5    
   -   5        $��Zgłoszenia��5       $
��Left=�6&   $��237,369,0,0q�6A   $	��Top=�6V   $��28��6n   $��96��6z   $��1��6�   �� 5!   
   -   5        $��	Kategorie��5!      $
��Left=�6%   $��136,369,0,0q�6@   $	��Top=�6U   $��28��6m   $��96��6y   $��1��6�   5"      5#      