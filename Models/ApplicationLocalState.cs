namespace Algorand.Models
{
	public struct ApplicationLocalState
	{
		public long id;
		public TealKeyValueStore key_value;
		public ApplicationStateSchema schema;
	}
}