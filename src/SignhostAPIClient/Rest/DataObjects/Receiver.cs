﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Signhost.APIClient.Rest.DataObjects
{
	public class Receiver
	{
		public Receiver()
		{
		}
		
		[JsonConstructor]
		private Receiver(IReadOnlyList<Activity> activities)
		{
			Activities = activities;
		}

		public string Name { get; set; }

		public string Email { get; set; }

		public string Language { get; set; }

		public string Message { get; set; }

		public string Reference { get; set; }

		public IReadOnlyList<Activity> Activities { get; set; } =
			new List<Activity>().AsReadOnly();

		public dynamic Context { get; set; }
	}
}
