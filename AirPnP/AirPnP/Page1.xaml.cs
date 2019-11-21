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
	public partial class Page1 : ContentPage
	{
		Position startPosition = new Position(40.7712, -111.9002);
		string testAddress1 = "122 West South Temple UT USA ";
		string testLong;
		string testLat;

		Location finalLocation = new Location();
		
		public Page1()
		{
			
			
			InitializeComponent();
			//testLong = finalLocation.ToString(); 

			CustomMap customMap = new CustomMap
			{
				MapType = MapType.Street
			};
			//testLat = positionTest.Latitude.ToString();
			//testLong = positionTest.Longitude.ToString();
			//Location positionTest = getPositionAsync(testAddress1).Result;
			CustomPin testPin = new CustomPin
			{
				Type = PinType.Place,
				//Position = positionTest.Result,
				//Position = new Position(positionTest.Latitude, positionTest.Longitude),
				//Position = new Position(40.7712, -111.9002), 
				Position = new Position(finalLocation.Latitude, finalLocation.Longitude),
				Label = "Latitude: " + testLat + " Longitude: " + testLong 
			};
	
			customMap.MoveToRegion(MapSpan.FromCenterAndRadius(startPosition, Distance.FromMiles(0.1)));
			Content = customMap;
			customMap.Pins.Add(testPin);
			getPositionAsync(testAddress1);
		}
		/**
		async Task<Location> getPositionAsync(string markerAdress) {
			
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

					//return finalLocation; 
					
				}
				
				
			}
			catch (Exception ex) {
				
			}
			return finalLocation; 

		}
		**/
		async Task getPositionAsync(string markerAdress)
		{

			//Location finalLocation = new Location();
			//Geocoder coder = new Geocoder();

			try
			{
				var markerLocation = await Geocoding.GetLocationsAsync(markerAdress);
				var markerLongLat = markerLocation.FirstOrDefault();
				//var markerLocation = await coder.GetPositionsForAddressAsync(markerAdress);

				if (markerLongLat != null)
				{

					finalLocation.Latitude = markerLongLat.Latitude;
					finalLocation.Longitude = markerLongLat.Longitude;
					

					//return finalLocation; 

				}


			}
			catch (Exception ex)
			{

			}

		}
		/**
		public async Task<Position> getPositionAsync(string strtAddress)
		{
			var geocodeLocator = await Geocoding.GetLocationsAsync(strtAddress);

			//Position finalPosition = new Position();
			Location location = geocodeLocator.FirstOrDefault();
			///Position finalposition = new Position(0,0); 
			if (location == null)
			{
				longitude = 0;
				latitude = 0;
				Position finalPosition = new Position(latitude, longitude);
				return finalPosition;
			}
			else
			{

				longitude = (location.Longitude);
				latitude = (location.Latitude);
				Position finalPosition = new Position(latitude, longitude);
				return finalPosition;
			}
		}
	**/

	}
}