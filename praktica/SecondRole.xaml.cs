using P.msdbDataSetTableAdapters;
using System.Security.Cryptography;
using System.Windows;

namespace P
{
    /// <summary>
    /// Логика взаимодействия для SecondRole.xaml
    /// </summary>
    public partial class SecondRole : Window
    {
        public SecondRole()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dishes dis = new dishes();
            dis.Show();
            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        opening open = new opening();
            open.Show();
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            reservations reservations = new reservations(); 
            reservations.Show();
            Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            tables table = new tables();
            table.Show();
            Close ();
        }
    }
}
