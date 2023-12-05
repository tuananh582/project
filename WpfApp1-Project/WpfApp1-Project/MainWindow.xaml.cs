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
using MongoDB.Bson;
using MongoDB.Driver;

namespace WpfApp1_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
    public partial class MainWindow : Window
    {
        //private IMongoCollection<Employee> employeeCollection;
        private ObservableCollection<Employee> employees = new ObservableCollection<Employee>();
        //private MongoClient client;
        private IMongoCollection<Employee> employeeCollection;
        public MainWindow()
        {
            InitializeComponent();
            //listViewEmployees.ItemsSource = employees;

            //NavigateToMainPage()

            ConnectToMongoDB();
        }
        private void ConnectToMongoDB()
        {
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "Employee";
            try
            {
                var client = new MongoClient(connectionString);
                var database = client.GetDatabase(databaseName);
                employeeCollection = database.GetCollection<Employee>("Employees");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MongoDB: " + ex.Message);
            }
        }
        private void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            //mainFrame.Navigate(new AddEmployeePage());
            AddEmployeePage addEmployeePage = new AddEmployeePage();
            this.Content = addEmployeePage;
        }
        private async  void btnShowAll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var employeesFromDB = await employeeCollection.Find(_ => true).ToListAsync();
                ShowAllEmployeesPage showAllEmployeesPage = new ShowAllEmployeesPage(employeeCollection,employeesFromDB);
                mainFrame.NavigationService.Navigate(showAllEmployeesPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employees: " + ex.Message);
            }

        }
        private async  void btnShowAllSalaries_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var allSalaries = await employeeCollection.Find(_ => true).ToListAsync();

                ShowAllSalaryPage showAllSalaryPage = new ShowAllSalaryPage();
                showAllSalaryPage.DisplaySalaries(allSalaries);

                mainFrame.NavigationService.Navigate(showAllSalaryPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving salaries: " + ex.Message);
            }


        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchPage searchPage = new SearchPage(employeeCollection);
            mainFrame.NavigationService.Navigate(searchPage);

        }
    }
}
