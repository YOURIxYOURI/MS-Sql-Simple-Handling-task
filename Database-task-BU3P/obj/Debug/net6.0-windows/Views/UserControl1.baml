   M S B A M L   `   `   `  ����M  IDatabase-task-BU3P, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Database_task_BU3P.ViewsDatabase_task_BU3P.Views  5      +    %Database_task_BU3P.Views.UserControl1   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:Database_task_BU3P.Views     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $	��46* �6   �� 5      $	��29* �6   .+�5   
   �� $��Użytkownik��6   $
��Left=�6%   $��	82,51,0,0q�6@   $	��Top=�6S   $	��127��6k   $��1��6w   $��26��6�   �� 5   
   -   5         ��Name$ UserForm��5      $
��Left=�6$   $��
172,53,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��165��6   $��1��6�   $��18��6�   �� 5   
   $
��Opis��6   $
��Left=�6   $��	82,74,0,0q�6:   $	��Top=�6M   $��77��6e   $��1��6p   $��26��6�   �� 5   
   -   5        $ DescriptionForm��5      $
��Left=�6+   $��
172,76,0,0q�6F   $
 Wrap=�6Z   $	��Top=�6n   $	��165��6�   $��1��6�   $��18��6�   �� 5   
   $��Technik��6   $
��Left=�6"   $��
83,105,0,0q�6=   $	��Top=�6Q   $��1��6i   $��26��6y   $��49��6�   �� 5   
   -   5         ��Name$ TechnicianList��5      $
��Left=�6+   $��172,107,0,0q�6F   $	��Top=�6[   $	��165��6s   $��1��6   $��22��6�   �� 5   
   $��	Kategoria��6   $
��Left=�6$   $��
83,132,0,0q�6?   $	��Top=�6S   $��1��6k   $��26��6{   $��61��6�   �� 5   
   -   5        $ CategoryList��5      $
��Left=�6)   $��172,134,0,0q�6D   $	��Top=�6Y   $	��165��6q   $��1��6}   $��22��6�   �� 5   
   -   5        $��Utwórz��5      $
��Left=�6"   $��241,177,0,0q�6=   $	��Top=�6R   $��28��6j   $��96��6v   $��1��6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgZgloszenia��5         AutoGenerateColumns$ False��6'      CanUserAddRows$ False��6C   $��2��6�   $��	0,0,333,0q�6�      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+  5      $ Nazwa użytkownika��6%    6@   �� *User+  5      $ Opis awarii��6%    6:   �� *Description+  5      $ Data dodania��6%    6;   �� *Date+  5      $ 	Kategoria��6%    68   �� *
Category+  5      $ Przydzielone do��6%    6>   �� *
Technician+4  .System.Windows.Controls.DataGridCheckBoxColumn  5      $ Wykonane��6)    6;   �� *IsDone+5%      4  .System.Windows.Controls.DataGridTemplateColumn  5'      $ Usuń��6)   	   CellTemplate	 5(      �� 5)      .R�5*      �� -   5        $��Usuń��5*   %   64   5+      5-      5/      �� 50   
   -   5        $��Technicy��50      $
��Left=�6$   $��236,357,0,0q�6?   $	��Top=�6T   $��28��6l   $��96��6x   $��1��6�   �� 51   
   -	   5        $��	Kategorie��51      $��Center=�6%   $��	0,357,0,0q�6B   $	��Top=�6U   $��28��6m   $��96��6y   $��1��6�   52      53      