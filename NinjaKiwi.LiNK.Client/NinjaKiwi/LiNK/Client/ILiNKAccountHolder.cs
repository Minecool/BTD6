namespace NinjaKiwi.LiNK.Client;

internal interface ILiNKAccountHolder
{

	internal LiNKAccount GetLiNKAccount() { }

	internal Task SetLiNKAccount(LiNKAccount newLiNKAccount) { }

}

