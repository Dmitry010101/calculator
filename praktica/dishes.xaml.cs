using P.msdbDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Логика взаимодействия для dishes.xaml
    /// </summary>
    public partial class dishes : Window
    {
        dishesTableAdapter dish = new dishesTableAdapter();
        public dishes()
        {
            InitializeComponent();
            dish1.ItemsSource = dish.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            { 
                dish.InsertQuery(Convert.ToString(tbx1.Text), Convert.ToString(tbx2.Text), Convert.ToDecimal(tbx3.Text));
                dish1.ItemsSource = dish.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заплнено не правильно");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
            SecondRole secon = new SecondRole();
            secon.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            { 
                object id = (dish1.SelectedItem as DataRowView).Row[0];
                dish.DeleteQuery(Convert.ToInt32(id));
                dish1.ItemsSource = dish.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заплнено не правильно");
            }
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
              try
            {
                object id = (dish1.SelectedItem as DataRowView).Row[0];
                dish.UpdateQuery(Convert.ToString(tbx1.Text), Convert.ToString(tbx2.Text), Convert.ToDecimal(tbx3.Text), Convert.ToInt32(id));
                dish1.ItemsSource = dish.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заплнено не правильно");
            }
        }
    }
}
