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

namespace Financial_Calculator
{
    /// <summary>
    /// Логика взаимодействия для RentPage.xaml
    /// </summary>
    public partial class RentPage : Window
    {
        public RentPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rbPost.IsChecked = true;
            tbP.IsEnabled = false;
            tbM.IsEnabled = false;
        }
       

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            int count_1;
            int count_2;
            double R = 0;
            double I = 0; 
            double N = 0;
            int P;
            int M;
            double A = 0;
            double S = 0;
            bool annuity;
            int type = 0;
            bool infiniteM = false; //by default

            if (rbPost.IsChecked == true)
                annuity = true;
            else
                annuity = false;

            if (comboboxType.Text == "Обычная")
            {
                type = 1;
                tbP.IsEnabled = true;
            }
               
            else if (comboboxType.Text == "Непрерывная")
            {
                type = 2;
                tbP.IsEnabled = false;
            }
            else if (comboboxType.Text == "Вечная")
            {
                type = 3;
                tbP.IsEnabled = false;
            }
                
            

            count_1 = 0;
            if (!string.IsNullOrWhiteSpace(tbR.Text) & double.TryParse(tbR.Text, out R))
            {
                R = Double.Parse(tbR.Text);
                count_1++;
            }        
            if (!string.IsNullOrWhiteSpace(tbI.Text) & double.TryParse(tbI.Text, out I))
            {
                I = Double.Parse(tbI.Text)/100;
                count_1++;
            }
            if (!string.IsNullOrWhiteSpace(tbN.Text) & double.TryParse(tbN.Text, out N))
            {
                N = Double.Parse(tbN.Text);
                count_1++;
            }
            if (!string.IsNullOrWhiteSpace(tbP.Text) & int.TryParse(tbP.Text, out P))
            {
                P = Int32.Parse(tbP.Text);
                count_1++;
            }
            else if (tbP.IsEnabled == false)
            {
                P = 1;
                count_1++;
            }
            if (!string.IsNullOrWhiteSpace(tbM.Text) & int.TryParse(tbM.Text, out M) & tbM.IsEnabled == true)
            {
                M = Int32.Parse(tbM.Text);
                count_1++;
            }
            else if (tbM.IsEnabled == false & cbInfinityM.IsChecked == false)
            {
                M = 1;
                count_1++;
            }
            else if (tbM.IsEnabled == false & cbInfinityM.IsChecked == false)
            {
                infiniteM = true;
                count_1++;
            }


            count_2 = 0;
            if (!string.IsNullOrWhiteSpace(tbA.Text) & double.TryParse(tbA.Text, out A))
            {
                A = Double.Parse(tbA.Text);
                count_2++;
            }
            if (!string.IsNullOrWhiteSpace(tbS.Text) & double.TryParse(tbS.Text, out S))
            {
                S = Double.Parse(tbS.Text);
                count_2++;
            }


            Rent ourRent = new Rent(R, I, N, P, M, A, S, annuity, type, infiniteM);
            if (type != 0)
            {
                if (count_1 < 4)
                    MessageBox.Show("Введенных параметров не хватает для расчета параметров ренты!");
                else if (count_1 == 4)
                {
                    if (count_2 >= 1)
                    {
                        if (ourRent.R == 0)
                        {
                            ourRent.CalculateRentCosts();
                            ourRent.FindRentPayment();
                            tbR.Text = ourRent.R.ToString();
                        }
                        else if (ourRent.i == 0)
                        {
                            ourRent.CalculateRentCosts();
                            ourRent.FindInterestRate();
                            tbI.Text = ourRent.i.ToString();
                        }
                        else if (ourRent.n == 0)
                        {
                            ourRent.CalculateRentCosts();
                            ourRent.FindRentDuration();
                            tbN.Text = ourRent.n.ToString(); //изменить формат на проценты
                        }
                    }
                    else
                        MessageBox.Show("Введенных данных не хватает для вычисления параметров ренты!");
                }
                else if (count_1 == 5)
                {
                    if (count_2 == 2)
                        MessageBox.Show("Все параметры ренты уже известны!");
                    if (count_2 < 2)
                    {
                        ourRent.FindCurrentCost();
                        ourRent.FindAccuredCost();
                        tbA.Text = ourRent.A.ToString();
                        tbS.Text = ourRent.S.ToString();
                    }
                }
            }
            else MessageBox.Show("Выберите тип ренты!");
        }

        private void cbP_Checked(object sender, RoutedEventArgs e)
        {
            tbP.IsEnabled = true;
        }

        private void cbP_Unchecked(object sender, RoutedEventArgs e)
        {
            tbP.IsEnabled = false;
        }

        private void cbM_Checked(object sender, RoutedEventArgs e)
        {
            tbM.IsEnabled = true;
        }

        private void cbM_Unchecked(object sender, RoutedEventArgs e)
        {
            tbM.IsEnabled = false;
        }

        private void cbInfinityM_Checked(object sender, RoutedEventArgs e)
        {
            tbM.IsEnabled = false;            
        }

        private void cbInfinityM_Unchecked(object sender, RoutedEventArgs e)
        {
            tbM.IsEnabled = true;
        }
    }
}
