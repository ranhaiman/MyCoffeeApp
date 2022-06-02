﻿using MyCoffeeApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MyCoffeeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyStoredCoffeePage : ContentPage
    {
        public MyStoredCoffeePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var vm = (MyCoffeeViewModel)BindingContext;
            if (vm.Coffee.Count == 0)
                await vm.RefreshCommand.ExecuteAsync();
        }
    }
}