namespace NinjaKiwi.LiNK.Endpoints;

public class MyNK_ItemBuy : Endpoint<MyNK_ReceiptModel>
{

	internal MyNK_ItemBuy(HttpRequestFactory requestFactory, Authority authority, ApiOptions options) { }

	public Task<MyNK_ReceiptModel> Call(string userID, int itemID, string tag) { }

	protected virtual MyNK_ReceiptModel Receive(string json) { }

}

