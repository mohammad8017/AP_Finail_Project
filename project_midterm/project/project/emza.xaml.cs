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
        public double HesabNum;
        public emza()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Emzaa = emza_text.Text;
            try
            {
                HesabNum = double.Parse(hesab_text.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("فرمت شماره حساب نا درست است");
            }
            
        }
    }
}
