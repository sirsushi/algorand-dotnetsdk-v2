namespace Algorand.Models
{
	public struct DryrunTxnResult
	{
		public string[] app_call_messages;
		public DryrunState[] app_call_trace;
		public long cost;
		public string[] disassembly;
		public StateDelta global_delta;
		public AccountStateDelta[] local_deltas;
		public string[] logic_sig_messages;
		public DryrunState[] logic_sig_trace;
		public string[] logs;
	}
}