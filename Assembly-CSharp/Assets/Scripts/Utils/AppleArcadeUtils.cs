namespace Assets.Scripts.Utils;

[Extension]
public static class AppleArcadeUtils
{
	public const int kRankLock = 20; //Field offset: 0x0
	public static PlayerPrefInt CurrentSaveSlot; //Field offset: 0x0
	public const int kSaveSlotCount = 3; //Field offset: 0x0
	private static PlayerPrefBool[] dataConsentFlags; //Field offset: 0x8

	public static bool HasDataConsent
	{
		 get { } //Length: 319
		 set { } //Length: 207
	}

	public static bool IsChildAccount
	{
		 get { } //Length: 3
	}

	public static bool IsOnlineStatusEnabled
	{
		 get { } //Length: 99
		 set { } //Length: 159
	}

	public static bool IsRankLocked
	{
		 get { } //Length: 115
	}

	private static bool LocalConsentFlag
	{
		private get { } //Length: 152
		private set { } //Length: 161
	}

	private static AppleArcadeUtils() { }

	private static PlayerPrefBool EnsureLocalConsentFlag(int i) { }

	public static bool get_HasDataConsent() { }

	public static bool get_IsChildAccount() { }

	public static bool get_IsOnlineStatusEnabled() { }

	public static bool get_IsRankLocked() { }

	private static bool get_LocalConsentFlag() { }

	public static AppleArcadeToken GetTokenForCurrentSlot() { }

	private static AppleArcadeToken GetTokenForSlot(string uuid, int slotIdx) { }

	public static AppleArcadeToken GetTokenForSlot(int slotIdx) { }

	[Extension]
	public static bool IsAppleArcadePlayer(UserModel userModel) { }

	public static void MigrateOrphanedData(string old_uuid, string new_uuid) { }

	private static string PathForArcadeSlotSave(string uuid, int slotIdx) { }

	public static void set_HasDataConsent(bool value) { }

	public static void set_IsOnlineStatusEnabled(bool value) { }

	private static void set_LocalConsentFlag(bool value) { }

}

