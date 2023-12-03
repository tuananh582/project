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
using System.Windows.Shapes;
using MongoDB.Bson;
using MongoDB.Driver;
using static WpfApp1_Project.MainWindow;


namespace WpfApp1_Project
{
    /// <summary>
    /// Interaction logic for AddEmployeeWindow.xaml
    /// </summary>
    public partial class AddEmployeeWindow : Window
    {
        private IMongoCollection<Employee> employeeCollection;

        public AddEmployeeWindow(IMongoCollection<Employee> collection)
        {
            InitializeComponent();
            employeeCollection = collection;
        }

        private async void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Create an employee object from the input fields
                Employee newEmployee = new Employee()
                {
                    Name = txtName.Text,
                    Age = int.Parse(txtAge.Text),
                    Salary = decimal.Parse(txtSalary.Text),
                    BonusSalary = decimal.Parse(txtBonus.Text),
                    Department = txtDepartment.Text,
                    City = txtCity.Text
                    // Populate other fields similarly (Age, Salary, BonusSalary, Department, City)
                };

                // Add employee to MongoDB
                await employeeCollection.InsertOneAsync(newEmployee);

                // Update the ListView to display all employees after adding
                RefreshEmployeeListView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message);
            }
        }
        private async void RefreshEmployeeListView()
        {
            try
            {
                var employeesFromDB = await employeeCollection.Find(new BsonDocument()).ToListAsync();

                // Bind employee details to the ListView
                listViewEmployees.ItemsSource = employeesFromDB;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving employees: " + ex.Message);
            }
        }
         


    }
}
