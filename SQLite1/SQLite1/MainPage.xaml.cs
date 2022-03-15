
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
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            collectionView1.ItemsSource = await App.Database.GetPeopleAsync();

        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(USername.Text))
            {
                await App.Database.SavePersonAsync(new Person
                {
                    Name = USername.Text,
                    
                });

                USername.Text = string.Empty;
                

                collectionView1.ItemsSource = await App.Database.GetPeopleAsync();
            }
        }


    }
}
