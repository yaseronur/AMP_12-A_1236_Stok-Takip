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
using WpfApp1.Modeller;

namespace WpfApp1.Views
{
    /// <summary>
    /// Interaction logic for KategoriKaydıWindow.xaml
    /// </summary>
    public partial class KategoriKaydıWindow : Window
    {
        public KategoriKaydıWindow()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
            var kategoriler = Db.Context.Kategoriler.ToList();
            DgKategoriler.ItemsSource = kategoriler;


        }
    }
}
