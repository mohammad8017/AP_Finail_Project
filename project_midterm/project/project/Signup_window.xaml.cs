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
    /// Interaction logic for Signup_window.xaml
    /// </summary>
    // public List<Customer> customer = new List<Customer>();
    public partial class Signup_window : Window
    {
        public static List<Customer> customer = new List<Customer>();

        public Signup_window()
        {
            InitializeComponent();

        }
        public void CreateObj(/*ref List<Customer> customers*/)
        {
            customer.Add(new Customer(name_text.Text, family_text.Text, double.Parse(phone_num_text.Text), email_text.Text, code_text.Text, pass_text.Text));
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateObj();
            bool check = true;

            if (!customer.Last().isValidEmail())
            {
                MessageBox.Show("فرمت ایمیل نادرست است");
                check = false;
            }
            if (pass_text.ToString() != repeat_pass_text.ToString())
            {
                MessageBox.Show("رمز عبور و تکرار آن یکسان نیستند");
                check = false;
            }

            if (check)
            {
                MessageBox.Show("ثبت نام شما با موفقیت انجام شد");
                this.Close();
            }
            else
                MessageBox.Show("ثبت نام شما با مشکل مواجه شد");
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
