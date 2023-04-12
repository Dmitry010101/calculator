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
    /// Логика взаимодействия для supplies.xaml
    /// </summary>
    public partial class supplies : Window
    {
        suppliesTableAdapter spp = new suppliesTableAdapter();
        suppliersTableAdapter sp = new suppliersTableAdapter();
        RESTORANTableAdapter res = new RESTORANTableAdapter();
        dishesTableAdapter dishes = new dishesTableAdapter();
        public supplies()
        {
            InitializeComponent();
            Sup.ItemsSource=spp.GetData();
            cmb5.ItemsSource=sp.GetData();
            cmb5.DisplayMemberPath = "name";
            cmb5.SelectedValuePath = "id";
            cmb6.ItemsSource=res.GetData();
            cmb6.DisplayMemberPath="name";
            cmb5.SelectedValuePath = "id";
            cmb7.ItemsSource=dishes.GetData();
            cmb7.DisplayMemberPath="name";
            cmb5.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           try
            {
                spp.InsertQuery(Convert.ToInt32(cmb5.SelectedValue), Convert.ToInt32(cmb7.SelectedValue), Convert.ToInt32(cmb6.SelectedValue), Convert.ToInt32(tbx1.Text), Convert.ToString(tbx2.Text));
                Sup.ItemsSource = spp.GetData();
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
                object id = (Sup.SelectedItem as DataRowView).Row[0];
                spp.DeleteQuery(Convert.ToInt32(id));
                Sup.ItemsSource = spp.GetData();
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
                object id = (Sup.SelectedItem as DataRowView).Row[0];
                spp.UpdateQuery(Convert.ToInt32(cmb5.SelectedValue), Convert.ToInt32(cmb7.SelectedValue), Convert.ToInt32(cmb6.SelectedValue), Convert.ToInt32(tbx1.Text), Convert.ToString(tbx2.Text), Convert.ToInt32(id));
                Sup.ItemsSource = spp.GetData();
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
