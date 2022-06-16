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

namespace Log_in_Form
{
    /// <summary>
    /// Interaction logic for Supplier.xaml
    /// </summary>
    public partial class Supplier : Window
    {
        public Supplier()
        {
            InitializeComponent();
        }
        supplier sup;
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            sup = new supplier();
            sup.SupplierID = Convert.ToInt32(TxtSupplierID.Text);
            sup.SupplierName = TxtSupplierName.Text;
            sup.SupplierPhone = TxtSupplierPhone.Text;
            sup.City = TxtSupplierCity.Text;
            system.suppliers.Add(sup);
            gridsupplier.ItemsSource = null;
            gridsupplier.ItemsSource = system.suppliers;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            Suppanel.DataContext = (supplier)gridsupplier.SelectedItem;


            int index = gridsupplier.SelectedIndex;
            Suppanel.DataContext = (supplier)gridsupplier.SelectedItem;
            system.suppliers[index].SupplierID = Convert.ToInt32(TxtSupplierID.Text);
            system.suppliers[index].SupplierName = TxtSupplierName.Text;
            system.suppliers[index].SupplierPhone = TxtSupplierPhone .Text;
            system.suppliers[index].City =TxtSupplierCity.Text;
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            

            int index = gridsupplier.SelectedIndex;
            system.suppliers.Remove(system.suppliers[index]);
            gridsupplier.ItemsSource = null;
            gridsupplier.ItemsSource = system.suppliers;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Store_Form stform = new Store_Form();
            stform.Show();
            this.Hide();
        }
    }
}
