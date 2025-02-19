using DentalClinicApp.Models;
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

namespace DentalClinicApp
{
    /// <summary>
    /// Логика взаимодействия для AddPatientWindow.xaml
    /// </summary>
    public partial class AddPatientWindow : Window
    {
        public Patient NewPatient { get; private set; }
        public AddPatientWindow()
        {
            InitializeComponent();
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            NewPatient = new Patient
            {
                LastName = LastNameTextBox.Text,
                FirstName = FirstNameTextBox.Text,
                SurName = SurNameTextBox.Text,
                DateOfBirth = DateOfBirthPicker.SelectedDate ?? DateTime.Now,
                PhoneNumber = PhoneNumberTextBox.Text,
                Address = AddressTextBox.Text,
                MedicalHistory = MedicalHistoryTextBox.Text
            };

            DialogResult = true;
            Close();
        }
    }
}
