   M S B A M L   `   `   `  ����  MedicalManager&     MedicalManager.NewAllergenWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   
����d�$��0q�5	   	     � 
ResizeMode$  NoResize=�5
   	   
����ح� � Title$ New Allergen��5   	    � WindowStartupLocation$ CenterOwner=�6   $��Center=�6B   $	��150��6_   $	��600��6l   .��5      �� 
����ح�$��	15,10,0,0q�6(   .+�5   
   � .+�5      �� -   5         ��Name$ AllergenName��5      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Enter Allergen Name��6,   $��20��6d   $	��150��6p   $	��Top=�6|   $
��Left=�6�   �� 5      -   5         ��Name$ cboReactionType��5       �� SelectedIndex$ 0��6+   $
��Left=�6=   $��28��6X   $��	220,0,0,0q�6e   $	��Top=�6x   $	��150��6�   .@�5      �� -   5        $��SelectReactionType��5      .��69   Select Reaction Type6O   �� 5      -   5        $��SEVERE��5      .��6-   Severe65   �� 5      -   5        $��MODERATE��5      .��6/   
Moderate69   �� 5      -   5        $
��MILD��5      .��6+   Mild61   5      (  "System.Windows.Controls.DatePicker  5      -   5          Name$ IncidentDate��5      $ Incident Date��6/   $	��Top=�6a   $
��Left=�6y   $��	450,0,0,0q�6�   �� 5      -   5        $ Symptoms��5      $ Enter Symptonms��6(   $��50��6\   $	��500��6h   $	��Top=�6t   $
��Left=�6�   $��	25,30,0,0q�6�   5      � 5   
   .+�5      �� -	   5        $��15��5      $��30��6!   $��OK��6,   $��	380,3,0,0q�6:   6M   �� 5      -
   5        $��15��5      $��50��6!   $��Cancel��6,   $��	480,3,0,0q�6>   6Q   5      5      5!      