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

        public Rent(double R, double i, double n, double p, double m, double A, double S, bool flag, bool flagP, bool flagM)
        {
            this.R = R;
            this.i = i;
            this.n = n;
            this.p = flagP == true ? p : 1;
            this.m = flagM == true ? m : 1;
            this.A = A;
            this.S = S;
            this.flag = flag;
        }

        public void CalculateRentCosts()
        {
            if (S != 0 & A == 0)
                A = S * Math.Pow(1 + i / m, -m * n);
            else if (S == 0 & A != 0)
                S = A * Math.Pow(1 + i / m, m * n);
            else if (S == 0 & A == 0)
            {
                FindAccruedCost();
                FindCurrentCost();
            }


        }
        // Определение недостающих элементов
        public void IdentifyMissingElements()
        {
                
        }

        public void FindAccruedCost()
        {
            S = R / p * ((Math.Pow(1 + i / m, m * n) - 1) / (Math.Pow(1 + i / m, m / p) - 1));
        }

        public void FindCurrentCost()
        {
            A = R / p * ((1 - Math.Pow(1 + i / m, -m * n)) / (Math.Pow(1 + i / m, m / p) - 1));
        }

        public void FindRentPayment()
        {
            R = (S * p * (Math.Pow(1 + i / m, m / p) - 1)) / (Math.Pow(1 + i / m, m * n) - 1);
        }

        public void FindRentDuration()
        {
            n = Math.Log((S * p * (Math.Pow(1 + i / m, m / p) - 1) / R) + 1) / (m * Math.Log(1 + i / m));
        }

    }
}
