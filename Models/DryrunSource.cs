using System;

namespace Algorand.Models
{
	public struct DryrunSource
	{
		public long app_index;
		public string field_name;
		public string source;
		public long txn_index;
	}
}