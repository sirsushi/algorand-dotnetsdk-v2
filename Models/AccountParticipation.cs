namespace Algorand.Models
{
	public struct AccountParticipation
	{
		public string selection_participation_key;
		public long vote_first_valid;
		public long vote_key_dilution;
		public long vote_last_valid;
		public string vote_participation_key;
	}
}