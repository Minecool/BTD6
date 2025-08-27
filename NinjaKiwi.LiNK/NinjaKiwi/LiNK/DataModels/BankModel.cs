namespace NinjaKiwi.LiNK.DataModels;

[DataContract]
internal class BankModel : Dictionary<String, WalletModel>
{

	public BankModel() { }

}

