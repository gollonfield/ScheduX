   M S B A M L   `   `   `  ����B  >ScheduX, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ScheduXScheduX  5   	   (    "ScheduX.UI.CreateOpenProjectWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ScheduX     5   	   
�������$
��583 ��5      $	��806��6*     � WindowStartupLocation$  CenterScreen=�67   $	��570��6\   $	��806��6k   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   �� $��0��6   $��ScheduX��6!   $��38(�60   $��Noto Sans Symbols2)�6>   
���   �$��0,40,0,0q�6q   $��Center=�6�   �� 5   
   $��1��6   $��Get Started��6!   $��20(�64   $��Noto Sans Symbols2)�6B   
���   �$��0,30,0,0q�6u   $��Center=�6�   �� 5   
   -   5        $��2��5      $��0,26,0,0q�6   $	��455��60   $��Center=�6=   ���#EEEBEB
���   �   TemplateButton#���   6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $#��..\Resourses\Images\paper.png��6   $��40��6?   $
��Left=�6J   $	��Top=�6e   $��
12,12,12,0q�6}   �� 5      .+�5      ��  �� Padding$ 0,9,0,0q�6    $��18(�62   Create a new project6V   �� 5      $ 	0,1,40,28q�6    $��12(�64   ���#676767Choose a project template6r   5      5      5      �� 5    
   -   5        $��3��5       $��0,6,0,0q�6   $	��455��6/   $��Center=�6;   ���#EEEBEB
���   �#���   6�   .��5!      �� $ 
Horizontal=�6   .+�5"      �� $)��#..\Resourses\Images\open-folder.png��6   $��40��6E   $
��Left=�6P   $	��Top=�6k   $��	12,9,12,0q�6�   �� 5#      .+�5$      �� $ 0,9,0,0q�6    $��18(�62   Open a project6P   �� 5%      $"��Open a local ScheduX project��6    $ 	0,1,24,28q�6D   $��12(�6X   ���#6767676f   5&      5'      5(      �� 5*   
   $��4��6   $��Open recent��6!   $��20(�64   $��Noto Sans Symbols2)�6B   
���   �$��0,30,0,0q�6u   $��Center=�6�   �� 5+   
   -   5         ��Name$ ProjectTextBox��5+      $��5��6   $��0,26,0,0q�67   $��5,5,0,5q�6I   $	��455��6[   $��Center=�6g   
���   �
�������$��2q�6�    �� 
CaretBrush
 �   �6�   �� 5-   
   -   5         ��Name$ ProjectListBox��5-      $��6��6   $��	0,12,0,20q�67   $	��455��6J   $��0q�6V   5.      5/      