﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTap1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ManHinhChao : ContentPage
    {
        public ManHinhChao()
        {
            InitializeComponent();
        }

        private void clickChao(object sender, EventArgs e)
        {
            DisplayAlert("THÔNG BÁO", "Chào bạn " + hoTen.Text , "OK");
        }
    }

   
}