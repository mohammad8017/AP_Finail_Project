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

namespace project
{
    /// <summary>
    /// Interaction logic for emza.xaml
    /// </summary>
    public partial class emza : Window
    {
        public string Emzaa;
        public string HesabNum;
        public static Customer Hold;
        public emza()
        {
            InitializeComponent();
        }
        public emza(Customer tmp)
        {
            InitializeComponent();
            Hold = tmp;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Emzaa = emzaa_text.Text;
            //HesabNum = hesab_text.Text;
            //MainWindow.HesabNum = this.HesabNum;
            //MainWindow.Emza = Emzaa;
            Hold.Emza = emzaa_text.Text;
            Hold.HesabNum = hesab_text.Text;
            this.Close();
            
        }

        private void Name_text_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
