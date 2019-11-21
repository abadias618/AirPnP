﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using Xamarin.Forms.Maps;
using Map = Xamarin.Forms.Maps.Map;

namespace AirPnP
{
	public class CustomMap: Map
	{
		public List<CustomPin> CustomPins { get; set; }
	}

	public class CustomPin : Pin
	{
		public string Name { get; set; }
		public string streetAddress { get; set; }
	}
}
