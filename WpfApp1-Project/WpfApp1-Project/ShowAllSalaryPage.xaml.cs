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

namespace WpfApp1_Project
{
    /// <summary>
    /// Interaction logic for ShowAllSalaryPage.xaml
    /// </summary>
    public partial class ShowAllSalaryPage : Page
    {
        public ShowAllSalaryPage()
        {
            InitializeComponent();
        }
        public void DisplaySalaries(List<Employee> salaries)
        {
            //listViewSalaries.ItemsSource = salaries;
            var sortedSalaries =salaries.OrderByDescending(emp=>emp.TotalSalary).ToList();
            listViewSalaries.ItemsSource=sortedSalaries;
        }

        private void BackToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow= new MainWindow();
            //NavigationService.Navigate(mainWindow);
            mainWindow.Show();
        }
    }
}
