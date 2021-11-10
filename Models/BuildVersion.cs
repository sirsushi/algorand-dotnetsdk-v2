namespace Algorand.Models
{
	public struct BuildVersion
	{
		public string branch;
		public long build_number;
		public string channel;
		public string commit_hash;
		public long major;
		public long minor;
	}
}