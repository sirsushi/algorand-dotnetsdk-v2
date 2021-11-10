namespace Algorand.Models
{
	public struct DryrunState
	{
		public string error;
		public long line;
		public long pc;
		public TealValue[] scratch;
		public TealValue[] stack;
	}
}