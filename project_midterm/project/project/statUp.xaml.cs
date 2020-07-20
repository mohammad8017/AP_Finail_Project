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
using System.Data;
using System.Data.SqlClient;

namespace project
{
    /// <summary>
    /// Interaction logic for statUp.xaml
    /// </summary>
    public partial class statUp : Window
    {
        public static List<boss> bosses = new List<boss>();
        bool first = false;//avalin bar faqat etelaate file ro mikhoone
        
        public statUp()
        {
            InitializeComponent();
            if (!first)
            {
                //StreamReader readInfo = new StreamReader(@"F:\AP\final_project\AP_Finail_Project\project_midterm\project\boss_information.txt");
                //readInfo.ReadLine();
                //for (int i = 0; readInfo.EndOfStream == false; i++)
                //{
                //    var holdInfo = readInfo.ReadLine().Split(',');
                //    bosses.Add(new boss(holdInfo[0], holdInfo[1], int.Parse(holdInfo[2]), holdInfo[3], holdInfo[4], int.Parse(holdInfo[5]), holdInfo[6]));

                //}
                //readInfo.Close();
                //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\AP\final_project\AP_Finail_Project\project_midterm\project\project\AdminData.mdf;Integrated Security=True";
                //C:\USERS\LENOVO\DESKTOP\NEW FOLDER (2)\AP_FINAIL_PROJECT\PROJECT_MIDTERM\PROJECT\PROJECT\ADMINDATA.MDF
                string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\LENOVO\DESKTOP\NEW FOLDER (2)\AP_FINAIL_PROJECT\PROJECT_MIDTERM\PROJECT\PROJECT\ADMINDATA.MDF;Integrated Security=True";
                SqlConnection Connection = new SqlConnection(connectionString);
                Connection.Open();
                SqlCommand Command = new SqlCommand("SELECT * FROM [Table]", Connection);
                SqlDataReader sqlDataReader = Command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    string name = sqlDataReader.GetValue(2).ToString();
                    string family = sqlDataReader.GetValue(3).ToString();
                    int code = (int)sqlDataReader.GetValue(0);
                    string pass = sqlDataReader.GetValue(1).ToString();
                    string address = sqlDataReader.GetValue(5).ToString();
                    int region = (int)sqlDataReader.GetValue(4);
                    string type = sqlDataReader.GetValue(6).ToString();
                    bosses.Add(new boss(name, family, code, pass, address, region, type));
                }
                sqlDataReader.Close();
                Command.Dispose();
                Connection.Close();

                first = true;
            }
            
        }

        private void Customer_Click(object sender, RoutedEventArgs e)
        {
            bool signIn = false;
            for (int i = 0; i < bosses.Count; i++)
            {
                if (bosses[i].signInNum > 0)
                    signIn = true;
            }
            if (!signIn)
                MessageBox.Show("هیچ ادمینی تا الآن وارد نشده");
            else
            {
                MainWindow customer = new MainWindow();
                customer.Show();
                this.Close();
            }
            
        }

        private void Boss_Click(object sender, RoutedEventArgs e)
        {
            Modir modir = new Modir();
            modir.Show();
            this.Close();
        }
    }
}
