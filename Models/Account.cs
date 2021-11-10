using System.Collections.Generic;

namespace Algorand.Models
{
	public struct Account
	{
		public string address;
		public long amount;
		public long amount_without_pending_rewards;
		public ApplicationLocalState[] apps_local_state;
		public long apps_total_extra_pages;
		public ApplicationStateSchema apps_total_schema;
		public AssetHolding[] assets;
		public string auth_addr;
		public Application[] created_apps;
		public Asset[] created_assets;
		public AccountParticipation participation;
		public long pending_rewards;
		public long reward_base;
		public long rewards;
		public long round;
		public SignatureType sig_type;
		public string status;
	}
}