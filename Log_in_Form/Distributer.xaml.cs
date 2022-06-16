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
    /// Interaction logic for Distributer.xaml
    /// </summary>
    public partial class Distributer : Window
    {
        public Distributer()
        {
            InitializeComponent();
        }
        distributer distrbute;
        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            distrbute = new distributer();
            distrbute.DistributerID = Convert.ToInt32(txtID.Text);
            distrbute.DistributerName = txtName.Text;
            distrbute.DistributerPhone = txtPhone.Text;
            distrbute.DistributerCity = txtCity.Text;
            system.distributers.Add(distrbute);
            gridDistrbute.ItemsSource = null;
            gridDistrbute.ItemsSource = system.distributers;
        }

        private void editBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = gridDistrbute.SelectedIndex;
            distPanel.DataContext = (distributer)gridDistrbute.SelectedItem;
            system.distributers[index].DistributerID = Convert.ToInt32(txtID.Text);
            system.distributers[index].DistributerName = txtName.Text;
            system.distributers[index].DistributerPhone = txtPhone.Text;
            system.distributers[index].DistributerCity = txtCity.Text;
        }

        private void removeBtn_Click(object sender, RoutedEventArgs e)
        {
            int index = gridDistrbute.SelectedIndex;
            system.distributers.Remove(system.distributers[index]);
            gridDistrbute.ItemsSource = null;
            gridDistrbute.ItemsSource = system.distributers;
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            Store_Form stform = new Store_Form();
            stform.Show();
            this.Hide();
        }
    }
}