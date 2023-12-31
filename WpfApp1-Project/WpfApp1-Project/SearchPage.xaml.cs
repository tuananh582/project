﻿using System;
using System.Collections;
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
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        private ObservableCollection<Employee> searchResults = new ObservableCollection<Employee>();
        private IMongoCollection<Employee> employeeCollection; //

        public SearchPage(IMongoCollection<Employee> collection)
        {
            InitializeComponent();
            employeeCollection = collection; // Initialize the collection here
            listViewSearchResults.ItemsSource = searchResults;

        }

        private async  void Search_Click(object sender, RoutedEventArgs e)
        {

          
            string searchName = txtSearchName.Text.Trim();

            if (!string.IsNullOrEmpty(searchName))
            {
                try
                {
                    var filter = Builders<Employee>.Filter.Where(emp => emp.Name.ToLower().Contains(searchName.ToLower()));
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
       
        

        private void BackToMain_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            Application.Current.MainWindow = mainWindow;
            mainWindow.Show();
        }

        private async  void Button_Click(object sender, RoutedEventArgs e)
        {
            string searchBan = txtSearchDepartment.Text.Trim();
            if (!string.IsNullOrEmpty(searchBan))
            {
                try
                {
                    var filter = Builders<Employee>.Filter.Where(emp => emp.Department.ToLower().Contains(searchBan.ToLower()));
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


        }

        private async  void Search_Year_Click(object sender, RoutedEventArgs e)
        {
            string SeachYear= txtSearchYear.Text.Trim();
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


  

    }
    }
}
