using SQLite1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SQLite1
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
            

           
        }

        private void UnosUBazu_Clicked(object sender, EventArgs e)
        {
            Services.UserServices.Dodavanje(USername.Text, PAssword.Text);
            IME.Text = Services.UserServices.Ispis();

        }
    }
}
