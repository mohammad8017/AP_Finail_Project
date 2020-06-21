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

namespace project
{
    /// <summary>
    /// Interaction logic for statUp.xaml
    /// </summary>
    public partial class statUp : Window
    {
        public statUp()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            MainWindow customer = new MainWindow();
            customer.Show();
            this.Close();
        }
    }
}
