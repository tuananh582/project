﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
            try
            {
                ConnectToMongoDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing application: " + ex.ToString());
            }
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
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            SearchPage searchPage = new SearchPage(employeeCollection);
            mainFrame.NavigationService.Navigate(searchPage);

        }

        private void btnUpdate_Depart_Click(object sender, RoutedEventArgs e)
        {
            UpdateDepart updateDepartPage = new UpdateDepart(employeeCollection);
            mainFrame.NavigationService.Navigate(updateDepartPage);

        }

        private void btnUpdate_Pos_Click(object sender, RoutedEventArgs e)
        {
            UpdatePos updatePosPage = new UpdatePos(employeeCollection);
            mainFrame.NavigationService.Navigate(updatePosPage);
        }

        private void btnUpdate_infor_Click(object sender, RoutedEventArgs e)
        {
            UpdateInfor updateInfor=new UpdateInfor(employeeCollection);
            mainFrame.NavigationService.Navigate(updateInfor);
        }

        private void btn_UpdateYear_Click(object sender, RoutedEventArgs e)
        {
            UpdateYear updateYear= new UpdateYear(employeeCollection);
            mainFrame.NavigationService.Navigate(updateYear);


        }

        private void btnUpdate_Salary_Click(object sender, RoutedEventArgs e)
        {
            UpdateSalary updateSalary= new UpdateSalary(employeeCollection);
            mainFrame.NavigationService.Navigate(updateSalary);
        }

        private void btnUpdate_Product_Click(object sender, RoutedEventArgs e)
        {
            UpdateProduct updateProduct = new UpdateProduct(employeeCollection);
            mainFrame.NavigationService.Navigate(updateProduct);
        }

        private void Find_Name_Click(object sender, RoutedEventArgs e)
        {
            SearchName searchName = new SearchName(employeeCollection);
            mainFrame.NavigationService.Navigate(searchName);

        }

        private void FindYear_Click(object sender, RoutedEventArgs e)
        {
            SearchYear searchYear = new SearchYear(employeeCollection);
            mainFrame.NavigationService.Navigate(searchYear);
        }

        private void FindDepart_Click(object sender, RoutedEventArgs e)
        {
            SearchDepart searchDepart= new SearchDepart(employeeCollection);
            mainFrame.NavigationService.Navigate(searchDepart);


        }

        private void Support_Click(object sender, RoutedEventArgs e)
        {
            mainFrame.Navigate(new Support());
        }

        private void btn_Update_Cong_Click(object sender, RoutedEventArgs e)
        {
            UpdateCong updateCong = new UpdateCong(employeeCollection);
            mainFrame.NavigationService.Navigate(updateCong);
        }
    }
}
