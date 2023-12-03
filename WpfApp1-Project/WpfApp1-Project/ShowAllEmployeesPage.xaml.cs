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
    /// Interaction logic for ShowAllEmployeesPage.xaml
    /// </summary>
    public partial class ShowAllEmployeesPage : Page
    {
        public ShowAllEmployeesPage(List<Employee> employees)
        {
            InitializeComponent();
            listViewEmployees.ItemsSource = employees;
        }
    }
}
