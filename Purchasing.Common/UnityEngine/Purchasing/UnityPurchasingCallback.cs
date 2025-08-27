namespace UnityEngine.Purchasing;

internal sealed class UnityPurchasingCallback : MulticastDelegate
{

	public UnityPurchasingCallback(object object, IntPtr method) { }

	public override void Invoke(string subject, string payload, string receipt, string transactionId, string originalTransactionId, bool isRestored) { }

}

