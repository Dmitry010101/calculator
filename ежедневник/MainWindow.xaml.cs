using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
namespace Ejednevnik
{
    public partial class MainWindow : Window
    {
        string data;
        readonly List<Zametka> zametki1 = new List<Zametka>();
        readonly List<Zametka> zametki2 = new List<Zametka>();
#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public MainWindow() => InitializeComponent();
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        private void Clear() 
        {
            NZ.Text = "";
            Opisanie.Text = "";
        }
        private void Conclusion()
        {
            zametki1.Clear();
            foreach (Zametka i in zametki2)
            {
                if (i.data == data)
                {
                    zametki1.Add(i);
                    Z.Items.Add(i.name);
                }
            }
        }
        private void Add(object sender, RoutedEventArgs e)
        {
             Zametka new_zam = new(NZ.Text, Opisanie.Text, DP.Text);
             zametki2.Add(new_zam);
             Z.Items.Add(new_zam.name);
             zametki1.Add(new_zam);
             Clear();
        }
        private void Delete(object sender, RoutedEventArgs e)
        {
            Clear();
        }
        private void SelectedDate(object sender, SelectionChangedEventArgs e)
        {
            data = DP.Text;
            Clear();
            foreach (Zametka i in zametki1)
            {
                Z.Items.Remove(i.name);
            }
            Conclusion();
        }
        private void Selection(object sender, SelectionChangedEventArgs e)
        {
            int RZ = 0;
            if (Z.SelectedIndex != -1)
            {
                NZ.Text = zametki1[RZ].name;
                Opisanie.Text = zametki1[RZ].opis;
            }
        }
    }
}