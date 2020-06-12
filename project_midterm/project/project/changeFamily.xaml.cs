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
    /// Interaction logic for changeFamily.xaml
    /// </summary>
    public partial class changeFamily : Window
    {
        public changeFamily()
        {
            InitializeComponent();
        }

        public void change(ref Customer c)
        {
            c.Family = family_text.Text;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("با موفقیت انجام شد");
            this.Close();
        }

        private void Name_text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
