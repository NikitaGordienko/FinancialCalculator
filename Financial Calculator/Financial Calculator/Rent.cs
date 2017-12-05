using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Calculator
{
    class Rent
    {
        public double R; // Рентный платеж
        public double i; // Процентная ставка
        public double n; // Длительность ренты
        public double p; // Кратность выплат
        public double m; // Кратность начисления процентов
        public double A; // Современная стоимость
        public double S; // Наращенная стоимость
        public bool flag; // true - постнумерандо, false - пренумерандо

        public Rent(double R, double i, double n, double p, double m, double A, double S, bool flag)
        {
            this.R = R;
            this.i = i;
            this.n = n;
            this.p = p;
            this.m = m;
            this.A = A;
            this.S = S;
            this.flag = flag;
        }

        public void CalculateRentCosts() 
        {
            if (S != 0 & A == 0)
            {
                A = S * Math.Pow(1 + i / m, -m * n);
            }
            else if (S == 0 & A != 0)
                S = A * Math.Pow(1 + i / m, m * n);

            else if (S == 0 & A == 0)
            {
                FindCurrentCost();
                FindAccuredCost();
            }

        }
        // Определение недостающих элементов
        public void IdentifyMissingElements()
        {
                
        }

        public void FindAccuredCost()
        {
            if (flag == true)
                S = R / p * ((Math.Pow(1 + i / m, m * n) - 1) / (Math.Pow(1 + i / m, m / p) - 1));
            else
                S = (R / p * ((Math.Pow(1 + i / m, m * n) - 1) / (Math.Pow(1 + i / m, m / p) - 1))) * Math.Pow(1 + i / m, m / p);
        }

        public void FindCurrentCost()
        {
            if (flag==true)
                A = R / p * ((1 - Math.Pow(1 + i / m, -m * n)) / (Math.Pow(1 + i / m, m / p) - 1));
            else
                A = (R / p * ((1 - Math.Pow(1 + i / m, -m * n)) / (Math.Pow(1 + i / m, m / p) - 1))) * Math.Pow(1 + i / m, m / p);
        }

        public void FindRentPayment()
        {
            if (flag == true)
            {
                if (S == 0)
                    R = (A * p * (Math.Pow(1 + i / m, m / p) - 1)) / (Math.Pow(1 + i / m, m * n) - 1);
                else
                    R = (S * p * (Math.Pow(1 + i / m, m / p) - 1)) / (1 - Math.Pow(1 + i / m, -m * n));
            }
            else
            {
                if (S == 0)
                    R = (A * p * (Math.Pow(1 + i / m, m / p) - 1)) / (Math.Pow(1 + i / m, m * n) - 1);
                else
                    R = (S * p * (Math.Pow(1 + i / m, m / p) - 1)) / ((Math.Pow(1 + i / m, m * n) - 1) * Math.Pow(1 + i / m, m / p));
            }
        }

        public void FindRentDuration()
        {
            if (flag == true)
            {
                if (S == 0)
                    n = Math.Log((S * Math.Pow(1 + i / m, -m * n) * p * (Math.Pow(1 + i / m, m / p) - 1) / R) + 1) / (m * Math.Log(1 + i / m)); 
                else
                    n = Math.Log((S * p * (Math.Pow(1 + i / m, m / p) - 1) / R) + 1) / (m * Math.Log(1 + i / m));
            }
            else
            {
                if (S == 0)
                    n = Math.Log((S * Math.Pow(1 + i / m, -m * n) * p * (Math.Pow(1 + i / m, m / p) - 1) / (R * Math.Pow(1 + i / m, m / p))) + 1) / (m * Math.Log(1 + i / m));
                else
                    n = Math.Log((S * p * (Math.Pow(1 + i / m, m / p) - 1) / (R * Math.Pow(1 + i / m, m / p))) + 1) / (m * Math.Log(1 + i / m));
            }        
        }

        public void FindInterestRate()
        {
            double i_1 = (-n * (n - 1) / 2 + Math.Sqrt(Math.Pow(-n * (n - 1) / 2, 2) - 4 * (n * (n - 1) * (n - 2)) / 6 * (n - S / R))) / (2 * (n * (n - 1) * (n - 2)) / 6); 
            double i_2 = (-n * (n - 1) / 2 - Math.Sqrt(Math.Pow(-n * (n - 1) / 2, 2) - 4 * (n * (n - 1) * (n - 2)) / 6 * (n - S / R))) / (2 * (n * (n - 1) * (n - 2)) / 6);
            if (i_1 > 0)
                i = i_1;
            else
                i = i_2;
        }
    }
}
