namespace Assets.Scripts.Data.Legends;

public class UpgradeDiscountXpShopMod : RogueXpShopMod
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Single, Boolean> <>9__2_0; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <GetBuffText>b__2_0(float x) { }

	}

	public Single[] tierDiscountsPerLevel; //Field offset: 0x10

	public UpgradeDiscountXpShopMod() { }

	public virtual void ApplyMapStartEffect(int level, ILegendsDataProvider legendsDataProvider) { }

	public virtual string GetBuffText(int level) { }

}

