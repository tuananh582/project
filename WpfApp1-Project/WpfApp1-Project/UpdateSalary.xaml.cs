using MongoDB.Driver;
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

namespace WpfApp1_Project
{
    /// <summary>
    /// Interaction logic for UpdateSalary.xaml
    /// </summary>
    public partial class UpdateSalary : Page
    {
        private ObservableCollection<Employee> searchResults = new ObservableCollection<Employee>();
        private IMongoCollection<Employee> employeeCollection;
        public UpdateSalary(IMongoCollection<Employee> collection)
        {
            InitializeComponent();
            employeeCollection = collection; // Initialize the collection here
            listViewSearchResults.ItemsSource = searchResults;
        }

        private async  void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            string searchMaNv = txtSearchMaNv.Text.Trim();
            string newSalary = txtUpdateSalary.Text.Trim();

            if (!string.IsNullOrEmpty(searchMaNv) && !string.IsNullOrEmpty(newSalary))
            {
                try
                {
                    var filter = Builders<Employee>.Filter.Eq("MaNv", searchMaNv);
                    var update = Builders<Employee>.Update.Set("Salary", newSalary);

                    var updateResult = employeeCollection.UpdateMany(filter, update);

                    MessageBox.Show($"{updateResult.ModifiedCount} employee(s) position updated successfully.");
                    await RefreshListView();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating department: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter an employee code and a new department.");
            }

        }
        private async Task RefreshListView()
        {
            try
            {
                var filter = Builders<Employee>.Filter.Where(emp => emp.MaNv.ToLower().Contains(txtSearchMaNv.Text.Trim().ToLower()));
                var filteredEmployees = await employeeCollection.Find(filter).ToListAsync();

                searchResults.Clear();
                foreach (var emp in filteredEmployees)
                {
                    searchResults.Add(emp);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error refreshing employee list: " + ex.Message);
            }
        }

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string searchMaNv = txtSearchMaNv.Text.Trim();

            if (!string.IsNullOrEmpty(searchMaNv))
            {
                try
                {
                    var filter = Builders<Employee>.Filter.Where(emp => emp.MaNv.ToLower().Contains(searchMaNv.ToLower()));
                    var filteredEmployees = await employeeCollection.Find(filter).ToListAsync();

                    if (filteredEmployees.Count == 0)
                    {
                        MessageBox.Show("No employees found with the provided name.");
                    }
                    else
                    {
                        searchResults.Clear();
                        foreach (var emp in filteredEmployees)
                        {
                            searchResults.Add(emp);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error searching for employees: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a name to search.");
            }
        }
        

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
        }
    }
}
