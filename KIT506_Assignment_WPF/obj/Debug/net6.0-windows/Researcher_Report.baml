   M S B A M L   `   `   `  ����P  LKIT506_Assignment_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:KIT506_Assignment_WPFKIT506_Assignment_WPF  5   	   -    'KIT506_Assignment_WPF.Researcher_Report   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:KIT506_Assignment_WPF     5   	     � Title$  Researcher_Report��5   	   $	��450��6#   $	��800��60   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��97* �6   �� 5      $��3* �6   .+�5   
   �� -   5        $��2��5      $��
10,26,10,0q�6)   .@�5      �� -   5         ��Name$ StarPerformance��5   0   $��Star Performance��6   $	��150��6I   $��20��6U   .��5      &   System.Windows.Controls.DataGrid  -   5          Name$ StarPerformanceGrid��5       J� IsHitTestVisible$ False��68      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Performance��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6b   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6B   �� *performance+6n     5      $
 Name��6-   $ * 6;    5      `� 5   "   	 �� StringFormat$	 {0}, {1} ({2})��6/   .1�5   &   �� 
 �� Path$
 family_name�6.   6C   �� 5   &   $
 
given_name�6.   6B   �� 5   &   $
 title�6.   6=   5   #   5      5       5!      �� 5"      -   5        $ MeetingMinimun��5"   /   $��Meeting Minimun��6   $	��150��6G   $��20��6S   .��5#        -   5        $ MeetingMinimunGrid��5#      $ False��67    5$        5%      $ Performance��6-   $ * 6b    6B   �� *performance+6n     5&      $
 Name��6-   $ * 6;    5'      `� 5(   "   $	 {0}, {1} ({2})��6/   .1�5)   &   �� $
 family_name�6.   6C   �� 5*   &   $
 
given_name�6.   6B   �� 5+   &   $
 title�6.   6=   5,   #   5.      50      51      �� 52      -   5        $ BlowExpectation��52   0   $��Blow Expectation��6   $	��150��6I   $��20��6U   .��53        -   5        $ BlowExpectationGrid��53      $ False��68    54        55      $ Performance��6-   $ * 6b    6B   �� *performance+6n     56      $
 Name��6-   $ * 6;    57      `� 58   "   $	 {0}, {1} ({2})��6/   .1�59   &   �� $
 family_name�6.   6C   �� 5:   &   $
 
given_name�6.   6B   �� 5;   &   $
 title�6.   6=   5<   #   5>      5@      5A      �� 5B      -   5        $
 Poor��5B   $   $
��Poor��6   $	��150��62   $��20��6>   .��5C        -	   5        $ PoorGrid��5C       5D        5E      $ Performance��6-   $ * 6b    6B   �� *performance+6n     5F      $
 Name��6-   $ * 6;    5G      `� 5H   "   $	 {0}, {1} ({2})��6/   .1�5I   &   �� $
 family_name�6.   6C   �� 5J   &   $
 
given_name�6.   6B   �� 5K   &   $
 title�6.   6=   5L   #   5N      5P      5Q      5R      �� 5S   
   -
   5        $��Copy Emails��5S   $   $
��Left=�6:   $��
657,11,0,0q�6U   $	��Top=�6i    J� RenderTransformOrigin$ -0.083,-0.704&�6�   $��21��6�   $	��124��6�   $��2��6�   5V      5W      