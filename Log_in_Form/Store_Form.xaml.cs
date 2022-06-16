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
    /// Interaction logic for Store_Form.xaml
    /// </summary>
    public partial class Store_Form : Window
    {
        store stre = null;
        category categry = null;
        product product;
        public Store_Form()
        {
            InitializeComponent();
            system system = new system();
            cmboStoreform.ItemsSource = system.store;
            //cmboStoreform.DisplayMemberPath = "storeName";
            cmboStoreform.SelectedValuePath = "storeName";
        }

        private void cmboStoreform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (store store in system.store)
            {
                if (store.storeName == cmboStoreform.SelectedValue)
                    stre = store;
            }

            cmboCategoryform.ItemsSource = null;
            cmboCategoryform.ItemsSource = stre.categories;
            //cmboCategoryform.DisplayMemberPath = "CategoryName";
            cmboCategoryform.SelectedValuePath = "CategoryName";

        }

        private void cmboCategoryform_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (store item in system.store)
            {
                if (item.storeName == cmboStoreform.SelectedValue)
                {
                    stre = item;
                    foreach (category itm in stre.categories)
                    {
                        if (itm.CategoryName == cmboCategoryform.SelectedValue)
                        {
                            categry = itm;
                            gviewShowproduct.ItemsSource = null;
                            gviewShowproduct.ItemsSource = categry.products;
                        }

                    }
                }

            }
            //categry.products.Add(product);
            //gviewShowproduct.ItemsSource = null;
            //gviewShowproduct.ItemsSource = categry.products;
        }

        private void ToStore_Click(object sender, RoutedEventArgs e)
        {
            Store st = new Store();
            st.Show();
            this.Hide();
        }

        private void Tocategory_Click(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            category.Show();
            this.Hide();

        }

        private void Toproduct_Click(object sender, RoutedEventArgs e)
        {
            Product prod = new Product();
            prod.Show();
            this.Hide();
        }

        private void ToDistributer_Click(object sender, RoutedEventArgs e)
        {
            Distributer distributer = new Distributer();
            distributer.Show();
            this.Hide();
        }

        private void Tosubblier_Click(object sender, RoutedEventArgs e)
        {
            Supplier sup = new Supplier();
            sup.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
