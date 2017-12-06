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
        public int type; // Тип ренты: 1 - обычная, 2 - вечная, 3 - непрерывная
        public bool mType;

        public Rent(double R, double i, double n, double p, double m, double A, double S, bool flag, int type, bool mType)
        {
            this.R = R;
            this.i = i;
            this.n = n;
            this.p = p;
            this.m = m;
            this.A = A;
            this.S = S;
            this.flag = flag;
            this.type = type;
            this.mType = mType;
        }

        // Переработать с учетом типа ренты
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

        public void FindAccuredCost()
        {
            if (type == 1)
            {
                if (flag == true) //Постнумерандо
                {
                    if (mType == true)
                        S = R / p * (Math.Exp(n * i) - 1) / (Math.Exp(1 / p) - 1);
                    else
                        S = R / p * ((Math.Pow(1 + i / m, m * n) - 1) / (Math.Pow(1 + i / m, m / p) - 1));
                }                   
                else //Пренумерандо
                {
                    if (mType == true)
                        S = R / p * (Math.Exp(n * i) - 1) / (Math.Exp(1 / p) - 1) * Math.Exp(i / p);
                    else
                        S = (R / p * ((Math.Pow(1 + i / m, m * n) - 1) / (Math.Pow(1 + i / m, m / p) - 1))) * Math.Pow(1 + i / m, m / p);
                }                  
            }
            if (type == 2)  // Либо использовать бесконечность, либо отключить
            {
                if (flag == true)
                    S = double.PositiveInfinity;
                else
                    S = double.PositiveInfinity;
            }
            if (type == 3)
            {
                if (mType == true)
                    S = R * (Math.Exp(n * i) - 1) / i;
                else
                    S = R * (Math.Pow(1 + i / m, m * n) - 1) / (m * Math.Log(1 + i / m));
            }
        }

        public void FindCurrentCost()
        {
            if (type == 1)
            {
                if (flag == true) //Постнумерандо
                {
                    if (mType == true)
                        A = R / p * (1 - Math.Exp(n * i)) / (Math.Exp(1 / p) - 1);
                    else
                        A = R / p * ((1 - Math.Pow(1 + i / m, -m * n)) / (Math.Pow(1 + i / m, m / p) - 1));
                }                 
                else //Пренумерандо
                {
                    if (mType == true)
                        A = R / p * (1 - Math.Exp(n * i)) / (Math.Exp(1 / p) - 1) * Math.Exp(i / p);
                    else
                        A = (R / p * ((1 - Math.Pow(1 + i / m, -m * n)) / (Math.Pow(1 + i / m, m / p) - 1))) * Math.Pow(1 + i / m, m / p);
                }                   
            }
            if (type == 2)
            {
                if (flag == true)
                    A = R / (Math.Pow(1 + i / m, m) - 1);
                else
                    A = (R * Math.Pow(1 + i / m, m)) / (Math.Pow(1 + i / m, m) - 1);
            }
            if (type == 3)
            {
                if (mType == true)
                    A = R * (1 - Math.Exp(-n * i)) / i;
                else
                    A = R * (1 - Math.Pow(1 + i / m, -m * n)) / (m * Math.Log(1 + i / m));
            }
        }

        public void FindRentPayment()
        {
            if (type == 1)
            {   // Хочу сделать это только с помощью S (Следовательно нужно переработать CalculateRentCosts())
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
            if (type == 2)
            {
                if (flag == true)
                    R = A * (Math.Pow(1 + i / m, m) - 1);
                else
                    R = (A * (Math.Pow(1 + i / m, m) - 1)) / Math.Pow(1 + i / m, m);
            }
                
            if (type == 3)
                R = S * m * Math.Log(1 + i / m) / (Math.Pow(1 + i / m, m * n) - 1);
        }

        public void FindRentDuration()
        {
            if (type == 1)
            {
                if (flag == true)
                {
                    if (S == 0)
                        n = Math.Log((A * Math.Pow(1 + i / m, -m * n) * p * (Math.Pow(1 + i / m, m / p) - 1) / R) + 1) / (m * Math.Log(1 + i / m));
                    else
                        n = Math.Log((S * p * (Math.Pow(1 + i / m, m / p) - 1) / R) + 1) / (m * Math.Log(1 + i / m));
                }
                else
                {
                    if (S == 0)
                        n = Math.Log((A * Math.Pow(1 + i / m, -m * n) * p * (Math.Pow(1 + i / m, m / p) - 1) / (R * Math.Pow(1 + i / m, m / p))) + 1) / (m * Math.Log(1 + i / m));
                    else
                        n = Math.Log((S * p * (Math.Pow(1 + i / m, m / p) - 1) / (R * Math.Pow(1 + i / m, m / p))) + 1) / (m * Math.Log(1 + i / m));
                }
            }
            if (type == 2)
            {
                n = double.PositiveInfinity;
            }
            if (type == 3)
            {
                n = Math.Log((S * m * Math.Log(1 + i / m) / R) + 1) / (m * Math.Log(1 + i));
            }       
        }

        public void FindInterestRate()
        {
            if (type == 1)
            {
                double i_1 = (-n * (n - 1) / 2 + Math.Sqrt(Math.Pow(-n * (n - 1) / 2, 2) - 4 * (n * (n - 1) * (n - 2)) / 6 * (n - S / R))) / (2 * (n * (n - 1) * (n - 2)) / 6);
                double i_2 = (-n * (n - 1) / 2 - Math.Sqrt(Math.Pow(-n * (n - 1) / 2, 2) - 4 * (n * (n - 1) * (n - 2)) / 6 * (n - S / R))) / (2 * (n * (n - 1) * (n - 2)) / 6);
                if (i_1 > 0)
                    i = Math.Round(i_1*100,2);
                else
                    i = Math.Round(i_2*100,2);
            }
        }
    }
}
