using System;
using System.Globalization;
using System.Windows;

namespace Aaaaaa_calc
{
    public partial class MainWindow : Window
    {
        float lab;
        float lab1;
        float lab_priemniy;
        bool dot = false;
        bool pomogite = false;
        char oper;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void BC1(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "1";
            }
            else
                Label0.Content = "1";
                pomogite = false;
        }

        private void BC2(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "2";
            }
            else
                Label0.Content = "2";
            pomogite = false;
        }

        private void BC3(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "3";
            }
            else
                Label0.Content = "3";
            pomogite = false;
        }

        private void BC4(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "4";
            }
            else
                Label0.Content = "4";
            pomogite = false;
        }

        private void BC5(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "5";
            }
            else
                Label0.Content = "5";
            pomogite = false;
        }

        private void BC6(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "6";
            }
            else
                Label0.Content = "6";
            pomogite = false;
        }

        private void BC7(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "7";
            }
            else
                Label0.Content = "7";
            pomogite = false;
        }

        private void BC8(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "8";
            }
            else
                Label0.Content = "8";
            pomogite = false;
        }

        private void BC9(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "9";
            }
            else
                Label0.Content = "9";
            pomogite = false;
        }

        private void BC0(object sender, RoutedEventArgs e)
        {
            if (!pomogite && Label0.Content.ToString() != "0")
            {
                Label0.Content += "0";
            }
            else
                Label0.Content = "0";
            pomogite = false;
        }
        public bool Aboba()
        {
            if (lab1 != 0 && oper != '√' && oper != '#')
            {
                lab = float.Parse(Label0.Content.ToString(), new CultureInfo("ru-ru"));
                pomogite = true;
                lab_priemniy = lab1;
                {
                    switch (oper)
                    {
                        case '+':
                            lab1 += lab;
                            break;
                        case '-':
                            lab1 -= lab;
                            break;
                        case '*':
                            lab1 *= lab;
                            break;
                        case '/':
                            lab1 /= lab;
                            break;
                        case '^':
                            lab1 = (float)Math.Pow(lab1, lab);
                            break;
                    }
                }
                return true;
            }
            else
            lab1 = float.Parse(Label0.Content.ToString(), new CultureInfo("ru-ru"));
            pomogite = true;
            dot = false;
            return false;
        }
        public void BCdot(object sender, RoutedEventArgs e)
        {
            if (pomogite)
            {
                Label0.Content = "";
                pomogite = false;
            }
            if (!dot)
            {
                if (Label0.Content.ToString().Length == 0) Label0.Content += "0";
                Label0.Content += ",";
                dot = true;
            }
        }

        private void BCpl(object sender, RoutedEventArgs e)
        {
            oper = '+';
            Aboba();    
            Label1.Content = lab1 + "+";
        }

        private void BCmin(object sender, RoutedEventArgs e)
        {
            oper = '-';
            Aboba();
            Label1.Content = lab1 + "-";
        }

        private void BCdel(object sender, RoutedEventArgs e)
        {
            oper = '/';
            Aboba();
            Label1.Content = lab1 + "/";
        }

        private void BCumn(object sender, RoutedEventArgs e)
        {
            oper = '*';
            Aboba();
            Label1.Content = lab1 + "*";
        }

        private void BCstep(object sender, RoutedEventArgs e)
        {
            oper = '^';
            Aboba();
            Label1.Content = lab1 + "^";
        }

        private void BCC(object sender, RoutedEventArgs e)
        {
            lab = 0;
            lab1 = 0;
            Label0.Content = "";
            Label1.Content = "";
            dot = false;
            pomogite = false;
        }

        private void BCansw(object sender, RoutedEventArgs e)
        {
            if (!Aboba())
            {
                Label1.Content = lab1 + "=";
                Label0.Content = lab1;
            }
            else
            {
                Label0.Content = lab1;
                Label1.Content = lab_priemniy + oper.ToString() + lab + "=";
            }
        }
    }
}