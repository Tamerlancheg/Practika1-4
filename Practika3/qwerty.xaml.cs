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
using System.Xml.Linq;
using Practika3.masterDataSetTableAdapters;
using static System.Net.Mime.MediaTypeNames;

namespace Practika3
{
    public partial class qwerty : Window
    {
        supplierTableAdapter supplier = new supplierTableAdapter();
        public qwerty()
        {
            InitializeComponent();
            supplierDataGrid.ItemsSource = supplier.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            supplier.InsertQuery(Convert.ToInt32(T1.Text), Convert.ToInt32(T2.Text),T3.Text);
           supplierDataGrid.ItemsSource = supplier.GetData();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (supplierDataGrid.SelectedItem as DataRowView).Row[0];
            supplier.DeleteQuery(Convert.ToInt32(id));
            supplierDataGrid.ItemsSource = supplier.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (supplierDataGrid.SelectedItem as DataRowView).Row[0];
            supplier.UpdateQuery(Convert.ToInt32(T1.Text), Convert.ToInt32(T2.Text), Convert.ToString(T3.Text),Convert.ToInt32(id));
            supplierDataGrid.ItemsSource = supplier.GetData();
        }
    }
}

