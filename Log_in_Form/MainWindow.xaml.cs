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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Log_in_Form
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Store_Form storeform = new Store_Form();

            if ((txtUsername.Text == "admin") && (txtPassword.Password == "admin"))
            {
                storeform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or password is in incorrect please try again");
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
        }
    }
}
