﻿using System;
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

namespace project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public List<Customer> customers = new List<Customer>();
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
                    check = true;
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
            tabControl.SelectedItem = tab2;
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
            this.Close();
            
        }
    }
}
