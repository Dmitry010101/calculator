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
    /// Логика взаимодействия для employees.xaml
    /// </summary>
    public partial class employees : Window
    {
        employeesTableAdapter emp = new employeesTableAdapter();
        RESTORANTableAdapter rest = new RESTORANTableAdapter();
        public employees()
        {
            InitializeComponent();
            eeee.ItemsSource= emp.GetData();
            cmb5.ItemsSource = rest.GetData();
            cmb5.DisplayMemberPath = "name";
            cmb5.SelectedValuePath = "id";
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                emp.InsertQuery(Convert.ToString(tbx1.Text), Convert.ToString(tbx2.Text),Convert.ToInt32(cmb5.SelectedValue));
                eeee.ItemsSource = emp.GetData();
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
                object id = (eeee.SelectedItem as DataRowView).Row[0];
                emp.DeleteQuery(Convert.ToInt32(id));
                eeee.ItemsSource = emp.GetData();
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
                object id = (eeee.SelectedItem as DataRowView).Row[0];
                emp.UpdateQuery(Convert.ToString(tbx1.Text), Convert.ToString(tbx2.Text), Convert.ToInt32(cmb5.SelectedValue), Convert.ToInt32(id));
                eeee.ItemsSource = emp.GetData();
            }
            catch
            {
                MessageBox.Show("Поле заполнено не правильно");
            }
        }
    }
}
