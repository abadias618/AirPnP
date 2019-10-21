using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Support.V7.App;
using Android.Widget;

namespace AirPnP.Droid
{
    [Activity(Label = "@String/activity_label_mapwithmarkers")]
    public class MapDemo:AppCompatActivity, IOnMapReadyCallback
    {
        static readonly LatLng localatlng = new LatLng(40.7712, 111.9002);
        static readonly LatLng arenaLatLng = new LatLng(40.7683, 111.9011);
        Button animateToLocationButton;
        GoogleMap googleMap;

        public void OnMapReady(GoogleMap map) {
            googleMap = map;

            map.UiSettings.ZoomControlsEnabled = true;
            map.UiSettings.CompassEnabled = true;

            AddMarkersToMap(); 
           
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.mapLay);
            SupportFragmentManager.BeginTransaction()
                                  .Commit();

            var mapFrag = SupportMapFragment.NewInstance();
            SupportFragmentManager.BeginTransaction()
                                  .Add(Resource.Id.map, mapFrag, "map_fragment");
                                 
        }
        void AddMarkersToMap()
        {
            var arenaMarker = new MarkerOptions();
            arenaMarker.SetPosition(arenaLatLng)
                    .SetTitle("Vivint Arena")
                    .SetIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueCyan));

            googleMap.AddMarker(arenaMarker);

            var ldsbcMarker = new MarkerOptions();
            ldsbcMarker.SetPosition(localatlng)
                    .SetTitle("LDSBC");

            googleMap.AddMarker(ldsbcMarker);

            var cameraUpdate = CameraUpdateFactory.NewLatLngZoom(localatlng, 15);
            googleMap.MoveCamera(cameraUpdate); 
        }
    }
}