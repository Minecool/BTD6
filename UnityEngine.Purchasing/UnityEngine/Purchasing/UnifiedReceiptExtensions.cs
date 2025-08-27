namespace UnityEngine.Purchasing;

[Extension]
internal static class UnifiedReceiptExtensions
{

	[Extension]
	public static AnalyticsTransactionReceipt ToReceiptAndSignature(UnifiedReceipt receipt) { }

	[Extension]
	private static Nullable<TransactionServer> ToTransactionServer(UnifiedReceipt receipt) { }

}

