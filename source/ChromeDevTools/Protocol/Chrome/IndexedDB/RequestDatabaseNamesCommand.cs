using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.IndexedDB
{
	/// <summary>
	/// Requests database names for given security origin.
	/// </summary>
	[Command(ProtocolName.IndexedDB.RequestDatabaseNames)]
	[SupportedBy("Chrome")]
	public class RequestDatabaseNamesCommand
	{
		/// <summary>
		/// Gets or sets Security origin.
		/// </summary>
		public string SecurityOrigin { get; set; }
	}
}