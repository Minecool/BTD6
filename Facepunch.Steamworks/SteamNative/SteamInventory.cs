namespace SteamNative;

internal class SteamInventory : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<SteamItemDef_t, Int32> <>9__37_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal int <StartPurchase>b__37_0(SteamItemDef_t x) { }

	}

	internal Interface platform; //Field offset: 0x10
	internal BaseSteamworks steamworks; //Field offset: 0x18

	internal SteamInventory(BaseSteamworks steamworks, IntPtr pointer) { }

	public void DestroyResult(SteamInventoryResult_t resultHandle) { }

	public override void Dispose() { }

	public bool GetAllItems(ref SteamInventoryResult_t pResultHandle) { }

	public SteamItemDef_t[] GetItemDefinitionIDs() { }

	public bool GetItemDefinitionProperty(SteamItemDef_t iDefinition, string pchPropertyName, out string pchValueBuffer) { }

	public bool GetItemPrice(SteamItemDef_t iDefinition, out ulong pPrice) { }

	public bool GetResultItemProperty(SteamInventoryResult_t resultHandle, uint unItemIndex, string pchPropertyName, out string pchValueBuffer) { }

	public SteamItemDetails_t[] GetResultItems(SteamInventoryResult_t resultHandle) { }

	public Result GetResultStatus(SteamInventoryResult_t resultHandle) { }

	public uint GetResultTimestamp(SteamInventoryResult_t resultHandle) { }

	public bool LoadItemDefinitions() { }

	public CallbackHandle RequestPrices(Action<SteamInventoryRequestPricesResult_t, Boolean> CallbackFunction = null) { }

	public bool SerializeResult(SteamInventoryResult_t resultHandle, IntPtr pOutBuffer, out uint punOutBufferSize) { }

	public CallbackHandle StartPurchase(SteamItemDef_t[] pArrayItemDefs, UInt32[] punArrayQuantity, uint unArrayLength, Action<SteamInventoryStartPurchaseResult_t, Boolean> CallbackFunction = null) { }

}

