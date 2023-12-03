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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MongoDB.Bson;
using MongoDB.Driver;


namespace WpfApp1_Project
{
    /// <summary>
    /// Interaction logic for AddEmployeePage.xaml
    /// </summary>
    public partial class AddEmployeePage : Page
    {
        private IMongoCollection<Employee> employeeCollection;
        private MongoClient client;

        public AddEmployeePage()
        {
            InitializeComponent();
            string connectionString = "mongodb://localhost:27017";
            string databaseName = "Employee";

            try
            {
                client = new MongoClient(connectionString);
                var database = client.GetDatabase(databaseName);
                employeeCollection = database.GetCollection<Employee>("Employees");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to MongoDB: " + ex.Message);
            }

        }

        private async  void btnAddEmployee_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Creating a new Employee object with data from input fields
                Employee newEmployee = new Employee()
                {
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Salary = decimal.Parse(txtSalary.Text),
                    BonusSalary = decimal.Parse(txtBonusSalary.Text),
                    Department = txtDepartment.Text,
                    City = txtCity.Text
                };
                // Inserting the new employee into the MongoDB collection
                await employeeCollection.InsertOneAsync(newEmployee);

                // Display success message or perform any necessary actions after adding employee
                MessageBox.Show("Employee added successfully.");
                // Clear input fields after adding an employee
                ClearInputFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }
        private void ClearInputFields()
        {
            txtName.Text = "";
            txtAge.Text = "";
            txtSalary.Text = "";
            txtBonusSalary.Text = "";
            txtDepartment.Text = "";
            txtCity.Text = "";
        }

        private void BackToMainWinDow_Click(object sender, RoutedEventArgs e)
        {
            //NavigateBackToMainWindow();
            MainWindow mainWindow= new MainWindow();
            mainWindow.Show();
            Application.Current.MainWindow= mainWindow;
            this.NavigationService?.GoBack();
        }
       
    }


}

