
using DataObjects.Models;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Collections;
using System.Data;
using System;

namespace MedicalManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //used for dynamic grid Medication
        public ObservableCollection<Medication> MedicationList { get; set; }
        // //used for dynamic grid allergen
        public ObservableCollection<Allergen> AllergenList { get; set; }

        //Windows
        public NewMedicationWindow Nmw { get; set; }
        public NewAllergenWindow Naw { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            //Allergens
            AllergenList = new ObservableCollection<Allergen>();


            MedicationList = new ObservableCollection<Medication>();
            MedicationList.Add(new Medication());
            MedicationList[0].MedicationName = "Lansprozle";
            MedicationList[0].MedicationFrequency = "Daily";
            MedicationList[0].MedicationPharmacy = "Valley of the sun";
            MedicationList[0].MedicationDose = "1 ML";
            MedicationList[0].DoctorPrescribed = "Dr. Serbin";

            MedicationList.Add(new Medication());
            MedicationList[1].MedicationName = "lans";
            MedicationList[1].MedicationFrequency = "day";
            MedicationList[1].MedicationPharmacy = "Valley ";
            MedicationList[1].MedicationDose = "2 ML";
            MedicationList[1].DoctorPrescribed = "Dr. Siaw";
        }

        /// <summary>
        /// Gets list of allergens and updates as changes are made to meds list
        /// </summary>
        public ObservableCollection<Medication> ObservableEvtCodeMedicationList => MedicationList;

        /// <summary>
        /// Gets list of allergens and updates as changes are made to allergen list
        /// </summary>
        public ObservableCollection<Allergen> ObservableEvtCodeAllergenList => AllergenList;

        private void Row_Add_Allergen_Button_Click(object sender, RoutedEventArgs e)
        {
            //create allergen window
            Naw = new NewAllergenWindow() { Owner = this };
            //show window
            Naw.Show();
        }

        private void Row_Add_Medication_Button_Click(object sender, RoutedEventArgs e)
        {
            //show new window to in put medication
            Nmw = new NewMedicationWindow() { Owner = this };
            Nmw.Show();
        }

        private void Row_Delete_Medication_CheckBox(object sender, RoutedEventArgs e)
        {
            List<Medication> deletedMeds = MedicationList.Where(p => p.ShouldDelete).ToList();

            foreach (Medication  item in deletedMeds)
            {
                MedicationList.Remove(item);
            }
        }

      
    }
}
