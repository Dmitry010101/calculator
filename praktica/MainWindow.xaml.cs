using P.tempdbDataSetTableAdapters;
using System.Windows;
using P.msdbDataSetTableAdapters;
namespace P
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LoginDataTableAdapter adapter = new LoginDataTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           var ALLOGINS = adapter.GetData().Rows;
            for (int i =0; i<ALLOGINS.Count; i++)
            {
              if (ALLOGINS[i][1].ToString() == login.Text &&  ALLOGINS[i][2].ToString() == Passwordtbx.Password )
                {
                int roleid = (int)ALLOGINS[i][3];
                    switch(roleid)
                    {
                        case 1:
                            firstrole role = new firstrole();
                            role.Show();
                            break;
                        case 2:
                            SecondRole second = new SecondRole();
                            second.Show();
                            break ;
                    }
                }
            }

        }
    }
}
