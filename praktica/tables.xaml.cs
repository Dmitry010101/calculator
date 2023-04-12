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
    /// Логика взаимодействия для tables.xaml
    /// </summary>
    public partial class tables : Window
    {
        tablesTableAdapter TAB = new tablesTableAdapter();
        RESTORANTableAdapter RES = new RESTORANTableAdapter();
        public tables()
        {
            InitializeComponent();
            taBLES.ItemsSource = TAB.GetData();
            cmb5.ItemsSource = RES.GetData();
            cmb5.DisplayMemberPath = "name";
            cmb5.SelectedValuePath = "id";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TAB.InsertQuery(Convert.ToInt32(cmb5.SelectedValue), Convert.ToInt32(tbx1.Text), Convert.ToByte(tbx2.Text));
                taBLES.ItemsSource = TAB.GetData();
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
                object id = (taBLES.SelectedItem as DataRowView).Row[0];
                TAB.DeleteQuery(Convert.ToInt32(id));
                taBLES.ItemsSource = TAB.GetData();
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
                object id = (taBLES.SelectedItem as DataRowView).Row[0];
                TAB.UpdateQuery(Convert.ToInt32(cmb5.SelectedValue), Convert.ToInt32(tbx1.Text), Convert.ToByte(tbx2.Text), Convert.ToInt32(id));
                taBLES.ItemsSource = TAB.GetData();
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
