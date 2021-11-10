namespace Algorand.Models
{
	public struct ApplicationParams
	{
		public string approval_program;
		public string clear_state_program;
		public string creator;
		public long extra_program_pages;
		public TealKeyValueStore global_state;
		public ApplicationStateSchema global_state_schama;
		public ApplicationStateSchema local_state_schama;
	}
}