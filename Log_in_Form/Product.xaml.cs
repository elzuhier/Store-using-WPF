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
    /// Interaction logic for Product.xaml
    /// </summary>
    public partial class Product : Window
    {
        store stre = null;
        category categry = null;
        product product;
        public Product()
        {
            InitializeComponent();
            system system = new system();
            cboStores.ItemsSource = system.store;
            cboStores.DisplayMemberPath = "storeName";
            cboStores.SelectedValuePath = "storeName";




        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            product = new product();
            foreach (store str in system.store)
            {
                if (str.storeName == cboStores.Text)
                {
                    stre = str;
                    foreach (category cat in stre.categories)
                    {
                        if (cat.CategoryName == cboxCategory.SelectedValue)
                            categry = cat;
                    }
                }
            }
            Regex reName = new Regex("^[a-zA-z]");
            if (reName.IsMatch(txtNameProduct.Text))
            {
                product.ProductName = txtNameProduct.Text;
            }
            else
            {
                MessageBox.Show($"Plz Enter Correct Name");
                return;
            }

            //description
            Regex reDescription = new Regex("^[a-zA-z]");
            if (reDescription.IsMatch(txtPDescription.Text))
            {
                product.ProductDescription = txtPDescription.Text;
            }
            else
            {
                MessageBox.Show($"Plz Enter correct Description");
                return;
            }
            //price
            if (Regex.IsMatch(txtPPrice.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only");
                return;

            }
            else
            {
                product.ProductPrice = Convert.ToDouble(txtPPrice.Text);
            }

            //quantity
            if (Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only");
                return;
            }
            else
            {
                product.Quantity = int.Parse(txtQuantity.Text);
            }


            //category
            product.ProductCategory = cboxCategory.Text;
            //add to gridview
            categry.products.Add(product);
            gviewShowProduct.ItemsSource = null;
            gviewShowProduct.ItemsSource = categry.products;
            //stre = null;
            //categry = null;
        }

        private void cboStores_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }


        private void gviewShowProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            foreach (store item in system.store)
            {
                if (item.storeName == cboStores.SelectedValue)
                {
                    stre = item;
                    //catagory
                    foreach (category itm in stre.categories)
                    {
                        if (itm.CategoryName == cboxCategory.SelectedValue)
                            categry = itm;
                    }
                }

            }
            try
            {
                int index = gviewShowProduct.SelectedIndex;
                categry.products.Remove(categry.products[index]);
                gviewShowProduct.ItemsSource = null;
                gviewShowProduct.ItemsSource = categry.products;
                stre = null;
                categry = null;
            }
            catch (Exception)
            {
                MessageBox.Show("Product is Empty");
            }
        }

        private void cboStores_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            foreach (store store in system.store)
            {
                if (store.storeName == cboStores.SelectedValue)
                    stre = store;
            }

            cboxCategory.ItemsSource = null;
            cboxCategory.ItemsSource = stre.categories;
            cboxCategory.DisplayMemberPath = "CategoryName";
            cboxCategory.SelectedValuePath = "CategoryName";

            //stre = null;
        }

        private void btnEdit_Click_1(object sender, RoutedEventArgs e)
        {
            

        }

        private void btnEdit_Click_2(object sender, RoutedEventArgs e)
        {
            int index = gviewShowProduct.SelectedIndex;
            prodPanel.DataContext = (product)gviewShowProduct.SelectedItem;
            foreach (store item in system.store)
            {
                if (item.storeName == cboStores.SelectedValue)
                {
                    stre = item;
                    //category
                    foreach (category itm in stre.categories)
                    {
                        if (itm.CategoryName == cboxCategory.SelectedValue)
                            categry = itm;
                    }
                }

            }
            try
            {
                if (gviewShowProduct.Items.Count > -1)
                {
                    //name
                    Regex reName = new Regex("^[a-zA-z]");
                    if (reName.IsMatch(txtNameProduct.Text))
                    {
                        categry.products[index].ProductName = txtNameProduct.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Plz Enter Correct Name");
                        return;
                    }
                    //description
                    Regex reDescription = new Regex("^[a-zA-z]");
                    if (reDescription.IsMatch(txtPDescription.Text))
                    {
                        categry.products[index].ProductDescription = txtPDescription.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Plz Enter Correct Description");
                        return;
                    }
                    //price
                    if (Regex.IsMatch(txtPPrice.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter numbers only");
                        return;

                    }
                    else
                    {
                        categry.products[index].ProductPrice = Convert.ToDouble(txtPPrice.Text);
                    }
                    //quantity
                    if (Regex.IsMatch(txtQuantity.Text, "[^0-9]"))
                    {
                        MessageBox.Show("Please enter numbers only");
                        return;
                    }
                    else
                        categry.products[index].Quantity = Convert.ToInt32(txtQuantity.Text);

                    categry.products[index].ProductCategory = cboxCategory.Text;
                    gviewShowProduct.ItemsSource = null;
                    gviewShowProduct.ItemsSource = categry.products;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("please enter data first");
            }
            //categry.products[index].ProductName = txtNameProduct.Text;
            //categry.products[index].ProductDescription = txtPDescription.Text;
            //categry.products[index].ProductPrice = Convert.ToDouble(txtPPrice.Text);
            //categry.products[index].Quantity = Convert.ToInt32(txtQuantity.Text);
            //categry.products[index].ProductCategory = cboxCategory.Text;

            gviewShowProduct.ItemsSource = null;
            gviewShowProduct.ItemsSource = categry.products;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Store_Form stform = new Store_Form();
            stform.Show();
            this.Hide();
        }
    }
}