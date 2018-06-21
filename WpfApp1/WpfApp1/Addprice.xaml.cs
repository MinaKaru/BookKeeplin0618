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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Addprice.xaml 的互動邏輯
    /// </summary>
    public partial class Addprice : UserControl
    {
        public Addprice()
        {
            InitializeComponent();
        }
        public int PriceValue
        {
            get
            {
                try
                {
                    return int.Parse(Price.Text);
                }
                catch
                {
                    MessageBox.Show("請輸入數字");
                    return 0;
                }
            }

            set
            {
                Price.Text = value.ToString();
            }
        }
    }
}

