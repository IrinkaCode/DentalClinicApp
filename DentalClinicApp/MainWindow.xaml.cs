using DentalClinicApp.Models;
using System.Windows;


namespace DentalClinicApp
{
    public partial class MainWindow : Window
    {
        private PatientViewModel _viewModel;

        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new PatientViewModel();
            DataContext = _viewModel;
        }

        // Обработчик кнопки "Add Patient"
        private void AddPatient_Click(object sender, RoutedEventArgs e)
        {
            // Открываем окно для добавления нового пациента
            var addPatientWindow = new AddPatientWindow();

            if (addPatientWindow.ShowDialog() == true)
            {
                // Если пользователь сохранил нового пациента, добавляем его в коллекцию
                _viewModel.AddPatient(addPatientWindow.NewPatient);
            }
        }

        // Обработчик кнопки "Edit Patient"
        private void EditPatient_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранного пациента из DataGrid
            Patient selectedPatient = (Patient)PatientsDataGrid.SelectedItem;

            if (selectedPatient != null)
            {
                // Открываем окно редактирования с выбранным пациентом
                var editPatientWindow = new EditPatientWindow(selectedPatient);

                if (editPatientWindow.ShowDialog() == true)
                {
                    // Если пользователь сохранил изменения, обновляем DataGrid
                    PatientsDataGrid.Items.Refresh();
                }
            }
            else
            {
                // Если пациент не выбран, показываем сообщение
                MessageBox.Show("Пожалуйста, выберите пациента для редактирования.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        // Обработчик кнопки "Delete Patient"
        private void DeletePatient_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранного пациента из DataGrid
            var selectedPatient = (Patient)PatientsDataGrid.SelectedItem;

            if (selectedPatient != null)
            {
                // Удаляем пациента из коллекции
                _viewModel.RemovePatient(selectedPatient);
            }
            else
            {
                // Если пациент не выбран, показываем сообщение
                MessageBox.Show("Пожалуйста, выберите пациента для удаления.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void PatientsDataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }


    }
}

