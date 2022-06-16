using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Store.xaml
    /// </summary>
    public partial class Store : Window
    {

        public Store()
        {
            InitializeComponent();
        }
        store store;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Store_Form stform = new Store_Form();
            stform.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            store = new store();
            Regex reName = new Regex("^[a-zA-z]");
            if (reName.IsMatch(StoreName.Text))
            {
                store.storeName = StoreName.Text;
            }
            else
            {
                MessageBox.Show($"Plz Enter Correct Location");
                return;
            }

            if (StoreName.Text == "")
            {
                MessageBox.Show("Location is Empty");
            }
            system.store.Add(store);
            StoreName.Text = "";

        }
    }
}
