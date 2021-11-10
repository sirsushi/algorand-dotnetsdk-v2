namespace Algorand.Models
{
	public struct Version
	{
		public BuildVersion build;
		public string genesis_hash_b64;
		public string genesis_id;
		public string[] versions;
	}
}