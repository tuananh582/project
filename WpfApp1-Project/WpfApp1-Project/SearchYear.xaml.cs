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
    /// Interaction logic for SearchYear.xaml
    /// </summary>
    public partial class SearchYear : Page
    {
        private ObservableCollection<Employee> searchResults = new ObservableCollection<Employee>();
        private IMongoCollection<Employee> employeeCollection; //
        public SearchYear(IMongoCollection<Employee> collection)
        {
            InitializeComponent();
            employeeCollection = collection; // Initialize the collection here
            listViewSearchResults.ItemsSource = searchResults;
        }

        private async  void Button_Click(object sender, RoutedEventArgs e)
        {
            string SeachYear = txtSearchYear.Text.Trim();
            if (!string.IsNullOrEmpty(SeachYear))
            {
                try
                {
                    var filter = Builders<Employee>.Filter.Where(emp => emp.year.ToString().Contains(SeachYear.ToLower()));
                    var filteredEmployees = await employeeCollection.Find(filter).ToListAsync();

                    if (filteredEmployees.Count == 0)
                    {
                        MessageBox.Show("No employees found with the provided Department.");
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
            ClearInput();
        }
        private void ClearInput()
        {
            txtSearchYear.Text = "";

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ListView listView = listViewSearchResults;
            PrintDialog printDialog = new PrintDialog();

            if (printDialog.ShowDialog() == true)
            {
                printDialog.PrintVisual(listView, "Print ListView Content");
            }
        }
    }
    }

