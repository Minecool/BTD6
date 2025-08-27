namespace NinjaKiwi.GUTS.Models.CT.BTD6;

public class CtTile
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<KeyValuePair`2<ContestedTerritoryGameType, ContestedTerritoryGameSettings>, Boolean> <>9__41_0; //Field offset: 0x8
		public static Func<KeyValuePair`2<ContestedTerritoryGameType, ContestedTerritoryGameSettings>, ContestedTerritoryGameType> <>9__41_1; //Field offset: 0x10
		public static Func<KeyValuePair`2<ContestedTerritoryGameType, ContestedTerritoryGameSettings>, ContestedTerritoryGameSettings> <>9__41_2; //Field offset: 0x18

		private static <>c() { }

		public <>c() { }

		internal bool <GenerateBaseRules>b__41_0(KeyValuePair<ContestedTerritoryGameType, ContestedTerritoryGameSettings> x) { }

		internal ContestedTerritoryGameType <GenerateBaseRules>b__41_1(KeyValuePair<ContestedTerritoryGameType, ContestedTerritoryGameSettings> x) { }

		internal ContestedTerritoryGameSettings <GenerateBaseRules>b__41_2(KeyValuePair<ContestedTerritoryGameType, ContestedTerritoryGameSettings> x) { }

	}

	[CompilerGenerated]
	private int <Id>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <X>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <Y>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private CtTileType <TileType>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private ContestedTerritoryRelicType <RelicType>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <TeamIndex>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <RandomiserSeed>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private ContestedTerritoryIslandTileRulesBase <BaseRules>k__BackingField; //Field offset: 0x30

	public private ContestedTerritoryIslandTileRulesBase BaseRules
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		private set { } //Length: 5
	}

	public string Code
	{
		 get { } //Length: 333
	}

	public int DistanceToCenter
	{
		 get { } //Length: 90
	}

	public int Id
	{
		[CompilerGenerated]
		 get { } //Length: 94
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public float Probability
	{
		 get { } //Length: 151
	}

	public int RandomiserSeed
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public ContestedTerritoryRelicType RelicType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public CtTileType RewardTileType
	{
		 get { } //Length: 47
	}

	public int TeamIndex
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public CtTileType TileType
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int X
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public int Y
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public CtTile() { }

	public void GenerateBaseRules(CtMapGenerationSettings mapGenerationSettings) { }

	[CompilerGenerated]
	public ContestedTerritoryIslandTileRulesBase get_BaseRules() { }

	public string get_Code() { }

	public int get_DistanceToCenter() { }

	[CompilerGenerated]
	public int get_Id() { }

	public float get_Probability() { }

	[CompilerGenerated]
	public int get_RandomiserSeed() { }

	[CompilerGenerated]
	public ContestedTerritoryRelicType get_RelicType() { }

	public CtTileType get_RewardTileType() { }

	[CompilerGenerated]
	public int get_TeamIndex() { }

	[CompilerGenerated]
	public CtTileType get_TileType() { }

	[CompilerGenerated]
	public int get_X() { }

	[CompilerGenerated]
	public int get_Y() { }

	[CompilerGenerated]
	private void set_BaseRules(ContestedTerritoryIslandTileRulesBase value) { }

	[CompilerGenerated]
	public void set_Id(int value) { }

	[CompilerGenerated]
	public void set_RandomiserSeed(int value) { }

	[CompilerGenerated]
	public void set_RelicType(ContestedTerritoryRelicType value) { }

	[CompilerGenerated]
	public void set_TeamIndex(int value) { }

	[CompilerGenerated]
	public void set_TileType(CtTileType value) { }

	[CompilerGenerated]
	public void set_X(int value) { }

	[CompilerGenerated]
	public void set_Y(int value) { }

}

