namespace Algorand.Models
{
	public struct PendingTransactionResponse
	{
		public long application_index;
		public long asset_closing_amount;
		public long asset_index;
		public long close_rewards;
		public long closing_amount;
		public long confirmed_round;
		public StateDelta global_state_delta;
		public PendingTransactionResponse[] inner_txns;
		public AccountStateDelta[] local_state_delta;
		public string[] logs;
		public string pool_error;
		public long receiver_rewards;
		public long sender_rewards;
		public object txn;
	}
}