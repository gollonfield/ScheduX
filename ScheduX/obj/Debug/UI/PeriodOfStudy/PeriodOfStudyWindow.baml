   M S B A M L   `   `   `  ����O  Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections  5   	   B >ScheduX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ScheduXScheduX 5   	   2   ,ScheduX.UI.PeriodOfStudy.PeriodOfStudyWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   'localclr-namespace:ScheduX     5   	   -   5        $	��500��5	   	   $	��700��6     � WindowStartupLocation$  CenterScreen=�6"    � 
ResizeMode$ NoResize=�6G   .��5
      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   .+�5   
   �� -   5         ��Name$ Header��5      $��0��6!   $��PERIOD OF STUDY��6.   ���#3A36F4$
��Bold"�6]   $��16(�6o   $��25,0,0,0q�6}   �� 5   
   -   5         ��Name$ Toolbar��5      $��1��6&    �� Orientation$ 
Horizontal=�63   .+�5      �� -   5         ��Name$ Select��5      $��81��6&   $��24��61   $��	25,26,0,0q�6=   $��SELECT��6P   $
��Bold"�6a   ���#3A36F4
����������#3A36F4   RoundedCorners#���   6�   �� 5      -   5        $	 New��5      $��81��6"   $��24��6-   $��	12,26,0,0q�69   $	��NEW��6L   $
��Bold"�6Z   ���#3A36F4
����������#3A36F4#���   6�   5      �� 5   
   -   5         ��Name$ PeriodsList��5      $��2��6)   $��25,12,25,15q�66   ���#595959$	��350��6a    � Cursor$ Arrow��6n   	 � ContextMenu	 5      �� 5      .@�5      m� 
 m� Command$
 Select��6    m� Icon 5      �� 5       $8��2../../Resourses/Images/PeriodOfStudyImg/select.png��6$   5"      m� 5#      $

 Copy��6    5$      �� 5%      $6��0../../Resourses/Images/PeriodOfStudyImg/copy.png��6$   5'      m� 5(      $
 Paste��6    5)      �� 5*      $?��9../../Resourses/Images/PeriodOfStudyImg/paste_disable.png��6$   5,      m� 5-      $
 Delete��6    5.      �� 5/      $7��1../../Resourses/Images/PeriodOfStudyImg/trash.png��6$   51      52       �� View 54      �� 55      P�56      �� 57       �� Width$ 60��6)   $
��Name��64    �� DisplayMemberBinding 6B   �� *Name+�� 58      $ 60��6)   $��Starts��64    6D   �� *	StartYear+�� 59      $ 60��6)   $
��Ends��64    6B   �� *	EndYear+�� 5:      $	 100��6)   $��Working Weeks��65    6L   �� *WorkingWeeks+5<      5>      5?      5@      