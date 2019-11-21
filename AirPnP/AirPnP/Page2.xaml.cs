using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace AirPnP
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
		
		
		public static async Task<Page2> CreateAsync() {
			var pg2 = new Page2();
			
			
			
			//Location locationTest = await pg2.getPositionAsync(testAddress1);



			CustomPin testPin = new CustomPin
			{
				Type = PinType.Place,
				//Position = positionTest.Result,
				//Position = new Position(locationTest.Latitude, locationTest.Longitude),
				//Position = new Position(40.7712, -111.9002),
				Label = "LDSBC"


			};

			//customMap.Pins.Add(testPin);
			//pg2.Content = customMap;

			return pg2;

		}


		public Page2()
		{
			InitializeComponent();

			string testAddress1 = "122 West South Temple UT USA ";
			string testAddress = "95 West 100 North Temple UT USA";

			List<String> addressList1 = new List<string>(); 
			addressList1.Add(testAddress1);
			addressList1.Add(testAddress);

			addressList1.ForEach(address => getPositionAsync(address));
			
			
		}

		private async void Init() {
			Page2 instance = await Page2.CreateAsync();
		}
		public async Task<Location> getPositionAsync(string markerAdress)
		{

			Location finalLocation = new Location();
			Geocoder coder = new Geocoder();

			try
			{
				var markerLocation = await Geocoding.GetLocationsAsync(markerAdress);
				var markerLongLat = markerLocation.FirstOrDefault();
				//var markerLocation = await coder.GetPositionsForAddressAsync(markerAdress);

				if (markerLongLat != null)
				{

					finalLocation.Latitude = markerLongLat.Latitude;
					finalLocation.Longitude = markerLongLat.Longitude;

					Position startPosition = new Position(40.7712, -111.9002);
					
					CustomMap customMap = new CustomMap
					{
						MapType = MapType.Street
					};

					customMap.MoveToRegion(MapSpan.FromCenterAndRadius(startPosition, Distance.FromMiles(0.1)));
					Content = customMap;
					CustomPin testPin = new CustomPin
					{
						Type = PinType.Place,
						//Position = positionTest.Result,
						Position = new Position(finalLocation.Latitude, finalLocation.Longitude),
						//Position = new Position(40.7712, -111.9002),
						Label = "LDSBC"

					};

					//return finalLocation; 
					customMap.Pins.Add(testPin); 
				}


			}
			catch (Exception ex)
			{

			}
			return finalLocation;

		}
	}
}