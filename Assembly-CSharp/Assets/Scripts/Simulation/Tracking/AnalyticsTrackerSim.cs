namespace Assets.Scripts.Simulation.Tracking;

public class AnalyticsTrackerSim : RootBehavior
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal string <.cctor>b__56_0(Byte[] data) { }

		internal Byte[] <.cctor>b__56_1(string data) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public string baseTowerName; //Field offset: 0x10
		public int round; //Field offset: 0x18
		public AnalyticsTrackerSim <>4__this; //Field offset: 0x20
		public int towerX; //Field offset: 0x28
		public int towerY; //Field offset: 0x2C

		public <>c__DisplayClass19_0() { }

		internal bool <OnTargetTypeChanged>b__0(TargettingChangeSummary x) { }

	}

	private static readonly StorageManager storageManager; //Field offset: 0x0
	private int playerId; //Field offset: 0x58
	public AnalyticsGameSessionInfo sessionInfo; //Field offset: 0x60
	public AnalyticsGameSessionInfo lastSessionInfo; //Field offset: 0x68
	private readonly AnalyticsKonFuze change; //Field offset: 0x70

	private static AnalyticsTrackerSim() { }

	public AnalyticsTrackerSim() { }

	public void AddNamedMonkey(Tower tower) { }

	private void CheckAxisOfHavokAchievement() { }

	public static void Delete(string key) { }

	public static bool Exists(string key) { }

	private int GetCurrentRound() { }

	public string GetDataAsString() { }

	public AnalyticsKonFuze GetProfileInfoChange() { }

	public void Initialise(int playerId) { }

	private void Load(AnalyticsGameSessionInfo sessionInfo) { }

	public void Load(string key) { }

	private static AnalyticsGameSessionInfo LoadFromDisk(string key) { }

	public void OnAbilityActivated(Tower tower, Ability ability, int livesCost, bool ignoreCooldown) { }

	public void OnBADPop(Tower tower) { }

	public void OnBFBPop(Tower tower) { }

	public void OnBloonLeaked(Bloon bloon, float livesBefore, float livesAfter, float manaShieldBefore, float manaShieldAfter) { }

	public void OnBossDamage(Tower tower, long damage) { }

	public void OnBossPop(Tower tower) { }

	public void OnBossRushLose(int round) { }

	public void OnCamoPop(int amount, Tower tower) { }

	public void OnCashEarned(int playerId, double cash, CashType from, CashSource source, Tower tower) { }

	public void OnCashSpent(int playerId, double cash, CashType from, CashSource source) { }

	public void OnCeramicPop(Tower tower) { }

	public void OnCrit() { }

	public void OnDdtFortifiedRemoved(Bloon bloon) { }

	public void OnDDTPop(Tower tower) { }

	protected virtual void OnDestroy() { }

	public void OnHeroExpGained(float expGained) { }

	public void OnHeroLevelChanged(int heroLevel) { }

	private void OnHeroPlaced(string heroName) { }

	public void OnHeroSold(string heroSold) { }

	public void OnLeadPop(Tower tower) { }

	public void OnLivesLost(double amount) { }

	public void OnMOABPop(Tower tower) { }

	public void OnParagonUpgraded(Tower tower, float cost, double cashBefore, double cashAfter) { }

	public void OnPopBloon(int amount, Tower tower) { }

	private void OnPowerActive(PowerModel def, float locationX, float locationY, int inputId) { }

	public void OnPurplePop(Tower tower) { }

	public void OnReanimateNecroBloons(int amount) { }

	public void OnRegrowPop(int amount, Tower tower) { }

	public void OnRoundEnd(int round) { }

	public void OnShieldLost(double amount) { }

	private void OnTargetTypeChanged(Tower tower, TargetType type) { }

	public void OnTowerPlaced(Tower tower, TowerModel def, float cost, bool isFromSave, double cashBefore, double cashAfter, bool isInsta) { }

	public void OnTowerSacrificed(Tower tower, Tower sacrificedTo) { }

	public void OnTowerSold(Tower tower, float claim, double cashBefore, double cashAfter) { }

	public void OnTowerUpgraded(Tower tower, TowerModel def, float cost, int pathUpgraded, double cashBefore, double cashAfter, bool playUpgradeEffect, bool isParagon, bool leveledFromEndOfRoundXp, double nonUpgradeCashInvestment) { }

	private void OnWon() { }

	public void OnZOMGPop(Tower tower) { }

	public void Save(string key) { }

	private bool TryGetNamedMonkeyStats(Tower tower, out NamedMonkeyStats stats) { }

}

