namespace UnityEngine.Purchasing;

internal class OSXStoreBindings : INativeAppleStore, INativeStore
{

	public override string appReceipt
	{
		 get { } //Length: 62
	}

	public override double appReceiptModificationDate
	{
		 get { } //Length: 62
	}

	public OSXStoreBindings() { }

	public override void AddTransactionObserver() { }

	public override void FinishTransaction(string productJSON, string transactionID) { }

	public override string get_appReceipt() { }

	public override double get_appReceiptModificationDate() { }

	public override void InterceptPromotionalPurchases() { }

	public override void Purchase(string productJSON, string developerPayload) { }

	public override void RestoreTransactions() { }

	public override void RetrieveProducts(string json) { }

	public override void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

}

