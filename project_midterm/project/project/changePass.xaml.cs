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
    /// Interaction logic for changePass.xaml
    /// </summary>
    public partial class changePass : Window
    {
        private bool check = false;
        public changePass()
        {
            InitializeComponent();
        }
        public void change(ref Customer c)
        {
            if (repass_text.Text == (pass_text.Text))
            {
                c.Pass = pass_text.Text;
                check = true;
            }
        }
        public void change(ref boss b)
        {
            int sedaDar = 0;
            string okPass = "";
            for(int i = 0; i < b.signInNum % 10; i++)
            {
                okPass += "1";
            }
            foreach(var tmp in b.Username)
            {
                if(tmp.Equals('a') || tmp.Equals('e') || tmp.Equals('i') || tmp.Equals('o') || tmp.Equals('u') || tmp.Equals('A') || tmp.Equals('E') || tmp.Equals('I') || tmp.Equals('O') || tmp.Equals('U'))
                {
                    sedaDar++;
                }
            }
            for (int i = 0; i < sedaDar; i++)
            {
                okPass += "0";
            }
            if (pass_text.Text != okPass && repass_text.Text == (pass_text.Text))
            {
                b.Pass = pass_text.Text;
                check = true;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!check)
            {
                MessageBox.Show("کلمه عبور و تکرار آن یکسان نیستند و یا فرمت کلمه عبور قابل قبول نیست");
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
