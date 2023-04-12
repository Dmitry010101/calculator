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
    /// Логика взаимодействия для opening.xaml
    /// </summary>
    public partial class opening : Window
    {
        opening_hoursTableAdapter open = new opening_hoursTableAdapter();
        public opening()
        {
            InitializeComponent();
            openn.ItemsSource = open.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
            SecondRole secon = new SecondRole();
            secon.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                open.InsertQuery(Convert.ToByte(tbx1.Text), Convert.ToString(tbx2.Text), Convert.ToString(tbx3.Text));
                openn.ItemsSource = open.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заполнено не правильно");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (openn.SelectedItem as DataRowView).Row[0];
                open.DeleteQuery(Convert.ToInt32(id));
                openn.ItemsSource = open.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заполнено не правильно");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
                object id = (openn.SelectedItem as DataRowView).Row[0];
                open.UpdateQuery(Convert.ToByte(tbx1.Text), Convert.ToString(tbx2.Text), Convert.ToString(tbx3.Text), Convert.ToInt32(id));
                openn.ItemsSource = open.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заполнено не правильно");
            }
        }
    }
}
