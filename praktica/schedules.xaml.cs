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
    /// Логика взаимодействия для schedules.xaml
    /// </summary>
    public partial class schedules : Window
    {  
        schedulesTableAdapter she = new schedulesTableAdapter();
        employeesTableAdapter emp = new employeesTableAdapter();
        public schedules()
        {
            InitializeComponent();
            ShedUl.ItemsSource = she.GetData();
            cmb5.ItemsSource = emp.GetData();
            cmb5.DisplayMemberPath = "first_name";
            cmb5.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                she.InsertQuery(Convert.ToInt32(cmb5.SelectedValue), Convert.ToString(tbx2.Text), Convert.ToString(tbx3.Text));
                ShedUl.ItemsSource = she.GetData();
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
                object id = (ShedUl.SelectedItem as DataRowView).Row[0];
                she.DeleteQuery(Convert.ToInt32(id));
                ShedUl.ItemsSource = she.GetData();
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
                object id = (ShedUl.SelectedItem as DataRowView).Row[0];
                she.UpdateQuery(Convert.ToInt32(cmb5.SelectedValue), Convert.ToString(tbx2.Text), Convert.ToString(tbx3.Text), Convert.ToInt32(id));
                ShedUl.ItemsSource = she.GetData();
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
