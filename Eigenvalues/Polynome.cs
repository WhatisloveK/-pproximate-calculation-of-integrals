using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Epam
{
    class Polynome
    {
        int degree;
        double[] coef;

        public Polynome(params double[] coef)
        {
            if (coef == null)
                throw new ArgumentNullException("Initial array is null!");

            degree = coef.Length - 1;
            this.coef = new double[coef.Length];
            for (int i = 0; i < coef.Length; i++)
            {
                this.coef[i] = coef[coef.Length - 1 - i];
            }
        }
        public int Degree
        {
            get
            {
                return degree;
            }
        }
        public double this[int index]
        {
            get
            {
                if (index > degree)
                    throw new IndexOutOfRangeException("Index out of range!");
                return coef[degree - index];
            }
            set
            {
                if (index > degree)
                    throw new IndexOutOfRangeException("Index put pf range!");
                coef[degree - index] = value;
            }
        }
        static Polynome Add(Polynome p1, Polynome p2)
        {
            if (p1 == null || p2 == null)
                throw new ArgumentNullException("One or two of these polynome is null!");
            double[] newCoef = new double[Math.Max(p1.degree, p2.degree) + 1];
            int min = Math.Min(p1.degree, p2.degree);
            for (int i = 0; i <= min; i++)
            {
                newCoef[newCoef.Length - 1 - i] = p1.coef[i] + p2.coef[i];
            }
            if (p1.degree > p2.degree)
            {
                for (int i =  min + 1; i <= p1.degree; i++)
                {
                    newCoef[newCoef.Length - 1 - i] = p1.coef[i];
                }
            }
            else if (p1.degree < p2.degree)
            {
                for (int i = min + 1; i <= p2.degree; i++)
                {
                    newCoef[newCoef.Length - 1 - i] = p2.coef[i];
                }
            }
            return new Polynome(newCoef);
        }
        static Polynome Substruct(Polynome p1, Polynome p2)
        {
            if (p1 == null || p2 == null)
                throw new ArgumentNullException("One or two of these polynome is null!");
            double[] newCoef = new double[Math.Max(p1.degree, p2.degree) + 1];
            int min = Math.Min(p1.degree, p2.degree);
            for (int i = 0; i <= min; i++)
            {
                newCoef[newCoef.Length-1-i] = p1.coef[i] - p2.coef[i];
            }
            if (p1.degree > p2.degree)
            {
                for (int i = min + 1; i <= p1.degree; i++)
                {
                    newCoef[newCoef.Length - 1 - i] = p1.coef[i];
                }
            }
            else if (p1.degree < p2.degree)
            {
                for (int i = min + 1; i <= p2.degree; i++)
                {
                    newCoef[newCoef.Length - 1 - i] = -p2.coef[i];
                }
            }
            return new Polynome(newCoef);
        }
        static Polynome Multiply(Polynome p1, Polynome p2)
        {
            if (p1 == null || p2 == null)
                throw new ArgumentNullException("One or two of these polynome is null!");
            double[] newCoef = new double[p1.degree + p2.degree + 1];
            Dictionary<int, double> pairs = new Dictionary<int, double>();
            for (int i = 0; i <= p1.degree; i++)
            {
                double temp = p1[p1.degree - i];
                double val;
                int deg;
                for (int j = 0; j <= p2.degree; j++)
                {
                    val = temp * p2[p2.degree - j];
                    deg = i + j;
                    if (pairs.ContainsKey(deg))
                    {
                        pairs[deg] += val;
                    }
                    else
                    {
                        pairs.Add(deg, val);
                    }
                }
            }
            for (int i = 0; i < newCoef.Length; i++)
            {
                newCoef[newCoef.Length - 1 - i] = pairs[i];
            }
            return new Polynome(newCoef);
        }
        static Polynome Multiply(double k, Polynome p2)
        {
            if (p2 == null)
                throw new ArgumentNullException("Polynome is null!");
            double[] newCoef = new double[p2.degree + 1];
            for (int i = 0; i <= p2.degree; i++)
            {
                newCoef[p2.degree - i] = p2[i] * k;
            }
            return new Polynome(newCoef);
        }

        public void Show()
        {
            string res = "";
            for (int i = 0; i < degree; i++)
            {
                if (i == degree - 1)
                {
                    if (coef[degree - i] != 0)
                    {
                        if (coef[degree - i] == 1)
                            res += $"x";
                        else if(coef[degree - i] == -1)
                            res += $"-x";
                        else
                            res += $"{coef[degree - i]}*x";
                    }
                    if (coef[degree - i - 1] != 0)
                    {
                        if (coef[degree - i - 1] > 0)
                            res += $"+{coef[degree - i - 1]}";
                        else
                            res += $"{coef[degree - i - 1]}";
                    }
                    Console.WriteLine(res);
                    return;
                }
                if (coef[degree - i] != 0)
                {
                    if (coef[degree - i - 1] > 0)
                    {
                        if (coef[degree - i] == 1)
                            res += $"x^{degree - i}+";
                        else
                            res += $"{coef[degree - i]}*x^{degree - i}+";
                    }
                    else
                    {
                        if (coef[degree - i] == -1 || coef[degree - i] == 1)
                            res += $"x^{degree - i}";
                        else
                            res += $"{coef[degree - i]}*x^{degree - i}";
                    }
                }
                else
                {
                    if (coef[degree - i - 1] > 0)
                        res += "+";
                }
            }
        }
        public static Polynome operator +(Polynome m1, Polynome m2)
        {
            return Add(m1, m2);
        }
        public static Polynome operator -(Polynome m1, Polynome m2)
        {
            return Substruct(m1, m2);
        }
        public static Polynome operator *(double k, Polynome m2)
        {
            return Multiply(k, m2);
        }
        public static Polynome operator *(Polynome m2, double k)
        {
            return Multiply(k, m2);
        }
        public static Polynome operator *(Polynome m1, Polynome m2)
        {
            return Multiply(m1, m2);
        }
    }
}
