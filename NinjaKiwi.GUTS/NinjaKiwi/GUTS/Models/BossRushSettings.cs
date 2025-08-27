namespace NinjaKiwi.GUTS.Models;

public class BossRushSettings
{
	public const int kMaxStageCount = 8; //Field offset: 0x0
	public const int kMaxScoreSlots = 4; //Field offset: 0x0
	[CompilerGenerated]
	private Int32[] <StageScores>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <DailyScoreSlots>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private String[] <StageRewards>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private BossRushTicketSettings <TicketSettings>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private BossRushRandomizerSettings <RandomSettings>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private BossRushBalanceSettings <BalanceSettings>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private BossRushRandomSettingsOverrides <Overrides>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	private Nullable<Int32> <MaximumScore>k__BackingField; //Field offset: 0x48

	public BossRushBalanceSettings BalanceSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public int DailyScoreSlots
	{
		[CompilerGenerated]
		 get { } //Length: 4
		[CompilerGenerated]
		 set { } //Length: 4
	}

	public Nullable<Int32> MaximumScore
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossRushRandomSettingsOverrides Overrides
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossRushRandomizerSettings RandomSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public String[] StageRewards
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public Int32[] StageScores
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossRushTicketSettings TicketSettings
	{
		[CompilerGenerated]
		 get { } //Length: 5
		[CompilerGenerated]
		 set { } //Length: 5
	}

	public BossRushSettings() { }

	[CompilerGenerated]
	public BossRushBalanceSettings get_BalanceSettings() { }

	[CompilerGenerated]
	public int get_DailyScoreSlots() { }

	[CompilerGenerated]
	public Nullable<Int32> get_MaximumScore() { }

	[CompilerGenerated]
	public BossRushRandomSettingsOverrides get_Overrides() { }

	[CompilerGenerated]
	public BossRushRandomizerSettings get_RandomSettings() { }

	[CompilerGenerated]
	public String[] get_StageRewards() { }

	[CompilerGenerated]
	public Int32[] get_StageScores() { }

	[CompilerGenerated]
	public BossRushTicketSettings get_TicketSettings() { }

	public float GetBossHealthMultiplier(string bossName) { }

	public int GetBossShield(string bossName) { }

	public float GetBossSpeedMultiplier(string bossName) { }

	public int GetInitialHealth(string bossName, int stage) { }

	public int GetKillCash(string bossName) { }

	public float GetKillCashMultiplier(string mapName) { }

	public Nullable<Int32> GetRequiredScore(int bossStage) { }

	public string GetStageRewards(int stage) { }

	public int GetStartingCash(string bossName, int stage) { }

	[CompilerGenerated]
	public void set_BalanceSettings(BossRushBalanceSettings value) { }

	[CompilerGenerated]
	public void set_DailyScoreSlots(int value) { }

	[CompilerGenerated]
	public void set_MaximumScore(Nullable<Int32> value) { }

	[CompilerGenerated]
	public void set_Overrides(BossRushRandomSettingsOverrides value) { }

	[CompilerGenerated]
	public void set_RandomSettings(BossRushRandomizerSettings value) { }

	[CompilerGenerated]
	public void set_StageRewards(String[] value) { }

	[CompilerGenerated]
	public void set_StageScores(Int32[] value) { }

	[CompilerGenerated]
	public void set_TicketSettings(BossRushTicketSettings value) { }

	[OnDeserialized]
	public void Validate(StreamingContext context = null) { }

}

