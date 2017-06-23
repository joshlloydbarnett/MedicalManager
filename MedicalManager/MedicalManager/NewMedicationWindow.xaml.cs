using DataObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MedicalManager
{
    /// <summary>
    /// Interaction logic for NewMedicationWindow.xaml
    /// </summary>
    public partial class NewMedicationWindow : Window
    {
        public NewMedicationWindow()
        {
            InitializeComponent();
            
        }

        private void Cancel_ButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            Medication currentMedication = null;
            try
            {
                currentMedication = new Medication(MedicationName.Text, MedicationDose.Text, MedicationFrequency.Text, MedicationPharmacy.Text, DoctorPrescribed.Text);
                //get my main window so i can get add to the med list
                MainWindow main = Owner as MainWindow;
                main.MedicationList.Add(currentMedication);
                Close();
            }
            catch (Exception) { throw; }
        }


    }
}
