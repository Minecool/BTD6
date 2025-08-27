namespace NinjaKiwi.LiNK.DataModels;

public class SteamIapsModel
{
	public readonly string currency; //Field offset: 0x10
	public readonly bool currencyIsAligned; //Field offset: 0x18
	public readonly Dictionary<String, SteamIapModel> items; //Field offset: 0x20

	public SteamIapsModel(string currency, bool currencyIsAligned, Dictionary<String, SteamIapModel> items) { }

}

