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
using Microsoft.Win32;

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool signIn = false;
        //public List<Customer> customers = new List<Customer>();
        public Customer Hold = new Customer();
        public MainWindow()
        {
            InitializeComponent();

            DateTime d;
            d = DateTime.Now;
            label1.Content = d.Hour + " : " + d.Minute + " : " + d.Second;

            //Signup_window window = new Signup_window();
            //window.CreateObj();
            //customers.Add(new Customer(window.name_text.Text, window.family_text.Text, double.Parse(window.phone_num_text.Text), window.email_text.Text, double.Parse(window.phone_num_text.Text), window.pass_text.Text));
            
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show($"{Signup_window.customer.Count()}");
            bool check = false;
            for (int i = 0; i < Signup_window.customer.Count; i++)
            {
                if (emailText.Text.Equals(Signup_window.customer[i].Email) && passText.Text.Equals(Signup_window.customer[i].Pass))
                {
                    check = true;
                    signIn = true;
                    //Hold = Signup_window.customer[i];
                    Hold.Name = Signup_window.customer[i].Name;
                    Hold.Family = Signup_window.customer[i].Family;
                    Hold.PhoneNum = Signup_window.customer[i].PhoneNum;
                    Hold.NationalCode = Signup_window.customer[i].NationalCode;
                    Hold.Email = Signup_window.customer[i].Email;
                    Hold.Pass = Signup_window.customer[i].Pass;
                }  
            }
            if (check)
                MessageBox.Show("شما وارد حساب خود شدید");
            else
                MessageBox.Show("کلمه عبور یا ایمیل نادرست است");

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("");
        }

        private void Btn4_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("");
            Signup_window sign_up = new Signup_window();
            sign_up.Show();
            
        }


        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (signIn)
                tabControl.SelectedItem = tab2;
            else
                MessageBox.Show("شما هنوز وارد حساب خود نشده اید");
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tab1;
        }

        private void Btn11_Click(object sender, RoutedEventArgs e)
        {
            System.Globalization.PersianCalendar p1 = new System.Globalization.PersianCalendar();
            txt11.Text = p1.GetYear(DateTime.Now).ToString() + "/" + p1.GetMonth(DateTime.Now).ToString("0#") + "/" + p1.GetDayOfMonth(DateTime.Now).ToString("0#");
        }

        private void Btn22_Click(object sender, RoutedEventArgs e)
        {
            txt22.Text = DateTime.Now.ToLongTimeString();
        }

        //private void Timer_Click(object sender, EventArgs e)

        //{

        //    DateTime d;

        //    d = DateTime.Now;

        //    label1.Content = d.Hour + " : " + d.Minute + " : " + d.Second;

        //}

        private void Btn7_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            statUp start = new statUp();
            MessageBox.Show("شما از حساب خود خارج شدید");
            start.Show();
            this.Close();
            
        }

 
        private void Name_change_Click(object sender, RoutedEventArgs e)
        {
            changeName change = new changeName();
            change.Show();
            change.change(ref Hold);
        }

        private void Family_change_Click(object sender, RoutedEventArgs e)
        {
            changeFamily change = new changeFamily();
            change.Show();
            change.change(ref Hold);
        }

        private void Phone_change_Click(object sender, RoutedEventArgs e)
        {
            changePhone change = new changePhone();
            change.Show();
            change.change(ref Hold);
        }

        private void Pass_change_Click(object sender, RoutedEventArgs e)
        {
            changePass change = new changePass();
            change.Show();
            change.change(ref Hold);
        }

        private void EmailText_TextChanged(object sender, TextChangedEventArgs e)
        {
            changeEmail change = new changeEmail();
            change.Show();
            change.change(ref Hold);
        }

        private void EmailTex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void upload_image_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "تصویر را انتخاب کنید";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                imgPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void Test_Click(object sender, RoutedEventArgs e)
        {
            string tmp = caledar.SelectedDate.Value.Date.ToShortDateString();// ToString();
            MessageBox.Show(tmp);
        }
    }
}
