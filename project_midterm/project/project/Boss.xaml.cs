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
using System.Windows.Shapes;
using Microsoft.Win32;

namespace project
{
    /// <summary>
    /// Interaction logic for Boss.xaml
    /// </summary>
    
    public partial class Modir : Window
    {
        public boss Hold = new boss();
        public bool signIn = false;
        public Modir()
        {
            InitializeComponent();
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

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            statUp t = new statUp();
            for(int i = 0; i < t.bosses.Count; i++)
            {
                if (int.Parse(codeText.Text) == t.bosses[i].Code && passText.Text == t.bosses[i].Pass)
                {
                    Hold = t.bosses[i];
                    signIn = true;
                    check = true;
                }
                    
            }
            if (check)
                MessageBox.Show("شما وارد حساب خود شدید");
            else
                MessageBox.Show("کلمه عبور یا ایمیل نادرست است");
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

        private void type_change_Click(object sender, RoutedEventArgs e)
        {
            ChangeType change = new ChangeType();
            change.Show();
            change.change(ref Hold);
        }

        private void Phone_change_Click(object sender, RoutedEventArgs e)
        {
            ChangeRegion change = new ChangeRegion();
            change.Show();
            change.change(ref Hold);
        }

        private void CodeTex_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PassText_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn5_Click(object sender, RoutedEventArgs e)
        {
            if (signIn)
                tabControl.SelectedItem = tab2;
            else
                MessageBox.Show("شما هنوز وارد حساب خود نشده اید");
        }

        private void Btn8_Click(object sender, RoutedEventArgs e)
        {
            statUp start = new statUp();
            MessageBox.Show("شما از حساب خود خارج شدید");
            start.Show();
            this.Close();
        }

        private void Btn6_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tab1;
        }
    }
}
