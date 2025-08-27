namespace NinjaKiwi.GUTS.Models.CT;

public class Btd6CtSettings : CtSettings
{
	private static readonly TimeSpan MinScoringInterval; //Field offset: 0x0
	[CompilerGenerated]
	private int <MapSize>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private RelicSettings <Relics>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Dictionary<CtTileType, ContestedTerritoryRewardSettings> <RewardSettings>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private Dictionary<CtTileType, ScoringSettings> <TileTypeScoring>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private Dictionary<CtTileType, ScoreIncrementSettings> <TileScoreIncrements>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private CtMapGenerationSettings <MapGenerationSettings>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private LeaderboardRewards <LeaderboardRewards>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private float <ElDoradoMultiplier>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private BonusRewards <BonusRewards>k__BackingField; //Field offset: 0x98

	public BonusRewards BonusRewards
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public float ElDoradoMultiplier
	{
		[CompilerGenerated]
		 get { } //Length: 9
		[CompilerGenerated]
		 set { } //Length: 9
	}

	public LeaderboardRewards LeaderboardRewards
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public CtMapGenerationSettings MapGenerationSettings
	{
		[CompilerGenerated]
		 get { } //Length: 8
		[CompilerGenerated]
		 set { } //Length: 8
	}

	public int MapSize
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public RelicSettings Relics
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<CtTileType, ContestedTerritoryRewardSettings> RewardSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<CtTileType, ScoreIncrementSettings> TileScoreIncrements
	{
		[CompilerGenerated]
		 get { } //Length: 70
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Dictionary<CtTileType, ScoringSettings> TileTypeScoring
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	private static Btd6CtSettings() { }

	public Btd6CtSettings() { }

	[CompilerGenerated]
	public BonusRewards get_BonusRewards() { }

	[CompilerGenerated]
	public float get_ElDoradoMultiplier() { }

	[CompilerGenerated]
	public LeaderboardRewards get_LeaderboardRewards() { }

	[CompilerGenerated]
	public CtMapGenerationSettings get_MapGenerationSettings() { }

	[CompilerGenerated]
	public int get_MapSize() { }

	[CompilerGenerated]
	public RelicSettings get_Relics() { }

	[CompilerGenerated]
	public Dictionary<CtTileType, ContestedTerritoryRewardSettings> get_RewardSettings() { }

	[CompilerGenerated]
	public Dictionary<CtTileType, ScoreIncrementSettings> get_TileScoreIncrements() { }

	[CompilerGenerated]
	public Dictionary<CtTileType, ScoringSettings> get_TileTypeScoring() { }

	public int GetElDoradoBonusRewards(int baseReward) { }

	[CompilerGenerated]
	public void set_BonusRewards(BonusRewards value) { }

	[CompilerGenerated]
	public void set_ElDoradoMultiplier(float value) { }

	[CompilerGenerated]
	public void set_LeaderboardRewards(LeaderboardRewards value) { }

	[CompilerGenerated]
	public void set_MapGenerationSettings(CtMapGenerationSettings value) { }

	[CompilerGenerated]
	public void set_MapSize(int value) { }

	[CompilerGenerated]
	public void set_Relics(RelicSettings value) { }

	[CompilerGenerated]
	public void set_RewardSettings(Dictionary<CtTileType, ContestedTerritoryRewardSettings> value) { }

	[CompilerGenerated]
	public void set_TileScoreIncrements(Dictionary<CtTileType, ScoreIncrementSettings> value) { }

	[CompilerGenerated]
	public void set_TileTypeScoring(Dictionary<CtTileType, ScoringSettings> value) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

