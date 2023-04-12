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
    /// Логика взаимодействия для restoran.xaml
    /// </summary>
    public partial class restoran : Window
    {
        RESTORANTableAdapter rest = new RESTORANTableAdapter();
        opening_hoursTableAdapter op = new opening_hoursTableAdapter();
        public restoran()
        {
            InitializeComponent();
            RESTORAN.ItemsSource = rest.GetData();
            cmb5.ItemsSource = op.GetData();
            cmb5.DisplayMemberPath = "open_time";
            cmb5.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rest.InsertQuery(Convert.ToInt32(cmb5.SelectedValue), Convert.ToString(tbx2.Text), Convert.ToString(tbx1.Text));
                RESTORAN.ItemsSource = rest.GetData();
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
                object id = (RESTORAN.SelectedItem as DataRowView).Row[0];
                rest.DeleteQuery(Convert.ToInt32(id));
                RESTORAN.ItemsSource = rest.GetData();
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
                object id = (RESTORAN.SelectedItem as DataRowView).Row[0];
                rest.UpdateQuery(Convert.ToInt32(cmb5.SelectedValue), Convert.ToString(tbx2.Text), Convert.ToString(tbx1.Text), Convert.ToInt32(id));
                RESTORAN.ItemsSource = rest.GetData();
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
