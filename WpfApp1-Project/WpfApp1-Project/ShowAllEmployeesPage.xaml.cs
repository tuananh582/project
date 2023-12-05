using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MongoDB.Driver;
namespace WpfApp1_Project
{
    /// <summary>
    /// Interaction logic for ShowAllEmployeesPage.xaml
    /// </summary>
    public partial class ShowAllEmployeesPage : Page
    {
        private readonly IMongoCollection<Employee> employeeCollection;
        private List<Employee> employeesList;
        public ShowAllEmployeesPage(IMongoCollection<Employee> empCollection, List<Employee> employees)
        {
            InitializeComponent();

            employeeCollection = empCollection;
            employeesList = employees;
            LoadEmployeesToListView();

        }
        public void LoadEmployeesToListView()
        {
            listViewEmployees.ItemsSource = employeesList;
        }

        private async void DeleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            if (listViewEmployees.SelectedIndex != -1)
            {
                try
                {
                    Employee selectedEmployee = (Employee)listViewEmployees.SelectedItem;
                    var DeleteResult = await employeeCollection.DeleteOneAsync(emp => emp.Id == selectedEmployee.Id);
                    if (DeleteResult.DeletedCount > 0) {
                        employeesList.Remove(selectedEmployee);
                        listViewEmployees.ItemsSource = null;
                        listViewEmployees.ItemsSource = employeesList;
                    }
                    //employeesList.Remove(selectedEmployee);
                    //LoadEmployeesToListView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting employee: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to delete.");
            }

        }
        private void BackToMainWinDow_Click(object sender, RoutedEventArgs e)
        {
            //NavigationService?.Navigate(new MainWindow());
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            
        }
    }
};
