
using DataObjects;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Collections.ObjectModel;

namespace MedicalManager
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //used for dynamic grid
        public ObservableCollection<Medication> MedicationList { get; set; }

        //Windows
        public NewMedicationWindow Nmw { get; set; }

        public MainWindow()
        {
            InitializeComponent();
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

        public ObservableCollection<Medication> ObservableEvtCode
        {
            get
            {
                return this.MedicationList;
            }
        }

        private void Row_Add_Button_Click(object sender, RoutedEventArgs e)
        {
            //show new window to in put medication
            Nmw = new NewMedicationWindow();
            Nmw.Owner = this;
            Nmw.Show();
        }
    }
}
