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
    /// Interaction logic for NewAllergenWindow.xaml
    /// </summary>
    public partial class NewAllergenWindow : Window
    {
        public NewAllergenWindow()
        {
            InitializeComponent();
        }

        private void Ok_Button_Click(object sender, RoutedEventArgs e)
        {
            Allergen currentAllergen = null;
           
            try
            {
                currentAllergen = new Allergen(AllergenName.Text, cboReactionType.Text, IncidentDate.SelectedDate, Symptoms.Text, "");
                //get my main window so i can get add to the med list
                MainWindow main = Owner as MainWindow;
                main.AllergenList.Add(currentAllergen);
                Close();
            }
            catch (Exception) { throw; }
        }

        private void Cancel_ButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
