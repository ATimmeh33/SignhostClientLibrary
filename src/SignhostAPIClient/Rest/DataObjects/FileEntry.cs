﻿using System.Collections.Generic;

namespace Signhost.APIClient.Rest.DataObjects
{
	public class FileEntry
	{
		public IList<FileLink> Links { get; set; }

		public string DisplayName { get; set; }
	}
}
