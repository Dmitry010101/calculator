using P.msdbDataSetTableAdapters;
using System;
using System.Data;
using System.Windows;

namespace P
{
    /// <summary>
    /// Логика взаимодействия для orders.xaml
    /// </summary>
    public partial class orders : Window
    {
        ordersTableAdapter or = new ordersTableAdapter();
        public orders()
        {
            InitializeComponent();
            OrderS.ItemsSource = or.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                or.InsertQuery(Convert.ToDateTime(tbx1.Text), Convert.ToInt32(tbx2.Text), Convert.ToDecimal(tbx3.Text));
                OrderS.ItemsSource = or.GetData();
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
                object id = (OrderS.SelectedItem as DataRowView).Row[0];
                or.DeleteQuery(Convert.ToInt32(id));
                OrderS.ItemsSource = or.GetData();
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
                object id = (OrderS.SelectedItem as DataRowView).Row[0];
                or.UpdateQuery(Convert.ToDateTime(tbx1.Text), Convert.ToInt32(tbx2.Text), Convert.ToDecimal(tbx3.Text), Convert.ToInt32(id));
                OrderS.ItemsSource = or.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заполнено не правильно");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
            firstrole secon = new firstrole();
            secon.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
