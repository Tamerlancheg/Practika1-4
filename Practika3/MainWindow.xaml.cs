using System;
using System.Data;
using System.Windows;
using Practika3.masterDataSetTableAdapters;

namespace Practika3
{
    public partial class MainWindow : Window
    {
        buye_rTableAdapter buye_r = new buye_rTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            buye_rDataGrid.ItemsSource = buye_r.GetData();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wim = new Window1();
            wim.Show();
        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            buye_r.InsertQuery(Convert.ToInt32(Text1.Text),Text2.Text, Text3.Text, Text4.Text);
            buye_rDataGrid.ItemsSource = buye_r.GetData();
        }

  
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (buye_rDataGrid.SelectedItem as DataRowView).Row[0];
            buye_r.DeleteQuery(Convert.ToInt32(id));
            buye_rDataGrid.ItemsSource = buye_r.GetData();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            object id = (buye_rDataGrid.SelectedItem as DataRowView).Row[0];
            buye_r.UpdateQuery(Convert.ToInt32(Text1.Text), Text3.Text, Text2.Text, Convert.ToString(Text4.Text), Convert.ToInt32(id));
            buye_rDataGrid.ItemsSource = buye_r.GetData();
        }
    }
}

