using System;
using System.Collections.Generic;
using GoogleMaps.Bindings.ViewModels;
using Xamarin.Forms;

namespace GoogleMaps.Bindings.Views
{
    public partial class MajorCitiesPage : ContentPage
    {
        MajorCitiesViewModel vm;
        
        public MajorCitiesPage()
        {
            InitializeComponent();
            BindingContext = vm = new MajorCitiesViewModel();
        }

        void Handle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (CityTypePicker.SelectedItem.ToString() == "Mexico City")
            {
                vm.Longitude = -99.133209;
                vm.Latitude = 19.432608;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Seattle")
            {
                vm.Longitude = -122.335167;
                vm.Latitude = 47.608013;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Cordob Mexico")
            {
                vm.Longitude = -96.93125;
                vm.Latitude = 18.88584;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Barcelona")
            {
                vm.Longitude = 2.154007;
                vm.Latitude = 41.390205;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Seul")
            {
                vm.Longitude = 127.024612;
                vm.Latitude = 37.532600;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "New York")
            {
                vm.Longitude = -73.935242;
                vm.Latitude = 40.730610;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Madrid")
            {
                vm.Longitude = -3.703790;
                vm.Latitude = 40.416775;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Londres")
            {
                vm.Longitude = -0.118092;
                vm.Latitude = 51.509865;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Milan")
            {
                vm.Longitude = 9.191383;
                vm.Latitude = 45.464211;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Tegucigalpa")
            {
                vm.Longitude = -87.2068;
                vm.Latitude = 14.0818;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Sao Paolo")
            {
                vm.Longitude = -46.625290;
                vm.Latitude = -23.533773;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Guadalajara")
            {
                vm.Longitude = 20.66682;
                vm.Latitude = -103.39182;
                vm.MoveToCityCommand.Execute(null);
            }
            else if (CityTypePicker.SelectedItem.ToString() == "Dubai")
            {
                vm.Longitude = 25.276987;
                vm.Latitude = 55.296249;
                vm.MoveToCityCommand.Execute(null);
            }


        }
    }
}
