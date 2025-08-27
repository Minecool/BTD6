namespace NinjaKiwi.LiNK.Endpoints;

public class Bank_PurchaseItem : Endpoint<BankPurchaseModel>
{

	internal Bank_PurchaseItem(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<BankPurchaseModel> Call(string accountHolderID, string fromWallet, string toWallet, string itemName, int quantity, string referenceCode = null) { }

	public Task<BankPurchaseModel> Call(string accountHolderID, string walletName, string itemName, int quantity, string referenceCode = null) { }

	public Task<BankPurchaseModel> Call(string accountHolderID, string itemName, int quantity, string referenceCode = null) { }

}

