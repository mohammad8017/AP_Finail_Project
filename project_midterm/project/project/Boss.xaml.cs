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
        public static List<Food> foodList = new List<Food>();
        //public static List<Food> foodTemp = new List<Food>();
        public static List<boss> listOfBoss = new List<boss>();
        public static ImageSource menuImage;
        public static List<ImageSource> foodImage = new List<ImageSource>();
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
            for(int i = 0; i < statUp.bosses.Count; i++)
            {
                if (int.Parse(codeText.Text) == statUp.bosses[i].Code && passText.Text == statUp.bosses[i].Pass)
                {
                    Hold = statUp.bosses[i];
                    signIn = true;
                    check = true;
                    statUp.bosses[i].signInNum++;
                    //Hold.signInNum++;
                }
                    
            }
            if (check)
                MessageBox.Show("شما وارد حساب خود شدید");
            else
                MessageBox.Show("کلمه عبور یا ایمیل نادرست است");
            if (Signup_window.customer != null)
            {
                showCustomers.ItemsSource = Signup_window.customer;
            }
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
                menuImage = imgPhoto.Source;
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

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var mtp = foodDate.Text.Split('/'); //System.Windows.Controls.ComboBoxItem:
            var tmpType = foodCombo.SelectedItem.ToString();
            var foodType= tmpType.Split(new string[] { "System.Windows.Controls.ComboBoxItem:" }, StringSplitOptions.None);
            //foodList.Add(new Food("pizza", 12000, 3000, "morgh", "sade", "پیتزا", 23, 7, 13, 2020));
            foodList.Add(new Food(foodname.Text, int.Parse(foodPrice.Text), int.Parse(FoodPrice.Text), foodInfo.Text, privateInfo.Text, foodType[1], int.Parse(foodNum.Text), int.Parse(mtp[0]), int.Parse(mtp[1]), int.Parse(mtp[2])));
            //foodTemp = foodList;
            foodname.Clear();
            foodPrice.Clear();
            FoodPrice.Clear();
            foodInfo.Clear();
            privateInfo.Clear();
            foodCombo.SelectedIndex = -1;
            foodNum.Clear();
            foodDate.Clear();
            foodPhoto.Source = null;
            MessageBox.Show("ثبت شد");
        }
        

        private void SoodBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("سود شما تا این لحظه\n" + (MainWindow.daramad - MainWindow.hazine));
        }

        

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            bool isValid = false;
            for(int i = 0; i < foodList.Count; i++)
            {
                if (foodList[i].Name == FoodName.Text)
                {
                    //nowNum.Text = foodList[i].Mojoodi.ToString();
                    foodList[i].Mojoodi = int.Parse(newNum.Text);
                    isValid = true;
                    FoodName.Clear();
                    newNum.Clear();
                }
            }
            if (isValid)
                MessageBox.Show("تعداد موجودی تغییر یافت");
            else
                MessageBox.Show("نام غذای وارد شده نادرست است");
        }

        private void EditUsername_Click(object sender, RoutedEventArgs e)
        {
            ChangeUsername change = new ChangeUsername();
            change.Show();
            change.change(ref Hold);
        }

        private void EditPass_Click(object sender, RoutedEventArgs e)
        {
            changePass change = new changePass();
            change.Show();
            change.change(ref Hold);
        }

        private void Upload_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Title = "تصویر را انتخاب کنید";
            op.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
              "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
              "Portable Network Graphic (*.png)|*.png";
            if (op.ShowDialog() == true)
            {
                foodPhoto.Source = new BitmapImage(new Uri(op.FileName));
            }
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            bool check = false;
            for(int i = 0; i < foodList.Count; i++)
            {
                if (foodList[i].Name.Equals(FoodNameEdit.Text) && foodList[i].date.ToShortDateString().Equals(editDate.Text))
                {
                    check = true;
                    foodPriceEdit.Text = foodList[i].FinishPrice.ToString();
                    FoodPriceEdit.Text = foodList[i].RealPrice.ToString();
                    foodInfoEdit.Text = foodList[i].Info.ToString();
                    privateInfo.Text = foodList[i].PrivateInfo.ToString();
                    foodNumEdit.Text = foodList[i].Mojoodi.ToString();
                    foodDateEdit.Text = foodList[i].date.ToShortDateString();
                }
            }
            if (!check)
                MessageBox.Show("غذایی با این اطلاعات ثبت نشده");
        }

        private void SaveEdit_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < foodList.Count; i++)
            {
                if (FoodNameEdit.Text.Equals(foodList[i].Name))
                {
                    foodList[i].FinishPrice = int.Parse(foodPriceEdit.Text);
                    foodList[i].RealPrice = int.Parse(FoodPriceEdit.Text);
                    foodList[i].Info = foodInfoEdit.Text;
                    foodList[i].PrivateInfo = privateInfo.Text;
                    foodList[i].Mojoodi = int.Parse(foodNumEdit.Text);
                    foodList[i].date = Convert.ToDateTime(foodDateEdit.Text);
                    var tmpType = foodComboEdit.SelectedItem.ToString();
                    var foodType = tmpType.Split(new string[] { "System.Windows.Controls.ComboBoxItem:" }, StringSplitOptions.None);
                    foodList[i].Type = foodType[1];
                }
            }
            FoodNameEdit.Clear();
            editDate.Clear();
            foodPriceEdit.Clear();
            FoodPriceEdit.Clear();
            foodInfoEdit.Clear();
            privateInfoEdit.Clear();
            foodNumEdit.Clear();
            foodDateEdit.Clear();
            foodComboEdit.SelectedIndex = -1;
            MessageBox.Show("اطلاعات تغییر یافت");
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ShowFactor_Click(object sender, RoutedEventArgs e)
        {
            var tmp = showCustomers.SelectedCells;
            string holdName = "";
            List<string>[] holdFoods = new List<string>[10];
            double daramad = 0;
            double hazine = 0;
            double sood = 0;
            try
            {
                holdName = (tmp[0].Column.GetCellContent(tmp[0].Item) as TextBlock).Text;
            }
            catch
            {
                MessageBox.Show("مشتری انتخاب نشده");
            }
            //foreach(var item in Signup_window.customer)
            //{
            //    if (item.Name.Equals(holdName))
            //    {
            //        if (item.factors != null)
            //        {
            //            ShowFactor.ItemsSource = item.factors;
            //            for(int i = 0; i < item.factors.Count; i++)
            //            {
            //                holdFoods[i] = item.factors[0].Names;
            //                daramad += item.factors[i].AllPriceOff;
            //            }
            //        }    
            //        else
            //            MessageBox.Show("مشتری انتخاب شده هنوز خریدی انجام نداده است");
            //    }    
            //}
            List<ShowFactor> show = new List<ShowFactor>();
            foreach (var item in Signup_window.customer)
            {
                if (item.Name.Equals(holdName))
                {
                    for (int i = 0; i < item.factors.Count; i++)
                    {
                        holdFoods[i] = item.factors[i].Names;
                        string tmp2 = "foods: ";
                        for (int j = 0; j < item.factors[i].Names.Count; j++)
                        {
                            if (j != item.factors[i].Names.Count - 1)
                                tmp2 += item.factors[i].Names[j] + ", " + item.factors[i].Prices[j] + " | ";
                            else
                                tmp2 += item.factors[i].Names[j] + ", " + item.factors[i].Prices[j];
                        }
                        //tmp += "// price of all with out OFF: " + Hold.factors[i].AllPrice + "// price of all with OFF: " + Hold.factors[i].AllPriceOff;
                        //show.Add(Hold.factors[i].Names[j]);
                        show.Add(new ShowFactor(tmp2, item.factors[i].AllPrice, item.factors[i].AllPriceOff));
                        daramad += item.factors[i].AllPriceOff;
                    }
                    if (item.factors.Count > 0)
                        ShowFactor.ItemsSource = show;
                    else
                        MessageBox.Show("مشتری انتخاب شده هنوز خریدی انجام نداده است");
                }

            }

            foreach (var item in holdFoods)
            {
                if (item != null)
                {
                    for (int i = 0; i < foodList.Count; i++)
                    {
                        if (item.Equals(foodList[i].Name))
                            hazine += foodList[i].RealPrice;
                    } 
                }
            }
            
            sood += daramad - hazine;
            MessageBox.Show($"{sood} سود شما از خرید های این مشتری");

               
            
        }

        private void DeleteFactor_Click(object sender, RoutedEventArgs e)
        {
            var tmp = showCustomers.SelectedCells;
            string holdName = "";
            try
            {
                holdName = (tmp[0].Column.GetCellContent(tmp[0].Item) as TextBlock).Text;
            }
            catch
            {
                MessageBox.Show("مشتری انتخاب نشده");
            }
            for(int i = 0; i < Signup_window.customer.Count; i++)
            {
                if (holdName.Equals(Signup_window.customer[i].Name))
                {
                    Signup_window.customer[i].sabad.Clear();
                    Signup_window.customer[i].laghveKharid = true;
                }
            }
            MessageBox.Show("سفارش مشتری حذف شد");
        }
    }
}
