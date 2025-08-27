//Type is in global namespace

public class SteamPurchasingModule : AbstractPurchasingModule
{
	private static SteamPurchasingModule instance; //Field offset: 0x0
	private static SteamStore currentStore; //Field offset: 0x8

	public SteamPurchasingModule() { }

	public virtual void Configure() { }

	public static SteamPurchasingModule Instance() { }

	private IStore InstantiateMyStore() { }

}

