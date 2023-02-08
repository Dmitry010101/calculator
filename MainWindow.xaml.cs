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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace КрестикиНолики
{
    public partial class MainWindow : Window
    {

        bool bot;
        bool go;

        public MainWindow()
        {
            InitializeComponent();
        }
        private void Newgame_Click(object sender, RoutedEventArgs e)
        {
            b1.Content = "";
            b2.Content = "";
            b3.Content = "";
            b4.Content = "";
            b5.Content = "";
            b6.Content = "";
            b7.Content = "";
            b8.Content = "";
            b9.Content = "";

            b1.IsEnabled = true;
            b2.IsEnabled = true;
            b3.IsEnabled = true;
            b4.IsEnabled = true;
            b5.IsEnabled = true;
            b6.IsEnabled = true;
            b7.IsEnabled = true;
            b8.IsEnabled = true;
            b9.IsEnabled = true;
            Bot2();

        }
        private void Pobeda()
        {
            go = false;
            if (b1.Content.ToString() == "X" && b2.Content.ToString() == "X" && b3.Content.ToString() == "X" ||
                b1.Content.ToString() == "X" && b4.Content.ToString() == "X" && b7.Content.ToString() == "X" ||
                b3.Content.ToString() == "X" && b6.Content.ToString() == "X" && b9.Content.ToString() == "X" ||
                b7.Content.ToString() == "X" && b8.Content.ToString() == "X" && b9.Content.ToString() == "X" ||
                b1.Content.ToString() == "X" && b5.Content.ToString() == "X" && b9.Content.ToString() == "X" ||
                b3.Content.ToString() == "X" && b5.Content.ToString() == "X" && b7.Content.ToString() == "X" ||
                b2.Content.ToString() == "X" && b5.Content.ToString() == "X" && b8.Content.ToString() == "X" ||
                b4.Content.ToString() == "X" && b5.Content.ToString() == "X" && b6.Content.ToString() == "X")
                MessageBox.Show("Крестики выиграли!!");
            else if (b1.Content.ToString() == "O" && b2.Content.ToString() == "O" && b3.Content.ToString() == "O" ||
                b1.Content.ToString() == "O" && b4.Content.ToString() == "O" && b7.Content.ToString() == "O" ||
                b3.Content.ToString() == "O" && b6.Content.ToString() == "O" && b9.Content.ToString() == "O" ||
                b7.Content.ToString() == "O" && b8.Content.ToString() == "O" && b9.Content.ToString() == "O" ||
                b1.Content.ToString() == "O" && b5.Content.ToString() == "O" && b9.Content.ToString() == "O" ||
                b3.Content.ToString() == "O" && b5.Content.ToString() == "O" && b7.Content.ToString() == "O")
                MessageBox.Show("Нолики выиграли!!");
            else if (b1.Content.ToString() != "" && b2.Content.ToString() != "" && b3.Content.ToString() != "" && b4.Content.ToString() != "" && b5.Content.ToString() != "" && b6.Content.ToString() != "" && b7.Content.ToString() != "" && b8.Content.ToString() != "" && b9.Content.ToString() != "")
            {
                MessageBox.Show("Ничья!!");
            }
            else go = true;

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Button? bu = sender as Button;
            if (bu.Content.ToString() == "" && go)
            {
                bot = true;
                bu.Content = "X";

            }
            Pobeda();
            Bot2();
            Pobeda();
        }



        private void Bot2()
        {
            long i = 0;
            Random rand = new Random();
            while (bot & i < 100000000)
            {
                i++;
                switch (rand.Next(1, 9))
                {
                    case 1:
                        if (b1.Content.ToString() == "")
                        {
                            b1.Content = "O";
                            bot = false;
                        }
                        break;
                    case 2:
                        if (b2.Content.ToString() == "")
                        {
                            b2.Content = "O";
                            bot = false;
                        }
                        break;
                    case 3:
                        if (b3.Content.ToString() == "")
                        {
                            b3.Content = "O";
                            bot = false;
                        }
                        break;
                    case 4:
                        if (b4.Content.ToString() == "")
                        {
                            b4.Content = "O";
                            bot = false;
                        }
                        break;
                    case 5:
                        if (b5.Content.ToString() == "")
                        {
                            b5.Content = "O";
                            bot = false;
                        }
                        break;
                    case 6:
                        if (b6.Content.ToString() == "")
                        {
                            b6.Content = "O";
                            bot = false;
                        }
                        break;
                    case 7:
                        if (b7.Content.ToString() == "")
                        {
                            b7.Content = "O";
                            bot = false;
                        }
                        break;
                    case 8:
                        if (b8.Content.ToString() == "")
                        {
                            b8.Content = "O";
                            bot = false;
                        }
                        break;
                    case 9:
                        if (b9.Content.ToString() == "")
                        {
                            b9.Content = "O";
                            bot = false;
                        }
                        break;
                }
            }
            bot = false;
        }

    }
}