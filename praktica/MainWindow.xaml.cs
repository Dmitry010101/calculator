using System.Windows;
using praktica.ExampleDBDataSetTableAdapters;

namespace praktica
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        buyersTableAdapter buyers = new buyersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            buyersDataGrid.ItemsSource = buyers.GetData();  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wim = new Window1();
            wim.Show();
        }
  
    }
}
