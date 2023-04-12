using System;
using System.Data;
using System.Windows;
using Practika3.masterDataSetTableAdapters;


namespace Practika3
{
    public partial class Window1 : Window
    {
        saleTableAdapter sale = new saleTableAdapter();
        buye_rTableAdapter buye_r = new buye_rTableAdapter();
        public Window1()
        {
            InitializeComponent();
            saleDataGrid.ItemsSource = sale.GetData();
            Combo.ItemsSource = sale.GetData();
            Combo.DisplayMemberPath = "date_of_sale";
            Combo.SelectedValuePath = "sale_id";
            Combo1.ItemsSource = buye_r.GetData();
            Combo1.DisplayMemberPath = "name";
            Combo1.SelectedValuePath = "buyer_id";
        }
            

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            qwerty wim = new qwerty();
            wim.Show();
        }


        private void Добавить_Click(object sender, RoutedEventArgs e)
        {
            sale.InsertQuery(Convert.ToInt32(_1stolb.Text),_2stolb.Text, Convert.ToInt32(_3stolb.Text), Convert.ToInt32(Combo.SelectedValue), Convert.ToInt32(Combo1.SelectedValue));
            saleDataGrid.ItemsSource = sale.GetData();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            object id = (saleDataGrid.SelectedItem as DataRowView).Row[0];
            sale.DeleteQuery(Convert.ToInt32(id));
            saleDataGrid.ItemsSource = sale.GetData();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            object id = (saleDataGrid.SelectedItem as DataRowView).Row[0];
            sale.UpdateQuery(Convert.ToInt32(_1stolb.Text), _2stolb.Text, Convert.ToInt32(_3stolb.Text), Convert.ToInt32(Combo1.SelectedValue), Convert.ToInt32(Combo.SelectedValue),  Convert.ToInt32(id));
            saleDataGrid.ItemsSource = sale.GetData();
        }
    }
}
