﻿using praktica.ExampleDBDataSetTableAdapters;
using System.Windows;


namespace praktica
{
    public partial class Window1 : Window
    {
        salesTableAdapter sales = new salesTableAdapter();
        public Window1()
        {
            InitializeComponent();
            salesDataGrid.ItemsSource = sales.GetData();
        }
    }
}
