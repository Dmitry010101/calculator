using P.tempdbDataSetTableAdapters;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для LoginData.xaml
    /// </summary>
    public partial class LoginData : Window
    {
        LoginDataTableAdapter l = new LoginDataTableAdapter();
        RoleTableAdapter r = new RoleTableAdapter();
        public LoginData()
        {
            InitializeComponent();
            logo.ItemsSource = l.GetData();
            tbx2.ItemsSource = r.GetData();
            tbx2.DisplayMemberPath = "name";
            tbx2.SelectedValuePath = "id";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                l.InsertQuery(Convert.ToString(tbx.Text), Convert.ToInt32(tbx1.Text), Convert.ToInt32(tbx2.SelectedValue));
                logo.ItemsSource = l.GetData();
            }
            catch
            {
                MessageBox.Show("Поле не должно быть пустым");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
            firstrole secon = new firstrole();
            secon.Show();
        }
    }
}
