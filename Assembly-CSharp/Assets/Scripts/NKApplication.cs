namespace Assets.Scripts;

[Extension]
public static class NKApplication
{
	private static IFileIO persistentStorage; //Field offset: 0x0
	private const float kMonkeyMoneyMultiplier = 1.5; //Field offset: 0x0
	private const int StoresWithIAPValidation = 722; //Field offset: 0x0
	private static IFileIO temporaryStorage; //Field offset: 0x8
	private static Nullable<Boolean> isChromebook; //Field offset: 0x10

	public static bool CanShowLiNKLogout
	{
		 get { } //Length: 3
	}

	public static bool CanShowLiNKWebview
	{
		 get { } //Length: 3
	}

	public static bool CanSupportNexusContentCreator
	{
		 get { } //Length: 58
	}

	public static bool CloudDiagnosticsEnabled
	{
		 get { } //Length: 3
	}

	public static bool CrossPromoEnabled
	{
		 get { } //Length: 3
	}

	public static bool ForceHighResAndQuality
	{
		 get { } //Length: 3
	}

	public static bool IAPsEnabled
	{
		 get { } //Length: 58
	}

	public static bool IsAppleArcade
	{
		 get { } //Length: 3
	}

	public static bool IsAppleArcadeOrNetflix
	{
		 get { } //Length: 3
	}

	public static bool IsChromebook
	{
		 get { } //Length: 67
	}

	public static bool IsDebug
	{
		 get { } //Length: 3
	}

	public static bool IsEpic
	{
		 get { } //Length: 3
	}

	public static bool IsMobile
	{
		 get { } //Length: 3
	}

	public static bool IsNetflix
	{
		 get { } //Length: 3
	}

	public static bool IsSteam
	{
		 get { } //Length: 3
	}

	public static bool IsSwitch
	{
		 get { } //Length: 3
	}

	public static bool IsVisionOS
	{
		 get { } //Length: 3
	}

	public static bool IsWindowsStore
	{
		 get { } //Length: 3
	}

	public static IFileIO PersistentStorage
	{
		 get { } //Length: 115
		 set { } //Length: 60
	}

	public static RuntimePlatform platform
	{
		 get { } //Length: 64
	}

	public static bool SilentLiNKAccount
	{
		 get { } //Length: 3
	}

	public static Strategy StorageStrategy
	{
		 get { } //Length: 6
	}

	public static Store Store
	{
		 get { } //Length: 3
	}

	public static bool SupportsCursor
	{
		 get { } //Length: 3
	}

	public static bool SupportsGamepad
	{
		 get { } //Length: 3
	}

	public static bool SupportsKeyboard
	{
		 get { } //Length: 3
	}

	public static bool SupportsResolution
	{
		 get { } //Length: 3
	}

	public static IFileIO TemporaryStorage
	{
		 get { } //Length: 117
		 set { } //Length: 61
	}

	public static bool get_CanShowLiNKLogout() { }

	public static bool get_CanShowLiNKWebview() { }

	public static bool get_CanSupportNexusContentCreator() { }

	public static bool get_CloudDiagnosticsEnabled() { }

	public static bool get_CrossPromoEnabled() { }

	public static bool get_ForceHighResAndQuality() { }

	public static bool get_IAPsEnabled() { }

	public static bool get_IsAppleArcade() { }

	public static bool get_IsAppleArcadeOrNetflix() { }

	public static bool get_IsChromebook() { }

	public static bool get_IsDebug() { }

	public static bool get_IsEpic() { }

	public static bool get_IsMobile() { }

	public static bool get_IsNetflix() { }

	public static bool get_IsSteam() { }

	public static bool get_IsSwitch() { }

	public static bool get_IsVisionOS() { }

	public static bool get_IsWindowsStore() { }

	public static IFileIO get_PersistentStorage() { }

	public static RuntimePlatform get_platform() { }

	public static bool get_SilentLiNKAccount() { }

	public static Strategy get_StorageStrategy() { }

	public static Store get_Store() { }

	public static bool get_SupportsCursor() { }

	public static bool get_SupportsGamepad() { }

	public static bool get_SupportsKeyboard() { }

	public static bool get_SupportsResolution() { }

	public static IFileIO get_TemporaryStorage() { }

	public static IHttpDataLoader GetDataLoader(string url, bool usePersistentStorage) { }

	[Extension]
	public static int GetScaledMM(int baseQty) { }

	[Extension]
	private static bool HasIAPValidation(Store store) { }

	public static void set_PersistentStorage(IFileIO value) { }

	public static void set_TemporaryStorage(IFileIO value) { }

}

