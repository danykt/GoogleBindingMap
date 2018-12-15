using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Xamarin.Forms.GoogleMaps.Bindings;
namespace GoogleMaps.Bindings.ViewModels
{
    public class MajorCitiesViewModel : ViewModelBase
    {
        private MapSpan _visibleRegion;


        private double _latitude;
        public double Latitude
        {
            get => _latitude;
            set => SetProperty(ref _latitude, value);
        }

        private double _longitude;
        public double Longitude
        {
            get => _longitude;
            set => SetProperty(ref _longitude, value);
        }

        public MapSpan VisibleRegion
        {
            get => _visibleRegion;
            set => SetProperty(ref _visibleRegion, value);
        }

        

        private bool _animated = true;
        public bool Animated
        {
            get => _animated;
            set => SetProperty(ref _animated, value);
        }

        public MoveToRegionRequest Request { get; } = new MoveToRegionRequest();


        public Command MoveToCityCommand => new Command(() =>
        {
            Request.MoveToRegion(
                MapSpan.FromCenterAndRadius(
                    new Position(_latitude,_longitude), // change cordinates to mexico city
                    Distance.FromKilometers(2)),
                Animated);
        });


    }
}
