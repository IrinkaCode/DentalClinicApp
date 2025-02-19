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
    /// Логика взаимодействия для EditPatientWindow.xaml
    /// </summary>
    public partial class EditPatientWindow : Window
    {
        // Пациент, который будет редактироваться
        public Patient EditedPatient { get; private set; }
        public EditPatientWindow(Patient patient)
        {
            InitializeComponent();
            // Инициализация данных пациента в полях окна
            EditedPatient = patient;
            FirstNameTextBox.Text = patient.FirstName;
            LastNameTextBox.Text = patient.LastName;
            SurNameTextBox.Text = patient.SurName;
            DateOfBirthPicker.SelectedDate = patient.DateOfBirth;
            PhoneNumberTextBox.Text = patient.PhoneNumber;
            AddressTextBox.Text = patient.Address;
            MedicalHistoryTextBox.Text = patient.MedicalHistory;
        }
        // Обработчик кнопки "Save"
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            // Обновление данных пациента
            EditedPatient.LastName = LastNameTextBox.Text;
            EditedPatient.FirstName = FirstNameTextBox.Text;
            EditedPatient.SurName = SurNameTextBox.Text;
            EditedPatient.DateOfBirth = DateOfBirthPicker.SelectedDate ?? DateTime.Now;
            EditedPatient.PhoneNumber = PhoneNumberTextBox.Text;
            EditedPatient.Address = AddressTextBox.Text;
            EditedPatient.MedicalHistory = MedicalHistoryTextBox.Text;

            // Устанавливаем результат диалога как true и закрываем окно
            DialogResult = true;
            Close();
        }

        // Обработчик кнопки "Cancel"
        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем окно без сохранения изменений
            DialogResult = false;
            Close();
        }
    }
}
