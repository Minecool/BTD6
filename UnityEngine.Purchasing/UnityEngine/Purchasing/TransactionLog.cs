namespace UnityEngine.Purchasing;

internal class TransactionLog
{
	private readonly ILogger logger; //Field offset: 0x10
	private readonly string persistentDataPath; //Field offset: 0x18

	public TransactionLog(ILogger logger, string persistentDataPath) { }

	internal static string ComputeHash(string transactionID) { }

	private string GetRecordPath(string transactionID) { }

	public bool HasRecordOf(string transactionID) { }

	public void Record(string transactionID) { }

}

