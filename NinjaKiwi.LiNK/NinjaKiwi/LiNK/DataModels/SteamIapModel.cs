namespace NinjaKiwi.LiNK.DataModels;

public class SteamIapModel
{
	public readonly string name; //Field offset: 0x10
	public readonly string priceLocalised; //Field offset: 0x18
	public readonly int priceRaw; //Field offset: 0x20
	public readonly int priceTier; //Field offset: 0x24

	public SteamIapModel(string name, string priceLocalised, int priceRaw, int priceTier) { }

}

