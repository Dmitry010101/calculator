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
using System.Windows.Shapes;

namespace P
{
    /// <summary>
    /// Логика взаимодействия для firstrole.xaml
    /// </summary>
    public partial class firstrole : Window
    {
        public firstrole()
        {
            InitializeComponent();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            employees employees = new employees();
            employees.Show();
            Close();

        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            restoran rest = new restoran();
            rest.Show();
            Close();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            orders orders = new orders();
            orders.Show();
            Close ();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            schedules schedules = new schedules();
            schedules.Show();
            Close () ;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            suppliers suppliers = new suppliers();  
            suppliers.Show();
            Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            supplies suppl = new supplies();
            suppl.Show();
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            LoginData log = new LoginData();
            log.Show();
            Close();
        }
    }
}
