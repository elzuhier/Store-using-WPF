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
    /// Interaction logic for Category.xaml
    /// </summary>
    public partial class Category : Window
    {

        category GetCategory;
        public Category()
        {
            InitializeComponent();
            cboxStore.ItemsSource = system.store;
            cboxStore.SelectedValuePath = "storeName";


        }
        store store = null;
        //category cte = null;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GetCategory = new category();
            //view store
            try
            {
                foreach (store item in system.store)
                {
                    if (item.storeName == cboxStore.SelectedValue)
                    {
                        store = item;
                    }

                }
                //id
                category LastItem = null;
                //if (store.categories.Count != 0)
                //{
                //    LastItem = store.categories.Last();
                //}
                if (LastItem != null)
                    GetCategory.ID = LastItem.ID + 1;
                //**name**
                Regex reName = new Regex("^[a-zA-z]");
                if (reName.IsMatch(Name.Text))
                {
                    GetCategory.CategoryName = Name.Text;
                }
                else
                {
                    MessageBox.Show($"Plz Enter Correct Name");
                    return;
                }
                //description

                Regex reDescription = new Regex("^[a-zA-z]");
                if (reDescription.IsMatch(Description.Text))
                {
                    GetCategory.CategoryDescription = Description.Text;

                }
                else
                {
                    MessageBox.Show($"Plz Enter Correct description");
                    return;
                }
                //ensure cateogry is not exist
                foreach (var item in store.categories)
                {

                    if (item.CategoryName.Equals(Name.Text))
                    {
                        MessageBox.Show("Item is Exist");
                        Name.Text = "";
                        Description.Text = "";
                        return;
                    }
                }
                //add to gridview

                store.categories.Add(GetCategory);
                datagridCategory.ItemsSource = null;
                datagridCategory.ItemsSource = store.categories;

                Name.Text = "";
                Description.Text = "";
                store = null;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"{ex.Message} \t Please Enter Correct Data");

            }

        }

        private void listBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {

            int index = datagridCategory.SelectedIndex;
            categoryPanel.DataContext = (category)datagridCategory.SelectedItem;

            foreach (var item in system.store)
            {
                if (item.storeName == cboxStore.Text)
                {
                    store = item;
                }
            }
            try
            {
                if (datagridCategory.Items.Count > -1)
                {
                    Regex reName = new Regex("^[a-zA-z]");
                    if (reName.IsMatch(Name.Text))
                    {
                        store.categories[index].CategoryName = Name.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Plz Enter Correct Name");
                        return;
                    }
                    Regex reDescription = new Regex("^[a-zA-z]");
                    if (reDescription.IsMatch(Description.Text))
                    {
                        store.categories[index].CategoryDescription = Description.Text;
                    }
                    else
                    {
                        MessageBox.Show($"Plz Enter Correct Description");
                        return;
                    }
                    datagridCategory.ItemsSource = null;
                    datagridCategory.ItemsSource = store.categories;

                }
                store = null;
            }
            catch (Exception)
            {
                MessageBox.Show("please enter data first");
            }
        }

        private void Remove_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //store
                foreach (store item in system.store)
                {
                    if (item.storeName == cboxStore.Text)
                    {
                        store = item;

                    }
                }
                //**vaildate**
                int index = datagridCategory.SelectedIndex;
                store.categories.Remove(store.categories[index]);
                datagridCategory.ItemsSource = null;
                datagridCategory.ItemsSource = store.categories;
            }

            catch (Exception)
            {
                MessageBox.Show("Category is Empty");
            }
        }

        private void lboxCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Store_Form stform = new Store_Form();
            stform.Show();
            this.Hide();
        }
    }
}