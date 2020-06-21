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
using System.IO;

namespace project
{
    /// <summary>
    /// Interaction logic for statUp.xaml
    /// </summary>
    public partial class statUp : Window
    {
        public List<boss> bosses = new List<boss>();
        bool first = false;//avalin bar faqat etelaate file ro mikhoone
        public statUp()
        {
            InitializeComponent();
            if (!first)
            {
                StreamReader readInfo = new StreamReader(@"F:\AP\final_project\AP_Finail_Project\project_midterm\project\boss_information.txt");
                readInfo.ReadLine();
                for (int i = 0; readInfo.EndOfStream == false; i++)
                {
                    var holdInfo = readInfo.ReadLine().Split(',');
                    bosses.Add(new boss(holdInfo[0], holdInfo[1], int.Parse(holdInfo[2]), holdInfo[3], holdInfo[4], int.Parse(holdInfo[5]), holdInfo[6]));

                }
                first = true;
            }
            
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            MainWindow customer = new MainWindow();
            customer.Show();
            this.Close();
        }

        private void Boss_Click(object sender, RoutedEventArgs e)
        {
            Modir modir = new Modir();
            modir.Show();
            this.Close();
        }
    }
}
