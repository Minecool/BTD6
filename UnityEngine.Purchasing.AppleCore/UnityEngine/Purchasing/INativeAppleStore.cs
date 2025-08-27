namespace UnityEngine.Purchasing;

internal interface INativeAppleStore : INativeStore
{

	public string appReceipt
	{
		 get { } //Length: 0
	}

	public double appReceiptModificationDate
	{
		 get { } //Length: 0
	}

	public void AddTransactionObserver() { }

	public string get_appReceipt() { }

	public double get_appReceiptModificationDate() { }

	public void InterceptPromotionalPurchases() { }

	public void RestoreTransactions() { }

	public void SetUnityPurchasingCallback(UnityPurchasingCallback AsyncCallback) { }

}

