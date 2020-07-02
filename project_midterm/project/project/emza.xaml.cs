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
    /// Interaction logic for emza.xaml
    /// </summary>
    public partial class emza : Window
    {
        public string Emzaa;
        public string HesabNum;
        public emza()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Emzaa = emzaa_text.Text;
            try
            {
                HesabNum = hesab_text.Text;
                this.Close();
            }
            catch
            {
                MessageBox.Show("فرمت شماره حساب نا درست است");
            }
            
        }

        private void Name_text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
