using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Algorand.Models
{
	public struct Account
	{
		public string address;
		public long amount;
		[JsonProperty("amount-without-pending-rewards")]
		public long amount_without_pending_rewards;

		[JsonProperty("apps-local-state")]
		public ApplicationLocalState[] apps_local_state;

		[JsonProperty("apps-total-extra-pages")]
		public long? apps_total_extra_pages;

		[JsonProperty("apps-total-schema")]
		public ApplicationStateSchema? apps_total_schema;
		public AssetHolding[] assets;

		[JsonProperty("auth-addr")]
		public string auth_addr;

		[JsonProperty("created-apps")]
		public Application[] created_apps;

		[JsonProperty("created-assets")]
		public Asset[] created_assets;
		public AccountParticipation? participation;

		[JsonProperty("pending-rewards")]
		public long pending_rewards;

		[JsonProperty("reward-base")]
		public long? reward_base;
		public long rewards;
		public long round;

		[JsonProperty("sig-type")]
		public SignatureType? sig_type;
		public string status;
	}
}