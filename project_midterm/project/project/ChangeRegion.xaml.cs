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
    /// Interaction logic for ChangeRegion.xaml
    /// </summary>
    public partial class ChangeRegion : Window
    {
        public ChangeRegion()
        {
            InitializeComponent();
        }
        public void change(ref boss c)
        {
            c.Region = int.Parse(region_text.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("با موفقیت انجام شد");
            this.Close();
        }

        private void region_text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
