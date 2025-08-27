namespace NinjaKiwi.GUTS.Models;

public class BossRushRandomizerSettings
{
	private static class DefaultValues
	{
		[CompilerGenerated]
		private sealed class <>c
		{
			public static readonly <>c <>9; //Field offset: 0x0
			public static Func<ContestedTerritoryRelicType, ContestedTerritoryRelicType> <>9__7_0; //Field offset: 0x8
			public static Func<ContestedTerritoryRelicType, Single> <>9__7_1; //Field offset: 0x10

			private static <>c() { }

			public <>c() { }

			internal ContestedTerritoryRelicType <GetDefaultRelicChances>b__7_0(ContestedTerritoryRelicType x) { }

			internal float <GetDefaultRelicChances>b__7_1(ContestedTerritoryRelicType z) { }

		}

		private const string kBeginner = "Beginner"; //Field offset: 0x0
		private const string kIntermediate = "Intermediate"; //Field offset: 0x0
		private const string kAdvanced = "Advanced"; //Field offset: 0x0
		private const string kExpert = "Expert"; //Field offset: 0x0

		internal static Dictionary<String, TowerLists[]> GetDefaultBossSpecialTowers() { }

		internal static Dictionary<String, Single> GetDefaultHeroChances() { }

		internal static Dictionary<ContestedTerritoryRelicType, Single> GetDefaultRelicChances() { }

		internal static Dictionary<String, BossRushTowerSettings> GetDefaultTowerSettings() { }

		internal static Dictionary<String, Single>[] GetMapDifficultyChances() { }

	}

	[CompilerGenerated]
	private Dictionary<String, Single>[] <MapDifficultyChances>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private float <ReversePercentageChance>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private int <FinalStageTowerCount>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <StageTowerIncrement>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private String[] <AvailableBosses>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private String[] <BannedMaps>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private ContestedTerritoryRelicType[] <BannedRelics>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private String[] <BannedHeroes>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private String[] <BannedTowers>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private Dictionary<ContestedTerritoryRelicType, Single> <RelicChances>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private Dictionary<String, Single> <HeroChances>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private Dictionary<String, BossRushTowerSettings> <TowerSettings>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Dictionary<String, TowerLists[]> <BossSpecialTowers>k__BackingField; //Field offset: 0x68

	public String[] AvailableBosses
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] BannedHeroes
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] BannedMaps
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public ContestedTerritoryRelicType[] BannedRelics
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] BannedTowers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<String, TowerLists[]> BossSpecialTowers
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int FinalStageTowerCount
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, Single> HeroChances
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<String, Single>[] MapDifficultyChances
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<ContestedTerritoryRelicType, Single> RelicChances
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public float ReversePercentageChance
	{
		[CompilerGenerated]
		 get { } //Length: 6
		[CompilerGenerated]
		 set { } //Length: 6
	}

	public int StageTowerIncrement
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Dictionary<String, BossRushTowerSettings> TowerSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossRushRandomizerSettings() { }

	[CompilerGenerated]
	public String[] get_AvailableBosses() { }

	[CompilerGenerated]
	public String[] get_BannedHeroes() { }

	[CompilerGenerated]
	public String[] get_BannedMaps() { }

	[CompilerGenerated]
	public ContestedTerritoryRelicType[] get_BannedRelics() { }

	[CompilerGenerated]
	public String[] get_BannedTowers() { }

	[CompilerGenerated]
	public Dictionary<String, TowerLists[]> get_BossSpecialTowers() { }

	[CompilerGenerated]
	public int get_FinalStageTowerCount() { }

	[CompilerGenerated]
	public Dictionary<String, Single> get_HeroChances() { }

	[CompilerGenerated]
	public Dictionary<String, Single>[] get_MapDifficultyChances() { }

	[CompilerGenerated]
	public Dictionary<ContestedTerritoryRelicType, Single> get_RelicChances() { }

	[CompilerGenerated]
	public float get_ReversePercentageChance() { }

	[CompilerGenerated]
	public int get_StageTowerIncrement() { }

	[CompilerGenerated]
	public Dictionary<String, BossRushTowerSettings> get_TowerSettings() { }

	[CompilerGenerated]
	public void set_AvailableBosses(String[] value) { }

	[CompilerGenerated]
	public void set_BannedHeroes(String[] value) { }

	[CompilerGenerated]
	public void set_BannedMaps(String[] value) { }

	[CompilerGenerated]
	public void set_BannedRelics(ContestedTerritoryRelicType[] value) { }

	[CompilerGenerated]
	public void set_BannedTowers(String[] value) { }

	[CompilerGenerated]
	public void set_BossSpecialTowers(Dictionary<String, TowerLists[]> value) { }

	[CompilerGenerated]
	public void set_FinalStageTowerCount(int value) { }

	[CompilerGenerated]
	public void set_HeroChances(Dictionary<String, Single> value) { }

	[CompilerGenerated]
	public void set_MapDifficultyChances(Dictionary<String, Single>[] value) { }

	[CompilerGenerated]
	public void set_RelicChances(Dictionary<ContestedTerritoryRelicType, Single> value) { }

	[CompilerGenerated]
	public void set_ReversePercentageChance(float value) { }

	[CompilerGenerated]
	public void set_StageTowerIncrement(int value) { }

	[CompilerGenerated]
	public void set_TowerSettings(Dictionary<String, BossRushTowerSettings> value) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

