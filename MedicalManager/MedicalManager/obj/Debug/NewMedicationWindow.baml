   M S B A M L   `   `   `  ����  MedicalManager(    "MedicalManager.NewMedicationWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMahApps.Metro, Version=1.5.0.23, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4f;controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   
����d�$��0q�5	   	     � 
ResizeMode$  NoResize=�5
   	   
����ح� � Title$ New Medication��5   	    � WindowStartupLocation$ CenterOwner=�6    $��Center=�6D   $	��150��6a   $	��600��6n   .��5      �� 
����ح�$��	15,10,0,0q�6(   .+�5      � .+�5      �� -   5         ��Name$ MedicationName��5      *  $MahApps.Metro.Controls.TextBoxHelper   	Watermark$ Enter Medication Name��62   $��20��6l   $	��150��6x   $	��Top=�6�   $
��Left=�6�   �� 5      -   5        $ MedicationDose��5      $ Enter Medication Dose��62   $��20��6l   $	��150��6x   $	��Top=�6�   $
��Left=�6�   $��	180,0,0,0q�6�   �� 5      -   5        $ MedicationFrequency��5      $  Enter Medication Frequency��67   $��20��6v   $	��180��6�   $	��Top=�6�   $
��Left=�6�   $��	350,0,0,0q�6�   �� 5      -   5        $ MedicationPharmacy��5      $ Enter Medication Pharmacy��66   $��20��6t   $	��180��6�   $	��Top=�6�   $
��Left=�6�   $��0,40,0,0q�6�   �� 5      -   5        $ DoctorPrescribed��5      $ Enter Doctor Prescribed��64   $��20��6p   $	��180��6|   $	��Top=�6�   $
��Left=�6�   $��
200,40,0,0q�6�   5      � 5   
   .+�5      �� -   5        $��15��5      $��30��6!   $��OK��6,   $��380,-10,0,0q�6:   6O   �� 5      -   5        $��15��5      $��50��6!   $��Cancel��6,   $��480,-10,0,0q�6>   6S   5      5      5      