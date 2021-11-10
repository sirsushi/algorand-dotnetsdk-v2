namespace Algorand.Models
{
	public struct DryrunRequest
	{
		public Account[] accounts;
		public Application[] apps;
		public long latest_timestamp;
		public string protocol_version;
		public long round;
		public DryrunSource[] sources;
		public string[] txns;
	}
}