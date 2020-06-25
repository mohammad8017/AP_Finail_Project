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
    /// Interaction logic for ChangeUsername.xaml
    /// </summary>
    public partial class ChangeUsername : Window
    {
        private bool check = false;
        public ChangeUsername()
        {
            InitializeComponent();
        }
        public void change(ref boss b)
        {
            if (user_text.Text.Contains("admin") == true)
            {
                b.Username = user_text.Text;
                check = true;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("فرمت نام کاربری قابل قبول نیست");
            }
            else
            {
                MessageBox.Show("با موفقیت انجام شد");

            }
            this.Close();
        }

        private void Name_text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
