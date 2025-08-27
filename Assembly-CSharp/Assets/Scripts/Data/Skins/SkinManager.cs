namespace Assets.Scripts.Data.Skins;

public static class SkinManager
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public string skinId; //Field offset: 0x10

		public <>c__DisplayClass0_0() { }

		internal bool <GetSkin>b__0(SkinData s) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public string heroBaseId; //Field offset: 0x10

		public <>c__DisplayClass1_0() { }

		internal bool <GetAllSkins>b__0(SkinData s) { }

	}


	public static bool CanSkinBePurchasedWithMm(string skinId) { }

	public static IEnumerable<SkinData> GetAllSkins(string heroBaseId) { }

	public static string GetBaseTowerId(string skinId) { }

	public static int GetMMCost(string skinId) { }

	public static SkinData GetSkin(string skinId) { }

	public static SpriteReference GetSprite(string skinId) { }

	public static int GetTotalSkinsCount(bool includeHidden) { }

	public static string GetUnlockScreenName(string skinId) { }

	public static bool IsHiddenWhenLocked(string skinId) { }

	public static bool IsSkinFromIap(string skinId) { }

}

