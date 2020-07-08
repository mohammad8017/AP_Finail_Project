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
        //public Customer customer;
        public Customer Hold = new Customer();
        public List<Food> sabadKharid = new List<Food>();
        public List<Food> source = new List<Food>();
        public List<Food> allFood = Modir.foodTemp;
        //public List<Food> allFood2 = Modir.foodTemp;
        public List<ImageSource> foodPhoto = Modir.foodImage;
        public static string Emza;
        public static string HesabNum;
        public static double daramad;
        public static double hazine;
        public bool pardakht = false;
        public MainWindow()
        {
            InitializeComponent();

            DateTime d;
            d = DateTime.Now;
            label1.Content = d.Hour + " : " + d.Minute + " : " + d.Second;

            txtAuto.TextChanged += new TextChangedEventHandler(txtAuto_TextChanged);
            //statUp nnn = new statUp();

            //source.Add(new Food("pizza", 12000, 3000, "morgh", 23, 6, 30, 2020));
            //dataGrid.ItemsSource = source;


            //dataGrid.ItemsSource = nnn.bosses;

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
                    holdName.Content = Hold.Name + " " + Hold.Family;
                }  
            }
            if (check)
            {
                
                MessageBox.Show("شما وارد حساب خود شدید");
            }   
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
            
            for (int i = 0; i < allFood.Count; i++)
            {
                var temp = caledar.SelectedDate.Value.Date.ToShortDateString();
                if (temp.Equals(allFood[i].date.ToShortDateString()))
                    source.Add(allFood[i]);
            }
            dataGrid.ItemsSource = source;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            var tmp = dataGrid.SelectedCells;
            //MessageBox.Show((tmp[0].Column.GetCellContent(tmp[0].Item) as TextBlock).Text);
            var holdName = (tmp[0].Column.GetCellContent(tmp[0].Item) as TextBlock).Text;
            for(int i = 0; i < source.Count; i++)
            {
                if (source[i].Name.Equals(holdName))
                {
                    if (source[i].Mojoodi == 0)
                    {
                        MessageBox.Show("متاسفم غذاهای امروز به پایان رسیده است لطفا روزدیگری را امتحان کنید");

                    }
                    else
                    {
                        sabadKharid.Add(source[i]);
                        sabadKharid[sabadKharid.Count - 1].Mojoodi = 1;
                        MessageBox.Show($"به سبد خرید شما اضافه شد{holdName}");
                        //source[i].Mojoodi--;
                        //for (int j = 0; j < allFood.Count; j++)
                        //{
                        //    if (allFood[j].Name.Equals(holdName))
                        //        allFood[j].Mojoodi--;
                        //}
                    }
                }
            }
            dataSabad.ItemsSource = sabadKharid;
            //if(int.Parse(tmp[tmp.Count-1].ToString))
        }

        private void ChangeNum_Click(object sender, RoutedEventArgs e)
        {
            if (newNum.Text != null)
            {
                var tmp = dataSabad.SelectedCells;
                string holdName = "s";
                try
                {
                    holdName = (tmp[0].Column.GetCellContent(tmp[0].Item) as TextBlock).Text;
                }
                catch
                {
                    MessageBox.Show("غذا انتخاب نشده");
                }
                for (int i = 0; i < sabadKharid.Count; i++)
                {
                    if (sabadKharid[i].Name.Equals(holdName))
                    {
                        //MessageBox.Show("1");

                        for (int j = 0; j < allFood.Count; j++)
                        {
                            if (allFood[j].Name.Equals(holdName))
                            {
                                //MessageBox.Show("2");
                                //allFood[j].Mojoodi += sabadKharid[i].Mojoodi;
                                //if(int.Parse(newNum.Text) > allFood[j].Mojoodi)
                                //{
                                //    MessageBox.Show("مقدار انتخابی بیشتر از مقدار موجود است");
                                //}
                                //else
                                //{
                                //    allFood[j].Mojoodi -= int.Parse(newNum.Text);
                                //    sabadKharid[i].Mojoodi = int.Parse(newNum.Text);

                                //    dataSabad.ItemsSource = sabadKharid;
                                //    MessageBox.Show($"تعداد تغییر یافت");
                                //} 
                                allFood[j].Mojoodi -= int.Parse(newNum.Text);
                                sabadKharid[i].Mojoodi = int.Parse(newNum.Text);

                                dataSabad.ItemsSource = sabadKharid;
                                MessageBox.Show($"تعداد تغییر یافت");

                            }     
                        }
                    }
                }
            }
            else
                MessageBox.Show($"تعداد جدید وارد نشده است");

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var tmp = dataSabad.SelectedCells;
            var holdName = (tmp[0].Column.GetCellContent(tmp[0].Item) as TextBlock).Text;
            for (int i = 0; i < sabadKharid.Count; i++)
            {
                if (sabadKharid[i].Name.Equals(holdName))
                {
                    
                    for(int j = 0; j < allFood.Count; j++)
                    {
                        if (sabadKharid[i].Name.Equals(allFood[j].Name))
                        {
                            allFood[j].Mojoodi += sabadKharid[i].Mojoodi;
                        }
                    }
                    sabadKharid.RemoveAt(i);
                    //dataSabad.ItemsSource = sabadKharid;
                    MessageBox.Show($"غذای انتخابی از سبد حذف شد");
                }
            }
            dataSabad.ItemsSource = sabadKharid;
        }

        private void Finish_Click(object sender, RoutedEventArgs e)
        {
            emza tmp = new emza();
            tmp.Show();

            //HesabNum = tmp.hesab_text.Text;
            //Emza = tmp.emzaa_text.Text;
            holdDate.Content = DateTime.Now.Date.ToShortDateString();

            List<FoodFactor> holdd = new List<FoodFactor>(sabadKharid.Count);
            double sum = 0;
            double kharj = 0;
            for (int i = 0; i < sabadKharid.Count; i++)
            {
                holdd.Add(new FoodFactor(sabadKharid[i].Name, sabadKharid[i].Mojoodi * (sabadKharid[i].FinishPrice * 1.24), sabadKharid[i].Mojoodi));
                sum += sabadKharid[i].Mojoodi * (sabadKharid[i].FinishPrice * 1.24);
                kharj += sabadKharid[i].Mojoodi * sabadKharid[i].RealPrice;
            }
            daramad = sum;
            hazine = kharj;
            factor.ItemsSource = holdd;
            holdPrice_Copy.Content = sum.ToString();
            holdHesab.Content = HesabNum;
            hold_emza.Content = Emza;
            tabControl.SelectedItem = tab5;
        }

        private void Test_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Sabt_Click(object sender, RoutedEventArgs e)
        {
            tabControl.SelectedItem = tab3;
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.PrintDialog Printdlg = new System.Windows.Controls.PrintDialog();

            if ((bool)Printdlg.ShowDialog().GetValueOrDefault())
            {

                //you can set your own precise size here

                Printdlg.PrintVisual(tab5, "فاکتور");

            }
        }

        private void Hozoori_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ممنون از خرید شما");
        }

        private void Online_Click(object sender, RoutedEventArgs e)
        {
            pardakht = true;
            MessageBox.Show(" از حساب شما مبلغ"+ daramad +" تومان کسر شد" + "\n");
            MessageBox.Show("ممنون از خرید شما");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < sabadKharid.Count; i++)
            {
                for (int j = 0; j < allFood.Count; j++)
                {
                    if (sabadKharid[i].Name.Equals(allFood[j].Name) && sabadKharid[i].date.Equals(allFood[j].date))
                    {
                        allFood[j].Mojoodi += sabadKharid[i].Mojoodi;
                        sabadKharid.RemoveAt(i);
                    }
                }
            }

            if (pardakht)
            {
                MessageBox.Show(" سفارش شما کنسل شد و به حساب شما مبلغ" + daramad*0.9 + " تومان بازگشت و 10 درصد یه عنوان مالیات کم شد" + "\n");
            }
            else
            {
                MessageBox.Show(" سفارش شما کنسل شد و لطفا" + daramad * 0.1 + " تومان یه عنوان مالیات پرداخت کنید" + "\n");
            }
            
            dataSabad.ItemsSource = sabadKharid;
            MessageBox.Show("سفارش لغو شد");
            tabControl.SelectedItem = tab3;
        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {
            var tmp = dataSabad.SelectedCells;
            string holdName = "s";
            try
            {
                holdName = (tmp[0].Column.GetCellContent(tmp[0].Item) as TextBlock).Text;
            }
            catch
            {
                MessageBox.Show("غذا انتخاب نشده");
            }
            for(int i = 0; i < allFood.Count; i++)
            {
                if (allFood[i].Name.Equals(holdName))
                {
                    if (allFood[i].PrivateInfo != "")
                        MessageBox.Show(allFood[i].PrivateInfo);
                    else
                        MessageBox.Show("اطلاعات خاص ثبت نشده");
                }
                    
            }
            

        }

        private void DataSabad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txtAuto_TextChanged(object sender, TextChangedEventArgs e)
        {
            string typedString = txtAuto.Text;
            List<string> autoList = new List<string>();
            autoList.Clear();

            foreach(var item in allFood)
            {
                if (!string.IsNullOrEmpty(txtAuto.Text))
                {
                    if (item.Name.Contains(typedString))
                    {
                        autoList.Add(item.Name);
                    }
                    else if (item.Info.Contains(typedString))
                    {
                        autoList.Add(item.Info);
                    }
                    else if (item.FinishPrice.ToString().Contains(typedString))
                    {
                        autoList.Add(item.FinishPrice.ToString());
                    }
                    else {; }
                }
            }
            suggestion.ItemsSource = autoList;
            //if (autoList.Count > 0)
            //{
            //    suggestion.ItemsSource = autoList;
            //    suggestion.Visibility = Visibility.Visible;
            //}
            //else //if (txtAuto.Text.Equals(""))
            //{
            //    suggestion.Visibility = Visibility.Collapsed;
            //    suggestion.ItemsSource = null;
            //}
            //else
            //{
            //    suggestion.Visibility = Visibility.Collapsed;
            //    suggestion.ItemsSource = null;
            //}
        }

        private void suggestion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (suggestion.ItemsSource != null)
            {
                suggestion.Visibility = Visibility.Collapsed;
                txtAuto.TextChanged -= new TextChangedEventHandler(txtAuto_TextChanged);
                if (suggestion.SelectedIndex != -1)
                {
                    string tmp = suggestion.SelectedItem.ToString();
                    for(int i = 0; i < allFood.Count; i++)
                    {
                        if(tmp.Equals(allFood[i].Name) || tmp.Equals(allFood[i].Info) || tmp.Equals(allFood[i].FinishPrice.ToString()))
                        {
                            txtAuto.Text = allFood[i].Name;
                        }
                    }
                    //txtAuto.Text = suggestion.SelectedItem.ToString();
                }
                txtAuto.TextChanged += new TextChangedEventHandler(txtAuto_TextChanged);
            }
        }

        private void saveSearch_Click(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < allFood.Count; i++)
            {
                if (txtAuto.Text.Equals(allFood[i].Name))
                {
                    sabadKharid.Add(allFood[i]);
                    sabadKharid[sabadKharid.Count - 1].Mojoodi = 1;
                }
            }
            txtAuto.Clear();
            MessageBox.Show("به سبد خرید اضافه شد");
            dataSabad.ItemsSource = sabadKharid;
        }
    }
}
