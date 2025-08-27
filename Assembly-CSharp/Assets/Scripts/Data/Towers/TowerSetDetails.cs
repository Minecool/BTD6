namespace Assets.Scripts.Data.Towers;

[CreateAssetMenu(menuName = "BTD6/Tower Set")]
public class TowerSetDetails : ScriptableObject
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<ShopTowerDetails, Boolean> <>9__9_0; //Field offset: 0x8
		public static Func<ShopTowerDetails, Int32, ShopTowerDetailsModel> <>9__9_1; //Field offset: 0x10
		public static Func<HeroDetails, Boolean> <>9__11_0; //Field offset: 0x18
		public static Func<HeroDetails, Int32, HeroDetailsModel> <>9__11_1; //Field offset: 0x20

		private static <>c() { }

		public <>c() { }

		internal bool <get_HeroDetailsModels>b__11_0(HeroDetails t) { }

		internal HeroDetailsModel <get_HeroDetailsModels>b__11_1(HeroDetails h, int i) { }

		internal bool <get_TowerDetailsModels>b__9_0(ShopTowerDetails t) { }

		internal ShopTowerDetailsModel <get_TowerDetailsModels>b__9_1(ShopTowerDetails t, int i) { }

	}

	internal class HeroDetails : TowerDetails
	{
		public int upgradeMax; //Field offset: 0x20
		public int visibilePlayerLevel; //Field offset: 0x24
		public int monkeyMoneyCost; //Field offset: 0x28
		public bool newestHero; //Field offset: 0x2C

		public HeroDetails() { }

	}

	private class HeroDetailsContainer
	{
		public HeroDetails[] items; //Field offset: 0x10

		public HeroDetailsContainer() { }

	}

	internal class ShopTowerDetails : TowerDetails
	{
		public int pathOneMax; //Field offset: 0x20
		public int pathTwoMax; //Field offset: 0x24
		public int pathThreeMax; //Field offset: 0x28

		public ShopTowerDetails() { }

	}

	internal abstract class TowerDetails
	{
		public string name; //Field offset: 0x10
		public int towerCount; //Field offset: 0x18
		public int popsRequired; //Field offset: 0x1C

		protected TowerDetails() { }

	}

	private class TowerDetailsContainer
	{
		public ShopTowerDetails[] items; //Field offset: 0x10

		public TowerDetailsContainer() { }

	}

	[ReorderableList("items", True)]
	[SerializeField]
	private TowerDetailsContainer towers; //Field offset: 0x18
	[ReorderableList("items", True)]
	[SerializeField]
	private HeroDetailsContainer heroes; //Field offset: 0x20

	public TowerDetailsModel[] HeroDetailsModels
	{
		 get { } //Length: 484
	}

	public TowerDetailsModel[] TowerDetailsModels
	{
		 get { } //Length: 484
	}

	public TowerSetDetails() { }

	public void AddHero(HeroDetails heroDetails) { }

	public TowerDetailsModel[] get_HeroDetailsModels() { }

	public TowerDetailsModel[] get_TowerDetailsModels() { }

}

