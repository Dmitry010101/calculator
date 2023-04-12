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
    /// Логика взаимодействия для reservations.xaml
    /// </summary>
    public partial class reservations : Window
    {
        reservationsTableAdapter res = new reservationsTableAdapter();
        tablesTableAdapter tables = new tablesTableAdapter();   
        public reservations()
        {
            InitializeComponent();
            REservations.ItemsSource = res.GetData();
            cmb5.ItemsSource = tables.GetData();
            cmb5.DisplayMemberPath = "capacity";
            cmb5.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                res.InsertQuery(Convert.ToDateTime(tbx1.Text), Convert.ToInt32(cmb5.SelectedValue), Convert.ToString(tbx2.Text), Convert.ToString(tbx3.Text));
                REservations.ItemsSource = res.GetData();  
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
                object id = (REservations.SelectedItem as DataRowView).Row[0];
                res.DeleteQuery(Convert.ToInt32(id));
                REservations.ItemsSource = res.GetData();
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
                object id = (REservations.SelectedItem as DataRowView).Row[0];
                res.UpdateQuery(Convert.ToDateTime(tbx1.Text), Convert.ToInt32(cmb5.SelectedValue), Convert.ToString(tbx2.Text), Convert.ToString(tbx3.Text), Convert.ToInt32(id));
                REservations.ItemsSource = res.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заполнено не правильно");
            }
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
    }
}
